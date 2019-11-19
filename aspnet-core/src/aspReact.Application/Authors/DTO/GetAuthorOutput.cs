using Abp.AutoMapper;
using reactjs.Models;
using System;

namespace aspReact.Authors.DTO
{
    [AutoMapFrom(typeof(Author))]
    public class GetAuthorOutput
    {
        public int Id { get; set; }
        public string DispalyName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime? DeathDate { get; set; }
    }
}
