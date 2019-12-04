using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using reactjs.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace aspReact.Categories.Dto
{
    [AutoMapFrom(typeof(Category))]
    public class CategoryDto: EntityDto<int>
    {
        public string DispalyName { get; set; }
    }
}
