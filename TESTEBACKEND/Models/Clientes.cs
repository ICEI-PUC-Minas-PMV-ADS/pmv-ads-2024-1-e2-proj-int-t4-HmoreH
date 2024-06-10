using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace TESTEBACKEND.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        [Required(ErrorMessage = "Por favor, informe seu número de CPF.")]
        public int CPF { get; set; }
        
        [Required(ErrorMessage = "Para melhores atendimentos, por gentileza, informe seu nome.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Para fins de contato, por favor informe o seu email.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe um número de telefone para contato com o DDD.")]
        public int Numero { get; set; }

        [Required(ErrorMessage = "Informe sua data de nascimento.")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Digite uma senha, para acesso posteriormente ao site.")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}
