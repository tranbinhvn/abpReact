using Abp.Domain.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace reactjs.Models
{
    public interface IAuthorManager: IDomainService
    {
        IEnumerable<Author> GetAllList();
        Author GetAuthorById(int id);
        Task<Author> Create(Author entity);
        void Update(Author entity);
        void Delete(int id);
    }
}
