using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using reactjs.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace aspReact.Books.DTO
{
    [AutoMapFrom(typeof(Book))]
    public class BookDto: FullAuditedEntityDto
    {
        public string DispalyName { get; set; }
        public Nullable<int> TotalPageNumber { get; set; }
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }
        public virtual Author Author { get; set; }
        public virtual Category Category { get; set; }
    }
}
