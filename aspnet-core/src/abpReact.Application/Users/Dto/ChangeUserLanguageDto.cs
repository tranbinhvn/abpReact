using System.ComponentModel.DataAnnotations;

namespace abpReact.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}