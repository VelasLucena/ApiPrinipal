using System;
using System.ComponentModel.DataAnnotations;

namespace User
{
    public class UserClient
    {
        public int UserID { get; set; }

        [Required(ErrorMessage = "O nome {0} é obrigatório!")]
        [MaxLength(50, ErrorMessage = "O nome {0} pode ter no máximo {1} caractéres!")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "A Idade {0} é obrigatório!")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "A data de nascimento {0} é obrigatório!")]
        public DateOnly DataDeNascimento { get; set; }
    }
}