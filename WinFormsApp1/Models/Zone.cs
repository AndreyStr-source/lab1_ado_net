using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsApp1.Models
{
    [Table("Зона аквапарка")]
    public class Zone
    {
        [Key]
        [Column("Идентификатор зоны аквапарка")]
        public int Id { get; set; }

        [Column("Название зоны")]
        public string Name { get; set; }

        [Column("Стоимость за час")]
        public decimal Cost { get; set; }
    }
}