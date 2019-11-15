using Abp.Domain.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace reactjs.Models
{
    public interface ICategoryManager: IDomainService
    {
        IEnumerable<Category> GetAllList();
        Category GetCategoryById(int id);
        Task<Category> Create(Category entity);
        void Update(Category entity);
        void Delete(int id);
    }
}
