using System;
using System.ComponentModel.DataAnnotations;

namespace User
{
    public class UserClient
    {
        [Required(ErrorMessage = "A matrícula é obrigatória!")]
        public int Matricula { get; set; }

        [Required(ErrorMessage = "O login é obrigatório!")]
        [MaxLength(40, ErrorMessage = "O número máximo de caractéres para o login é {1}")]
        public string Login { get; set; }

        [Required(ErrorMessage = "A senha é obrigatório!")]
        public int Senha { get; set; }
    }
}