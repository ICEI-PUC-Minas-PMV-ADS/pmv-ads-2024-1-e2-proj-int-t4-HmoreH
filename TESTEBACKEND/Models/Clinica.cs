using System.ComponentModel;
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
        [DisplayName("Razão Social")]
        public string NomeClinica { get; set; }


        [Required(ErrorMessage = "Campo Obrigatório. Por favor, preencha a sua Especialidade.")]
        public string Especialidade { get; set; }


        [Required(ErrorMessage = "Campo Obrigatório. Por favor, preencha o seu endereço.")]
        [DisplayName("Endereço da Unidade")]
        public string Endereco { get; set; }


        [Required(ErrorMessage = "Campo Obrigatório. Por favor, informe o seu contato.")]
        [DisplayName("Telefone para Contato")]
        public int Contato { get; set; }


        [Required(ErrorMessage = "Campo Obrigatório. Por favor, preencha os seus serviços.")]
        [DisplayName("Serviços")]
        public string Servicos { get; set; }


        //[Required(ErrorMessage = "Campo Obrigatório. Por favor, preencha os seus exames.")]
        //public string Exames { get; set; }


    }
}
