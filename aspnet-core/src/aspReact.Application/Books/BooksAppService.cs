using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using aspReact.Authorization;
using aspReact.Books.DTO;
using reactjs.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace aspReact.Books
{
    [AbpAuthorize(PermissionNames.Pages_Books)]
    public class BooksAppService : AsyncCrudAppService<Book, BookDto, int, PagedAndSortedResultRequestDto, CreateBookDto, BookDto>, IBooksAppService
    {
        public BooksAppService(IRepository<Book,int> repository): base(repository)
        {

        }
    }
}
