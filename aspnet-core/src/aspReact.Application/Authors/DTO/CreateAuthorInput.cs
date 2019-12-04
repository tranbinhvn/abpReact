using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using reactjs.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace aspReact.Authors.DTO
{
    [AutoMapTo(typeof(Author))]
    public class CreateAuthorInput: EntityDto<int>
    {
        //public int Id { get; set; }
        public string DispalyName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime? DeathDate { get; set; }
        //public virtual ICollection<Book> Books { get; set; }
    }
}
