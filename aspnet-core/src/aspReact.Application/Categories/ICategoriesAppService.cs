using Abp.Application.Services;
using Abp.Application.Services.Dto;
using aspReact.Books.DTO;
using aspReact.Categories.Dto;
using reactjs.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace aspReact.Categories
{
    public interface ICategoriesAppService: IAsyncCrudAppService<CategoryDto, int, PagedAndSortedResultRequestDto,CreateCategoryInput,UpdateCategoryInput>
    {
    }
}
