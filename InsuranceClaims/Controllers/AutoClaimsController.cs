using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InsuranceClaims.Models;
using System.Web.Http;

namespace InsuranceClaims.Controllers
{
    [Route("api/AutoClaimsAPI")]
    [ApiController]
    public class AutoClaimsController : ControllerBase
    {
        private readonly IClaimsDocumentDBRepository<AutoClaim> ClaimRespository;
        public AutoClaimsController(IClaimsDocumentDBRepository<AutoClaim> ClaimRespository)
        {
            this.ClaimRespository = ClaimRespository;
        }

        [HttpGet]
        [Route("AllClaims")]
        public IActionResult GetAsync()
        {

            var ClaimsRes = ClaimRespository.GetItemsAsync().Result;
            return Ok(ClaimsRes);
        }
        [HttpGet]
        [Route("GetClaims/{claimNumber}")]
        public IActionResult GetClaimAsync(string claimNumber)
        {

            var ClaimsRes = ClaimRespository.GetItemsAsync().Result.Where(x=>x.claimNumber == claimNumber).FirstOrDefault();
            return Ok(ClaimsRes);
        }

        [HttpPost]
        [Route("CreateClaim")]
        public IActionResult Post([FromBody] AutoClaim value)
        {
            value.claimIdIdentity = (ClaimRespository.GetItemsAsync().Result.Count() == 0)? 1 :  ClaimRespository.GetItemsAsync().Result.Max(x => x.claimIdIdentity) +1;
            value.claimNumber = "CLM" + value.claimIdIdentity.ToString();
            var ClaimsCreate = ClaimRespository.CreateItemAsync(value).Result;
            return Ok(ClaimsCreate);
        }


        //// GET api/values
        //[HttpGet]
        //public ActionResult<IEnumerable<string>> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/values/5
        //[HttpGet("{id}")]
        //public ActionResult<string> Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
