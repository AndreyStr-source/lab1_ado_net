using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using Npgsql; 

namespace WinFormsApp1 
{
    public partial class Form1 : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["TestConnection"].ConnectionString;

        DataSet dataSet;
        NpgsqlDataAdapter adapterClient;
        NpgsqlDataAdapter adapterZone;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                dataSet = new DataSet();

                adapterClient = new NpgsqlDataAdapter("SELECT * FROM \"Клиент\"", connectionString);
                NpgsqlCommandBuilder builderClient = new NpgsqlCommandBuilder(adapterClient);
                adapterClient.Fill(dataSet, "Клиент");

                BindingSource bsClient = new BindingSource();
                bsClient.DataSource = dataSet.Tables["Клиент"];
                dataGridViewClient.DataSource = bsClient;


                adapterZone = new NpgsqlDataAdapter("SELECT * FROM \"Зона аквапарка\"", connectionString);
                NpgsqlCommandBuilder builderZone = new NpgsqlCommandBuilder(adapterZone);
                adapterZone.Fill(dataSet, "Зона аквапарка");

                BindingSource bsZone = new BindingSource();
                bsZone.DataSource = dataSet.Tables["Зона аквапарка"];
                dataGridViewZone.DataSource = bsZone;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка" + ex.Message);
            }
        }

        //КЛИЕНТ
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            
            dataSet.Tables["Клиент"].Rows.Add(dataSet.Tables["Клиент"].NewRow());//добавление пустой строки в датасет
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewClient.CurrentRow != null)
            {
                dataGridViewClient.Rows.RemoveAt(dataGridViewClient.CurrentRow.Index);//удаление
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow row in dataSet.Tables["Клиент"].Rows)//проверка обязательных полей
                {
                    if (row.RowState != DataRowState.Deleted)
                    {
                        if (row["Контактная информация"] == DBNull.Value || string.IsNullOrWhiteSpace(row["Контактная информация"].ToString()))
                        {
                            MessageBox.Show("Контактная информация не может быть пустой!");
                            return;
                        }
                    }
                }

                adapterClient.Update(dataSet, "Клиент");
                MessageBox.Show("Данные клиентов сохранены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения: " + ex.Message);
            }
        }

        //зона
        private void buttonAddZone_Click(object sender, EventArgs e)
        {
            dataSet.Tables["Зона аквапарка"].Rows.Add(dataSet.Tables["Зона аквапарка"].NewRow());
        }

        private void buttonDeleteZone_Click(object sender, EventArgs e)
        {
            if (dataGridViewZone.CurrentRow != null)
            {
                dataGridViewZone.Rows.RemoveAt(dataGridViewZone.CurrentRow.Index);
            }
        }

        private void buttonSaveZone_Click(object sender, EventArgs e)
        {
            try
            {
                adapterZone.Update(dataSet, "Зона аквапарка");
                MessageBox.Show("Данные зон сохранены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения: " + ex.Message);
            }
        }

        //RAW SQL
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    //поиск клиента по контактной информации
                    string sql = "SELECT * FROM \"Клиент\" WHERE \"Контактная информация\" LIKE @name";

                    NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@name", "%" + textBoxSearch.Text + "%");

                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dataGridViewSearch.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка поиска: " + ex.Message);
                }
            }
        }

        //ХРАНИМАЯ ПРОЦЕДУРА
        private void buttonProc_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet dsProc = new DataSet();

                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT * FROM get_clients_by_discount(@min_discount)", connectionString);

                da.SelectCommand.CommandType = CommandType.Text;//указываем тип как текст а не StoredProcedure

                da.SelectCommand.Parameters.AddWithValue("@min_discount", numericUpDown1.Value);//добавление параметра
                da.Fill(dsProc, "Result");
                dataGridViewProc.DataSource = dsProc.Tables["Result"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка" + ex.Message);
            }
        }
    }
}