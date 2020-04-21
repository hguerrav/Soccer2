using System.ComponentModel.DataAnnotations;

namespace Soccer.Web.Data.Enteties
{
    public class TeamEntity
    {
        public int Id { get; set; }
        [MaxLength(50, ErrorMessage = "The  field {0} can not have more that {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Name { get; set; }

        public string LogoPath { get; set; }
    }
}
