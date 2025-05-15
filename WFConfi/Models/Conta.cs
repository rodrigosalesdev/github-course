﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WFConfi.Models
{
    public class Conta
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo descrição é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo descrição tem que ter até 200 caracteres.")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo valor é obrigatório.")]
        [Column(TypeName = "decimal(18,2")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "O campo data de vencimento é obrigatório.")]
        [DataType(DataType.Date)]
        public DateTime DataVencimento { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DataPagamento { get; set; }


        [Required(ErrorMessage = "O campo situação é obrigatório")]
        public Situacao Situacao { get; set; }

        [Required(ErrorMessage = "O campo pessoa é obrigatório")]
        public Guid PessoaId { get; set; }

        public Conta()
        {
            Id = Guid.NewGuid();
        }

        // Relacionamento Entity Framework
        public Pessoa Pessoa { get; set; }
    }
}
