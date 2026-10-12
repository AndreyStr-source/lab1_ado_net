using System;

namespace Lab2EF_CodeFirst.Models
{
    public class Visit
    {
        public int Id { get; set; }//первичный ключ
        public DateTime VisitDate { get; set; }//дата посещения
        public int Hours { get; set; }//сколько часов провёл
        public int Rating { get; set; }//оценка посещения (1-5)
        public int ZoneId { get; set; }//внешний ключ на зону
        public Zone Zone { get; set; }//навигационное свойство
    }
}