namespace TestUygulama
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ListeleButton = new System.Windows.Forms.Button();
            this.MalKoduAdıTxtBx = new System.Windows.Forms.TextBox();
            this.BaslangicTarihi = new System.Windows.Forms.DateTimePicker();
            this.BitisTarihi = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(299, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(489, 195);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Başlangıc Tarihi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bitiş Tarihi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mal Kodu veya Mal Adı :";
            // 
            // ListeleButton
            // 
            this.ListeleButton.Location = new System.Drawing.Point(174, 257);
            this.ListeleButton.Name = "ListeleButton";
            this.ListeleButton.Size = new System.Drawing.Size(75, 23);
            this.ListeleButton.TabIndex = 9;
            this.ListeleButton.Text = "Listele";
            this.ListeleButton.UseVisualStyleBackColor = true;
            this.ListeleButton.Click += new System.EventHandler(this.ListeleButton_Click);
            // 
            // MalKoduAdıTxtBx
            // 
            this.MalKoduAdıTxtBx.Location = new System.Drawing.Point(149, 205);
            this.MalKoduAdıTxtBx.Name = "MalKoduAdıTxtBx";
            this.MalKoduAdıTxtBx.Size = new System.Drawing.Size(100, 23);
            this.MalKoduAdıTxtBx.TabIndex = 11;
            this.MalKoduAdıTxtBx.Text = "10083 SİEMENS";
            // 
            // BaslangicTarihi
            // 
            this.BaslangicTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BaslangicTarihi.Location = new System.Drawing.Point(149, 110);
            this.BaslangicTarihi.Name = "BaslangicTarihi";
            this.BaslangicTarihi.Size = new System.Drawing.Size(100, 23);
            this.BaslangicTarihi.TabIndex = 12;
            this.BaslangicTarihi.Value = new System.DateTime(2016, 1, 7, 14, 31, 0, 0);
            // 
            // BitisTarihi
            // 
            this.BitisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BitisTarihi.Location = new System.Drawing.Point(149, 155);
            this.BitisTarihi.Name = "BitisTarihi";
            this.BitisTarihi.Size = new System.Drawing.Size(100, 23);
            this.BitisTarihi.TabIndex = 13;
            this.BitisTarihi.Value = new System.DateTime(2017, 4, 18, 14, 31, 0, 0);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BitisTarihi);
            this.Controls.Add(this.BaslangicTarihi);
            this.Controls.Add(this.MalKoduAdıTxtBx);
            this.Controls.Add(this.ListeleButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button ListeleButton;
        private TextBox MalKoduAdıTxtBx;
        private DateTimePicker BaslangicTarihi;
        private DateTimePicker BitisTarihi;
    }
}