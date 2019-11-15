using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace reactjs.Models
{
    public class CategoryManager : DomainService, ICategoryManager
    {
        private readonly IRepository<Category> _repoCategory;
        public CategoryManager(IRepository<Category> repoCategory)
        {
            _repoCategory = repoCategory;
        }
        public async Task<Category> Create(Category entity)
        {
            var Category = _repoCategory.FirstOrDefault(x => x.Id == entity.Id);
            if (Category != null)
            {
                throw new UserFriendlyException("Already Exist");
            }
            else
            {
                return await _repoCategory.InsertAsync(entity);
            }

        }

        public void Delete(int id)
        {
            var Category = _repoCategory.FirstOrDefault(x => x.Id == id);
            if (Category == null)
            {
                throw new UserFriendlyException("No Data Found");
            }
            else
            {
                _repoCategory.Delete(Category);
            }
        }

        public IEnumerable<Category> GetAllList()
        {
            return _repoCategory.GetAllIncluding(x => x.Books);
        }

        public Category GetCategoryById(int id)
        {
            return _repoCategory.Get(id);
        }

        public void Update(Category entity)
        {
            _repoCategory.Update(entity);
        }
    }
}
