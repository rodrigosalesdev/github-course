﻿using System.ComponentModel.DataAnnotations;

namespace WFConfi.Models
{
    public class Cidade
    {
        [Key]
        public Guid Id { get; set; }
        
        [Required(ErrorMessage = "O campo nome é obrigatório.")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "O nome deve ter entre 3 a 200 caracteres.") ]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Estado é obrigatório")]
        [StringLength(2, MinimumLength = 2, ErrorMessage = "O campo Estado deve ter 2 caracteres.")]
        public string EstadoSigla { get; set; }

        public Cidade()
        { 
            Id = Guid.NewGuid();
        }

        // Relacionamento Entity Framework
        public Estado Estado { get; set; }
    }
}
