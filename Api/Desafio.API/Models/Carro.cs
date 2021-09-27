using System.ComponentModel.DataAnnotations.Schema;

namespace DesafioTecnico.Models
{
    [Table("Carros")]
    public class Carro
    {
        public int ID { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public decimal Preco { get; set; }
    }
}
