using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Treina01.Models
{
    public class CadastroModel
    {
        [DisplayName("Nome")]
        [Required(ErrorMessage = "Campo {0} obrigatório")]
        [StringLength(50,ErrorMessage = "{0} deve conter no máximo {1} caracteres")]
        public string Nome { get; set; }

        [DisplayName("Cidade")]
        [Required(ErrorMessage = "Campo {0} obrigatório")]
        [StringLength(50, ErrorMessage = "{0} deve conter no máximo {1} caracteres")]
        public string Cidade { get; set; }

        [DisplayName("Estado")]
        [Required(ErrorMessage = "Campo {0} obrigatório")]
        [StringLength(2,MinimumLength=2, ErrorMessage = "{0} deve conter {1} caracteres")]
        public string Estado { get; set; }

        [DisplayName("Email")]
        [DataType(DataType.EmailAddress,ErrorMessage="{0} inválido")]
        [StringLength(100, ErrorMessage = "{0} deve conter no máximo {1} caracteres")]
        public string Email { get; set; }

        [DisplayName("Telefone")]
        [Required(ErrorMessage = "Campo {0} obrigatório")]
        [StringLength(10, ErrorMessage = "{0} deve conter no máximo {1} caracteres")]
        public string Fone { get; set; }

        [DisplayName("Celular")]
        [StringLength(10, ErrorMessage = "{0} deve conter no máximo {1} caracteres")]
        public string Celular { get; set; }

        [DisplayName("Observacao")]
        [StringLength(255, ErrorMessage = "{0} deve conter no máximo {1} caracteres")]
        public string Observacao { get; set; }
    }
}