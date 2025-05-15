using System.ComponentModel.DataAnnotations;

namespace WFConfi.Models
{
    public class Usuario
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório")]
        [StringLength(200, ErrorMessage = "O nome deve conter até 200 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo login é obrigatório")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "O campo login deve ter entre 3 a 20 caracteres.")]
        public string Login { get; set; }

        [Required(ErrorMessage = "O campo senha é obrigatório")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "O campo senha deve ter entre 3 a 20 caracteres.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "O campo função é obrigatório")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "O campo função deve ter entre 3 a 20 caracteres.")]
        public string Funcao { get; set; }


    }
}
