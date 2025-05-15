using System.ComponentModel.DataAnnotations;

namespace WFConfi.Models
{
    public class Estado
    {
        [Key]
        [StringLength(2,MinimumLength = 2, ErrorMessage = "O campo Sigla deve ter 2 caracteres")]
        public string Sigla { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "O campo nome deve ter entre 3 a 200 caracteres")]
        public string Nome { get; set;}

    }
}
