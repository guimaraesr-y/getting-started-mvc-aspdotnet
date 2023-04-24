using System.ComponentModel.DataAnnotations;

namespace LearningWebDatabase.Models
{
    public class Pessoa
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public DateTime Nasc { get; set; }
        
        public ICollection<Carro>? Carros { get; set; }
        public int Idade => CalculaIdade();

        private int CalculaIdade()
        {
            int idade = DateTime.Now.Year - Nasc.Year;
            if (DateTime.Now.DayOfYear < Nasc.DayOfYear) idade--;
            return idade;
        }

    }
}
