using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TESTEBACKEND.Models
{

    [Table("Clinicas")]
    public class Clinica
    {
        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage = "Campo Obrigatório. Por favor, preencha o nome da Clinica.")]
        public string NomeClinica { get; set; }


        [Required(ErrorMessage = "Campo Obrigatório. Por favor, preencha a sua Especialidade.")]
        public string Especialidade { get; set; }


        [Required(ErrorMessage = "Campo Obrigatório. Por favor, preencha o seu endereço.")]
        public string Endereco { get; set; }


        [Required(ErrorMessage = "Campo Obrigatório. Por favor, informe o seu contato.")]
        public int Contato { get; set; }


        [Required(ErrorMessage = "Campo Obrigatório. Por favor, preencha os seus serviços.")]
        public string Servicos { get; set; }


        //[Required(ErrorMessage = "Campo Obrigatório. Por favor, preencha os seus exames.")]
        //public string Exames { get; set; }


    }
}
