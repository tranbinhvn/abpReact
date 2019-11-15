using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace reactjs.Models
{
    public interface IBookManager: IDomainService
    {
        IEnumerable<Book> GetAllList();
        Book GetBookById(int id);
        Task<Book> Create(Book entity);
        void Update(Book entity);
        void Delete(int id);
    }
}
