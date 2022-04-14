using System.ComponentModel.DataAnnotations;
using System;

namespace ApiRest.Models
{

    public class UserModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "A matrícula é obrigatória!")]
        public int Matricula { get; set; }

        [Required(ErrorMessage = "O login é obrigatório!")]
        [MaxLength(40, ErrorMessage = "O número máximo de caractéres para o login é {1}")]
        public string? Login { get; set; }

        [Required(ErrorMessage = "A senha é obrigatório!")]
        public int Senha { get; set; }

        [Required(ErrorMessage = "A data de nascimento é obrigatória")]
        public DateTime DataDeNasimento { get; set; }
    }

}
