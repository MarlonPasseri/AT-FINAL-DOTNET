using System.ComponentModel.DataAnnotations;

namespace AT_DE_JAVA.Models
{
    public class Restaurante
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Comida { get; set;}

        public string Garçon { get; set;}
       
        public string Ingrediente { get; set;}
       

        public DateTime? Date { get; set; }
    }
}
