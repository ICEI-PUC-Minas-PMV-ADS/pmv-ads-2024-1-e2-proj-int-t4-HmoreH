using System.Collections.ObjectModel;
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
        [Required(ErrorMessage = "Campo obrigatório. Por favor, informe a especialidade")]
        public string Especialidade { get; set; }

        public IEnumerable<Clinica> TodasAsClinicas()
        {
            var retorno = new Collection<Clinica>
                {
                    new Clinica
                        {
                            Id = 1,
                            CNPJ = "12.345.678/0001-90\r\n",
                            NomeClinica = "ClinicaA",
                            Endereco = "Rua 1000",
                            Contato = 999883945,
                            Descricao = "Aqui seu coração fica quentinho",
                            Especialidade = "Cardiologia"
                        },
                    new Clinica
                        {
                            Id = 2,
                            CNPJ = "98.765.432/0001-21\r\n",
                            NomeClinica = "ClinicaB",
                            Endereco = "Rua 2000",
                            Contato = 999883946,
                            Descricao = "Aqui você vira um nerd",
                            Especialidade = "Neurologia"
                        },
                    new Clinica
                        {
                            Id = 3,
                            CNPJ = "23.456.789/0001-54\r\n",
                            NomeClinica = "ClinicaC",
                            Endereco = "Rua 3000",
                            Contato = 999883947,
                            Descricao = "Aqui seus órgãos não são comercializados",
                            Especialidade = "Radiografias"
                        },
                    new Clinica
                        {
                            Id = 4,
                            CNPJ = "87.654.321/0001-43\r\n",
                            NomeClinica = "ClinicaD",
                            Endereco = "Rua 4000",
                            Contato = 999883948,
                            Descricao = "Aqui a digestão funciona",
                            Especialidade = "Gastroentorologia"
                        },
                    new Clinica
                        {
                            Id = 5,
                            CNPJ = "34.567.890/0001-76\r\n",
                            NomeClinica = "ClinicaE",
                            Endereco = "Rua 5000",
                            Contato = 999883949,
                            Descricao = "Seu coração saudável",
                            Especialidade = "Cardiologia"
                        },
                    new Clinica
                        {
                            Id = 6,
                            CNPJ = "76.543.210/0001-32\r\n",
                            NomeClinica = "ClinicaF",
                            Endereco = "Rua 6000",
                            Contato = 999881942,
                            Descricao = "Aqui você pensa",
                            Especialidade = "Neurologia"
                        },
                    new Clinica
                        {
                            Id = 7,
                            CNPJ = "45.678.901/0001-65\r\n",
                            NomeClinica = "ClinicaG",
                            Endereco = "Rua 7000",
                            Contato = 999883943,
                            Descricao = "Tire 10 em tudo",
                            Especialidade = "Neurologia"
                        }
                };
            return retorno;
        }
    }
}