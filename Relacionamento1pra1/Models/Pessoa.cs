using System.ComponentModel.DataAnnotations;

namespace Relacionamento1pra1.Models
{
    public class Pessoa
    {
        [Key]
        public int PessoaId { get; set; }
        [Required (ErrorMessage = "O nome do cliente é obrigatório")]
        [StringLength(100, ErrorMessage ="O nome do cliente deve ter no máximo 100 caracteres")]
        public string Nome { get; set; }
        //Fazendo relacionamento utilizando Data Annotatios
        public Endereco? Endereco { get; set; } //Adicionando o ? para informar que o endereço é opcional
    }
}
