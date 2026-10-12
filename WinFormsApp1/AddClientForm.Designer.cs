namespace WinFormsApp1
{
    partial class AddClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBoxContact = new TextBox();
            label2 = new Label();
            numericUpDownDiscount = new NumericUpDown();
            buttonOK = new Button();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDiscount).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(15, 15);
            label1.Name = "label1";
            label1.Size = new Size(144, 15);
            label1.TabIndex = 0;
            label1.Text = "Контактная информация";
            label1.Click += label1_Click;
            // 
            // textBoxContact
            // 
            textBoxContact.Anchor = AnchorStyles.Left;
            textBoxContact.Location = new Point(15, 40);
            textBoxContact.Name = "textBoxContact";
            textBoxContact.Size = new Size(307, 23);
            textBoxContact.TabIndex = 1;
            textBoxContact.Text = "textBoxContact";
            textBoxContact.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(15, 75);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 2;
            label2.Text = "Размер скидки:";
            // 
            // numericUpDownDiscount
            // 
            numericUpDownDiscount.Anchor = AnchorStyles.Left;
            numericUpDownDiscount.DecimalPlaces = 2;
            numericUpDownDiscount.Location = new Point(15, 100);
            numericUpDownDiscount.Name = "numericUpDownDiscount";
            numericUpDownDiscount.Size = new Size(120, 23);
            numericUpDownDiscount.TabIndex = 3;
            // 
            // buttonOK
            // 
            buttonOK.Anchor = AnchorStyles.Bottom;
            buttonOK.DialogResult = DialogResult.OK;
            buttonOK.Location = new Point(166, 150);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(75, 23);
            buttonOK.TabIndex = 4;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Bottom;
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(247, 150);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // AddClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 181);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOK);
            Controls.Add(numericUpDownDiscount);
            Controls.Add(label2);
            Controls.Add(textBoxContact);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddClientForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Добавить клиента";
            Load += AddClientForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownDiscount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxContact;
        private Label label2;
        private NumericUpDown numericUpDownDiscount;
        private Button buttonOK;
        private Button buttonCancel;
    }
}