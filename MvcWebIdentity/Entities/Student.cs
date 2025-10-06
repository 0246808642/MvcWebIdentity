using System.ComponentModel.DataAnnotations;

namespace MvcWebIdentity.Entities
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome é requerido")]
        [MaxLength(80, ErrorMessage = "Nome deve ter no máximo 80 caracteres")]
        [MinLength(3, ErrorMessage = "Nome deve ter no mínimo 3 caracteres")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Email é requerido")]
        [EmailAddress(ErrorMessage = "Email em formato inválido")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Idade é requerida")]
        [MinLength(5, ErrorMessage = "Idade deve ter no mínimo 5 anos")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "Curso é requerido")]
        [MaxLength(80, ErrorMessage = "Curso deve ter no máximo 80 caracteres")]
        public string? Course { get; set; }
    }
}
