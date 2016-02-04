using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ExemploValidacao.Models
{
    public class Pessoa
    {
        [Required(ErrorMessage = "Nome deve ser preenchido")]
        public string Nome { get; set; }

        [StringLength(50,MinimumLength = 5, ErrorMessage = "A observação deve ter entre 5 e 50 caracteres")]
        public string Observacao { get; set; }

        [Range(18,50,ErrorMessage = "A idade da pessoa deve ser entre 18 e 50 anos")]
        public int Idade { get; set; }

        [RegularExpression(@"/^[a-zA-Z0-9][a-zA-Z0-9\._-]+@([a-zA-Z0-9\._-]+\.)[a-zA-Z-0-9]{2}/", ErrorMessage = "o Emal não é válido")]
        public string Email { get; set; }

        [RegularExpression(@"[a-zA-Z]{5,15}",ErrorMessage = "Login deve possuir somente letras e deve ter de 5 a 15 caracteres")]
        [Required(ErrorMessage ="O login deve ser preenchido")]
        public string Login { get; set; }

        [Required(ErrorMessage ="A senha deve ser informada")]
        public string Senha { get; set; }

        [Compare("Senha",ErrorMessage ="As senhas não conferem")]
        public string ConfirmaSenha { get; set; }
    }
}