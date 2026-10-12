using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Lab2EF_CodeFirst.Models;

namespace Lab2EF_CodeFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //пустой обработчик для дизайнера
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        //загрузка данных по кнопке
        private void buttonLoad_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (var context = new AquaParkContext())
                {
                    var zones = context.Zones.Include(z => z.Visits).ToList();
                    var result = zones.Select(z => new
                    {
                        Id = z.Id,
                        Название = z.Name,
                        Стоимость = z.Cost,
                        Посещений = z.Visits.Count
                    }).ToList();
                    dataGridView1.DataSource = result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки: " + ex.Message);
            }
        }
    }
}