using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reactjs.Models
{
    public class AuthorManager : DomainService, IAuthorManager
    {
        private readonly IRepository<Author> _repoAuthor;
        public AuthorManager(IRepository<Author> repoAuthor)
        {
            _repoAuthor = repoAuthor;
        }
        public async Task<Author> Create(Author entity)
        {
            var author = _repoAuthor.FirstOrDefault(x => x.Id == entity.Id);
            if (author != null)
            {
                throw new UserFriendlyException("Already Exist");
            }
            else
            {
                return await _repoAuthor.InsertAsync(entity);
            }

        }

        public void Delete(int id)
        {
            var author = _repoAuthor.FirstOrDefault(x => x.Id == id);
            if(author == null)
            {
                throw new UserFriendlyException("No Data Found");
            }
            else
            {
                _repoAuthor.Delete(author);
            }
        }

        public IQueryable<Author> GetAllList()
        {
            return _repoAuthor.GetAllIncluding(x => x.Books);
        }

        public Author GetAuthorById(int id)
        {
            return _repoAuthor.Get(id);
        }

        public void Update(Author entity)
        {
            _repoAuthor.Update(entity);
        }
    }
}
