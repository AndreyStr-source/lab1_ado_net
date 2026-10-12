using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsApp1.Models
{
    [Table("Клиент")]//имя таблицы в бд
    public class Client
    {
        [Key]//первичный ключ
        [Column("Текущий идентификатор клиента")]
        public int Id { get; set; }

        [Column("Контактная информация")]
        public string ContactInfo { get; set; }

        [Column("Размер скидки")]
        public decimal Discount { get; set; }

        [Column("Идентификатор скидки")]
        public int? DiscountId { get; set; }//может быть null
    }
}