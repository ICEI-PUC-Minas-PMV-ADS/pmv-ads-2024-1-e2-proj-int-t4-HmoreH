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

        [Required(ErrorMessage = "Campo Obrigatório. Por favor, informe o CNPJ da Clinica.")]
        [DisplayName("CNPJ")]
        public string CNPJ { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório. Por favor, informe a razão social.")]
        [DisplayName("Razão Social")]
        public string NomeClinica { get; set; }


        [Required(ErrorMessage = "Campo Obrigatório. Por favor, preencha o seu endereço.")]
        [DisplayName("Endereço da Unidade")]
        public string Endereco { get; set; }


        [Required(ErrorMessage = "Campo Obrigatório. Por favor, informe o seu contato.")]
        [DisplayName("Telefone para Contato")]
        public int Contato { get; set; }

        public string Descricao { get; set; }

    }
}
