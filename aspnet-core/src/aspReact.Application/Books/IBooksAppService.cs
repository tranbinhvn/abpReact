using Abp.Application.Services;
using Abp.Application.Services.Dto;
using aspReact.Books.DTO;
using reactjs.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace aspReact.Books
{
    public interface IBooksAppService: IAsyncCrudAppService<BookDto, int, PagedAndSortedResultRequestDto,CreateBookDto,BookDto>
    {
    }
}
