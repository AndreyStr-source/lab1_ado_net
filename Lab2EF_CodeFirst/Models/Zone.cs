using System.Collections.Generic;
using System.ComponentModel;

namespace Lab2EF_CodeFirst.Models
{
    public class Zone
    {
        public int Id { get; set; }//первичный ключ
        public string Name { get; set; }//название зоны
        public decimal Cost { get; set; }//стоимость за час
        public List<Visit> Visits { get; set; } = new List<Visit>();//список посещений (связь 1-*)
    }
}