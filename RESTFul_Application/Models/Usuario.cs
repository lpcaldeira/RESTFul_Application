using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RESTFul_Application.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Display(Name = "Sobrenome")]
        public string Sobrenome { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [StringLength(maximumLength: 80, MinimumLength = 5, ErrorMessage = "Precisa possuir entre 5 e 80 caracteres")]
        [RegularExpression("^[a-zA-Z0-9_.-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$", ErrorMessage = "Informe um e-mail válido!")]
        public string Email { get; set; }

        [Display(Name = "Senha")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Senha { get; set; }

        [NotMapped]
        [Display(Name = "Confirma Senha")]
        [DataType(DataType.Password)]
        [Compare("Senha")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [StringLength(80, ErrorMessage = "Precisa possuir entre 5 e 80 caracteres", MinimumLength = 5)]
        public string ConfirmaSenha { get; set; }

        [Display(Name = "Nível de Acesso")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public int NivelAcesso { get; set; }

        [Display(Name = "Data de Criação")]
        public DateTime DataCriacao { get; set; }
    }
}