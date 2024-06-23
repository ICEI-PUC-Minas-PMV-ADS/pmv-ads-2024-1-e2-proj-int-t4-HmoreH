using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TESTEBACKEND.Models
{
    [Table("Medicos")]
    public class Medico
    {
        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage = "Campo Obrigatório. Por favor, preencha o nome do Médico")]
        [Display(Name = "Nome do Médico")]
        public string NomeMedico { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório. Por favor, preencha o CRM do Médico")]
        public string CRM { get; set; }


        [Required(ErrorMessage = "Campo Obrigatório. Por favor, preencha a especialidade do Médico")]
        public string Especialidade { get; set; }


        [Required(ErrorMessage = "Campo Obrigatório. Por favor, preencha o contato do Médico")]
        public string Contato { get; set; }
    }
}
