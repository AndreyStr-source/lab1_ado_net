namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            Клиент = new TabPage();
            buttonSave = new Button();
            buttonDelete = new Button();
            buttonAdd = new Button();
            dataGridViewClient = new DataGridView();
            Зона_аквапарка = new TabPage();
            buttonSaveZone = new Button();
            buttonDeleteZone = new Button();
            buttonAddZone = new Button();
            dataGridViewZone = new DataGridView();
            RawSQL = new TabPage();
            dataGridViewSearch = new DataGridView();
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            Хранимая_процедура = new TabPage();
            dataGridViewProc = new DataGridView();
            buttonProc = new Button();
            numericUpDown1 = new NumericUpDown();
            tabControl1.SuspendLayout();
            Клиент.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClient).BeginInit();
            Зона_аквапарка.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewZone).BeginInit();
            RawSQL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSearch).BeginInit();
            Хранимая_процедура.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Клиент);
            tabControl1.Controls.Add(Зона_аквапарка);
            tabControl1.Controls.Add(RawSQL);
            tabControl1.Controls.Add(Хранимая_процедура);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 448);
            tabControl1.TabIndex = 0;
            // 
            // Клиент
            // 
            Клиент.Controls.Add(buttonSave);
            Клиент.Controls.Add(buttonDelete);
            Клиент.Controls.Add(buttonAdd);
            Клиент.Controls.Add(dataGridViewClient);
            Клиент.Location = new Point(4, 24);
            Клиент.Name = "Клиент";
            Клиент.Padding = new Padding(3);
            Клиент.Size = new Size(792, 420);
            Клиент.TabIndex = 0;
            Клиент.Text = "Клиент";
            Клиент.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.Dock = DockStyle.Bottom;
            buttonSave.Location = new Point(3, 348);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(786, 23);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Dock = DockStyle.Bottom;
            buttonDelete.Location = new Point(3, 371);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(786, 23);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Dock = DockStyle.Bottom;
            buttonAdd.Location = new Point(3, 394);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(786, 23);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // dataGridViewClient
            // 
            dataGridViewClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClient.Dock = DockStyle.Fill;
            dataGridViewClient.Location = new Point(3, 3);
            dataGridViewClient.Name = "dataGridViewClient";
            dataGridViewClient.Size = new Size(786, 414);
            dataGridViewClient.TabIndex = 0;
            // 
            // Зона_аквапарка
            // 
            Зона_аквапарка.Controls.Add(buttonSaveZone);
            Зона_аквапарка.Controls.Add(buttonDeleteZone);
            Зона_аквапарка.Controls.Add(buttonAddZone);
            Зона_аквапарка.Controls.Add(dataGridViewZone);
            Зона_аквапарка.Location = new Point(4, 24);
            Зона_аквапарка.Name = "Зона_аквапарка";
            Зона_аквапарка.Padding = new Padding(3);
            Зона_аквапарка.Size = new Size(792, 420);
            Зона_аквапарка.TabIndex = 1;
            Зона_аквапарка.Text = "Зона_аквапарка";
            Зона_аквапарка.UseVisualStyleBackColor = true;
            // 
            // buttonSaveZone
            // 
            buttonSaveZone.Dock = DockStyle.Bottom;
            buttonSaveZone.Location = new Point(3, 348);
            buttonSaveZone.Name = "buttonSaveZone";
            buttonSaveZone.Size = new Size(786, 23);
            buttonSaveZone.TabIndex = 7;
            buttonSaveZone.Text = "Сохранить";
            buttonSaveZone.UseVisualStyleBackColor = true;
            buttonSaveZone.Click += buttonSaveZone_Click;
            // 
            // buttonDeleteZone
            // 
            buttonDeleteZone.Dock = DockStyle.Bottom;
            buttonDeleteZone.Location = new Point(3, 371);
            buttonDeleteZone.Name = "buttonDeleteZone";
            buttonDeleteZone.Size = new Size(786, 23);
            buttonDeleteZone.TabIndex = 6;
            buttonDeleteZone.Text = "Удалить";
            buttonDeleteZone.UseVisualStyleBackColor = true;
            buttonDeleteZone.Click += buttonDeleteZone_Click;
            // 
            // buttonAddZone
            // 
            buttonAddZone.Dock = DockStyle.Bottom;
            buttonAddZone.Location = new Point(3, 394);
            buttonAddZone.Name = "buttonAddZone";
            buttonAddZone.Size = new Size(786, 23);
            buttonAddZone.TabIndex = 5;
            buttonAddZone.Text = "Добавить";
            buttonAddZone.UseVisualStyleBackColor = true;
            buttonAddZone.Click += buttonAddZone_Click;
            // 
            // dataGridViewZone
            // 
            dataGridViewZone.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewZone.Dock = DockStyle.Fill;
            dataGridViewZone.Location = new Point(3, 3);
            dataGridViewZone.Name = "dataGridViewZone";
            dataGridViewZone.Size = new Size(786, 414);
            dataGridViewZone.TabIndex = 4;
            // 
            // RawSQL
            // 
            RawSQL.Controls.Add(dataGridViewSearch);
            RawSQL.Controls.Add(buttonSearch);
            RawSQL.Controls.Add(textBoxSearch);
            RawSQL.Location = new Point(4, 24);
            RawSQL.Name = "RawSQL";
            RawSQL.Size = new Size(792, 420);
            RawSQL.TabIndex = 2;
            RawSQL.Text = "RawSQL";
            RawSQL.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSearch
            // 
            dataGridViewSearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSearch.Dock = DockStyle.Fill;
            dataGridViewSearch.Location = new Point(0, 46);
            dataGridViewSearch.Name = "dataGridViewSearch";
            dataGridViewSearch.Size = new Size(792, 374);
            dataGridViewSearch.TabIndex = 3;
            // 
            // buttonSearch
            // 
            buttonSearch.Dock = DockStyle.Top;
            buttonSearch.Location = new Point(0, 23);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(792, 23);
            buttonSearch.TabIndex = 2;
            buttonSearch.Text = "Найти";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Dock = DockStyle.Top;
            textBoxSearch.Location = new Point(0, 0);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(792, 23);
            textBoxSearch.TabIndex = 0;
            // 
            // Хранимая_процедура
            // 
            Хранимая_процедура.Controls.Add(dataGridViewProc);
            Хранимая_процедура.Controls.Add(buttonProc);
            Хранимая_процедура.Controls.Add(numericUpDown1);
            Хранимая_процедура.Location = new Point(4, 24);
            Хранимая_процедура.Name = "Хранимая_процедура";
            Хранимая_процедура.Size = new Size(792, 420);
            Хранимая_процедура.TabIndex = 3;
            Хранимая_процедура.Text = "Хранимая_процедура";
            Хранимая_процедура.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProc
            // 
            dataGridViewProc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProc.Dock = DockStyle.Fill;
            dataGridViewProc.Location = new Point(0, 46);
            dataGridViewProc.Name = "dataGridViewProc";
            dataGridViewProc.Size = new Size(792, 374);
            dataGridViewProc.TabIndex = 2;
            // 
            // buttonProc
            // 
            buttonProc.Dock = DockStyle.Top;
            buttonProc.Location = new Point(0, 23);
            buttonProc.Name = "buttonProc";
            buttonProc.Size = new Size(792, 23);
            buttonProc.TabIndex = 1;
            buttonProc.Text = "Выполнить";
            buttonProc.UseVisualStyleBackColor = true;
            buttonProc.Click += buttonProc_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Dock = DockStyle.Top;
            numericUpDown1.Location = new Point(0, 0);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(792, 23);
            numericUpDown1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 448);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            Клиент.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewClient).EndInit();
            Зона_аквапарка.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewZone).EndInit();
            RawSQL.ResumeLayout(false);
            RawSQL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSearch).EndInit();
            Хранимая_процедура.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProc).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabPage Клиент;
        private TabPage Зона_аквапарка;
        private TabControl tabControl1;
        private TabPage RawSQL;
        private TabPage Хранимая_процедура;
        private DataGridView dataGridViewClient;
        private Button buttonSave;
        private Button buttonDelete;
        private Button buttonAdd;
        private Button buttonSaveZone;
        private Button buttonDeleteZone;
        private Button buttonAddZone;
        private DataGridView dataGridViewZone;
        private TextBox textBoxSearch;
        private Button buttonSearch;
        private DataGridView dataGridViewSearch;
        private DataGridView dataGridViewProc;
        private Button buttonProc;
        private NumericUpDown numericUpDown1;
    }
}
