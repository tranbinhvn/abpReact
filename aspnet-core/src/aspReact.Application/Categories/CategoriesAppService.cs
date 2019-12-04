using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using aspReact.Authorization;
using aspReact.Categories;
using aspReact.Categories.Dto;
using reactjs.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace aspReact.Categorys
{
    [AbpAuthorize(PermissionNames.Pages_Categories)]
    public class CategoriesAppService : AsyncCrudAppService<Category, CategoryDto, int, PagedAndSortedResultRequestDto, CreateCategoryInput, UpdateCategoryInput>, ICategoriesAppService
    {
        public CategoriesAppService(IRepository<Category,int> repository): base(repository)
        {

        }
    }
}
