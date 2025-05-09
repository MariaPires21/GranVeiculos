using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
{
    public class Modelo
    {
         [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Nome { get; set; }

        [Required]
        public int MarcaId { get; set; }
        public Marca Marca { get; set; }
    }
}