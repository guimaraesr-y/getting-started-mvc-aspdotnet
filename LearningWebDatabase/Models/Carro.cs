using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearningWebDatabase.Models
{
    [Table("Carros")]
    public class Carro
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public int Ano { get; set; }
        [Required]
        public string? placa { get; set; }
        [Required]
        
        public int DonoId { get; set; }
        public Pessoa? Dono { get; set; }

    }
}
