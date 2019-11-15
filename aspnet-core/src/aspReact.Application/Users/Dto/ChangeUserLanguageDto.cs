using System.ComponentModel.DataAnnotations;

namespace aspReact.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}