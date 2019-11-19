using Abp.Domain.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reactjs.Models
{
    public interface IAuthorManager: IDomainService
    {
        IQueryable<Author> GetAllList();
        Author GetAuthorById(int id);
        Task<Author> Create(Author entity);
        void Update(Author entity);
        void Delete(int id);
    }
}
