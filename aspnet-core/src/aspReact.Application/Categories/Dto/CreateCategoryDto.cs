using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using reactjs.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace aspReact.Categories.Dto
{
    [AutoMapTo(typeof(Category))]
    public class CreateCategoryInput
    {
        public string DispalyName { get; set; }
    }
    [AutoMapTo(typeof(Category))]
    public class UpdateCategoryInput : EntityDto<int>
    {
        public string DispalyName { get; set; }
    }
}
