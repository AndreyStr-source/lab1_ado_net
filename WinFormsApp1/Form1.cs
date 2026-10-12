using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        //контекст для работы с бд
        private ApplicationContext _context = new ApplicationContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //загружаем клиентов
                _context.Clients.Load();
                dataGridViewClient.DataSource = _context.Clients.Local.ToBindingList();

                //загружаем зоны
                _context.Zones.Load();
                dataGridViewZone.DataSource = _context.Zones.Local.ToBindingList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки: " + ex.Message);
            }
        }

        // ==== вкладка клиент ====

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (var addForm = new AddClientForm())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    var newClient = new Client
                    {
                        ContactInfo = addForm.ContactInfo,
                        Discount = addForm.Discount
                    };
                    _context.Clients.Add(newClient);
                    _context.SaveChanges();//сохраняем в бд
                    dataGridViewClient.Refresh();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewClient.CurrentRow != null)
            {
                var client = (Client)dataGridViewClient.CurrentRow.DataBoundItem;
                _context.Clients.Remove(client);
                _context.SaveChanges();
                dataGridViewClient.Refresh();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                _context.SaveChanges();
                MessageBox.Show("Данные сохранены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения: " + ex.Message);
            }
        }

        // ==== вкладка зона аквапарка ====

        private void buttonAddZone_Click(object sender, EventArgs e)
        {
            //просто добавляем пустую зону, потом можно отредактировать в таблице
            var newZone = new Zone { Name = "Новая зона", Cost = 0 };
            _context.Zones.Add(newZone);
            _context.SaveChanges();
            dataGridViewZone.Refresh();
        }

        private void buttonDeleteZone_Click(object sender, EventArgs e)
        {
            if (dataGridViewZone.CurrentRow != null)
            {
                var zone = (Zone)dataGridViewZone.CurrentRow.DataBoundItem;
                _context.Zones.Remove(zone);
                _context.SaveChanges();
                dataGridViewZone.Refresh();
            }
        }

        private void buttonSaveZone_Click(object sender, EventArgs e)
        {
            try
            {
                _context.SaveChanges();
                MessageBox.Show("Зоны сохранены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        // ==== вкладка raw sql (теперь linq) ====

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText = textBoxSearch.Text;

                //linq: фильтрация, группировка, проекция
                var query = _context.Clients
                    .Where(c => c.ContactInfo.Contains(searchText))
                    .GroupBy(c => c.Discount)
                    .Select(g => new
                    {
                        Размер_скидки = g.Key,
                        Количество_клиентов = g.Count()
                    })
                    .ToList();

                dataGridViewSearch.DataSource = query;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка поиска: " + ex.Message);
            }
        }

        // ==== вкладка хранимая процедура ====

        private void buttonProc_Click(object sender, EventArgs e)
        {
            try
            {
                decimal minDiscount = numericUpDown1.Value;

                //вызов функции postgresql через ef
                var result = _context.Database
                    .SqlQueryRaw<ClientDto>(
                        "SELECT client_id AS \"ClientId\", contact_info AS \"ContactInfo\", discount AS \"Discount\" FROM get_clients_by_discount({0})",
                        minDiscount)
                    .ToList();

                dataGridViewProc.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка вызова процедуры: " + ex.Message);
            }
        }
    }

    //dto для результата хранимой функции
    public class ClientDto
    {
        public int ClientId { get; set; }
        public string ContactInfo { get; set; }
        public decimal Discount { get; set; }
    }
}