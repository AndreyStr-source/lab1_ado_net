using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AddClientForm : Form
    {
        //свойства для передачи данных
        public string ContactInfo => textBoxContact.Text;
        public decimal Discount => numericUpDownDiscount.Value;

        public AddClientForm()
        {
            InitializeComponent();
        }

        //пустые загл
        private void label1_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void buttonOK_Click(object sender, EventArgs e) { }
        private void buttonCancel_Click(object sender, EventArgs e) { }
        private void AddClientForm_Load(object sender, EventArgs e) { }
    }
}