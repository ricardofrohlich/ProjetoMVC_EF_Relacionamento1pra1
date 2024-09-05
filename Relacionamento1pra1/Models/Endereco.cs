using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Relacionamento1pra1.Models
{
    public class Endereco
    {
        [Key]
        [ForeignKey("Pessoa")]
        public int EnderecoId {  get; set; }
        [Required(ErrorMessage = "O nome do cliente é obrigatório")]
        [StringLength(100, ErrorMessage = "O nome do cliente deve ter no máximo 100 caracteres")]
        public string Rua {  get; set; }
        public int Nro { get; set; }
        public string Complemento { get; set; }
        [Required(ErrorMessage = "O nome da cidade é obrigatório")]
        [StringLength(100, ErrorMessage = "O nome da cidade deve ter no máximo 100 caracteres")]
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }

        public int PessoaId { get; set; }
        public Pessoa? Pessoa { get; set; } // Definindo a outra parte do relacionamento
    }
}
