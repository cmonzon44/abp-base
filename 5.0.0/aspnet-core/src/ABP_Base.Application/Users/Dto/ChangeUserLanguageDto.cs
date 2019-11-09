using System.ComponentModel.DataAnnotations;

namespace ABP_Base.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}