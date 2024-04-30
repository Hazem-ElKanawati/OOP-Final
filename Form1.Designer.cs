namespace OOP_Final
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phonenumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.editBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DisplayAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(300, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(210, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(307, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name1,
            this.Phonenumber,
            this.Emmail});
            this.dataGridView1.Location = new System.Drawing.Point(119, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1547, 334);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // name1
            // 
            this.name1.HeaderText = "Name";
            this.name1.MinimumWidth = 6;
            this.name1.Name = "name1";
            this.name1.Width = 400;
            // 
            // Phonenumber
            // 
            this.Phonenumber.HeaderText = "Phone Number";
            this.Phonenumber.MinimumWidth = 6;
            this.Phonenumber.Name = "Phonenumber";
            this.Phonenumber.Width = 500;
            // 
            // Emmail
            // 
            this.Emmail.HeaderText = "Email";
            this.Emmail.MinimumWidth = 6;
            this.Emmail.Name = "Emmail";
            this.Emmail.Width = 500;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Name",
            "Phone",
            "Email"});
            this.comboBox1.Location = new System.Drawing.Point(396, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(273, 603);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 22);
            this.textName.TabIndex = 6;
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(430, 604);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(100, 22);
            this.textPhone.TabIndex = 7;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(565, 603);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(123, 22);
            this.textEmail.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 582);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(454, 582);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(600, 585);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Email";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(736, 602);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 12;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Name",
            "Phone",
            "Email"});
            this.comboBox2.Location = new System.Drawing.Point(1477, 68);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 13;
            // 
            // editBox
            // 
            this.editBox.Location = new System.Drawing.Point(1238, 98);
            this.editBox.Name = "editBox";
            this.editBox.Size = new System.Drawing.Size(360, 22);
            this.editBox.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1348, 126);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Confirm";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1233, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Edit Contact :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // DisplayAll
            // 
            this.DisplayAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayAll.Location = new System.Drawing.Point(650, 62);
            this.DisplayAll.Name = "DisplayAll";
            this.DisplayAll.Size = new System.Drawing.Size(481, 58);
            this.DisplayAll.TabIndex = 17;
            this.DisplayAll.Text = "Display All";
            this.DisplayAll.UseVisualStyleBackColor = true;
            this.DisplayAll.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 691);
            this.Controls.Add(this.DisplayAll);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.editBox);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phonenumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emmail;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox editBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DisplayAll;
    }
}