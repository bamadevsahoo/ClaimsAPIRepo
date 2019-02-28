using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.Azure.Documents;

namespace InsuranceClaims
{
    public interface IClaimsDocumentDBRepository<T> where T : class
    {
        Task<Document> CreateItemAsync(T item);
        Task<IEnumerable<T>> GetItemsAsync();
    }
}
