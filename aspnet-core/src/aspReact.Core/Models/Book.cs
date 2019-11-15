using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace reactjs.Models
{
    public class Book: FullAuditedEntity
    {
        [Required]
        [Display(Name ="Display Name")]
        [StringLength(64, ErrorMessage ="Maximum Length is 64")]
        public string DispalyName { get; set; }
        public Nullable<int> TotalPageNumber { get; set; }
        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public virtual Author Author { get; set; }
        public virtual Category Category { get; set; }
    }
}
