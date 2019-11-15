using Abp.Domain.Repositories;
using Abp.Domain.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace reactjs.Models
{
    public class BookManager: DomainService, IBookManager
    {
        private readonly IRepository<Book> _repoBook;
        public BookManager(IRepository<Book> repoBook)
        {
            _repoBook = repoBook;
        }

        public async Task<Book> Create(Book entity)
        {
            var book = _repoBook.FirstOrDefault(x => x.Id == entity.Id);
            if(book != null)
            {
                throw new Abp.UI.UserFriendlyException("Already exits");
            }
            else
            {
               return await _repoBook.InsertAsync(entity);
            }
        }

        public void Delete(int id)
        {
            var book = _repoBook.FirstOrDefault(x => x.Id == id);
            if(book == null)
            {
                throw new Abp.UI.UserFriendlyException("No Data Found");
            }
            else
            {
                _repoBook.Delete(book);
            }
        }

        public IEnumerable<Book> GetAllList()
        {
            return _repoBook.GetAll();
        }

        public Book GetBookById(int id)
        {
            return _repoBook.Get(id);
        }

        public void Update(Book entity)
        {
            _repoBook.Update(entity);
        }
    }
}
