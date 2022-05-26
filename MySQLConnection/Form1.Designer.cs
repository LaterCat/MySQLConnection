
namespace MySQLConnection
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
            this.create = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.read = new System.Windows.Forms.Button();
            this.on_mysql = new System.Windows.Forms.Button();
            this.off_mysql = new System.Windows.Forms.Button();
            this.Sno_textbox = new System.Windows.Forms.TextBox();
            this.Sname_textbox = new System.Windows.Forms.TextBox();
            this.Ssex_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Sage_textbox = new System.Windows.Forms.TextBox();
            this.Sdept_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(493, 411);
            this.dataGridView1.TabIndex = 0;
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(687, 333);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(119, 60);
            this.create.TabIndex = 1;
            this.create.Text = "create";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(832, 333);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(119, 60);
            this.delete.TabIndex = 2;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(687, 417);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(119, 60);
            this.update.TabIndex = 3;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // read
            // 
            this.read.Location = new System.Drawing.Point(832, 417);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(119, 60);
            this.read.TabIndex = 4;
            this.read.Text = "read";
            this.read.UseVisualStyleBackColor = true;
            this.read.Click += new System.EventHandler(this.read_Click);
            // 
            // on_mysql
            // 
            this.on_mysql.Location = new System.Drawing.Point(57, 497);
            this.on_mysql.Name = "on_mysql";
            this.on_mysql.Size = new System.Drawing.Size(137, 65);
            this.on_mysql.TabIndex = 5;
            this.on_mysql.Text = "on_mysql";
            this.on_mysql.UseVisualStyleBackColor = true;
            this.on_mysql.Click += new System.EventHandler(this.on_mysql_Click);
            // 
            // off_mysql
            // 
            this.off_mysql.Location = new System.Drawing.Point(319, 497);
            this.off_mysql.Name = "off_mysql";
            this.off_mysql.Size = new System.Drawing.Size(137, 65);
            this.off_mysql.TabIndex = 6;
            this.off_mysql.Text = "off_mysql";
            this.off_mysql.UseVisualStyleBackColor = true;
            this.off_mysql.Click += new System.EventHandler(this.off_mysql_Click);
            // 
            // Sno_textbox
            // 
            this.Sno_textbox.Location = new System.Drawing.Point(687, 12);
            this.Sno_textbox.Multiline = true;
            this.Sno_textbox.Name = "Sno_textbox";
            this.Sno_textbox.Size = new System.Drawing.Size(264, 42);
            this.Sno_textbox.TabIndex = 7;
            // 
            // Sname_textbox
            // 
            this.Sname_textbox.Location = new System.Drawing.Point(687, 70);
            this.Sname_textbox.Multiline = true;
            this.Sname_textbox.Name = "Sname_textbox";
            this.Sname_textbox.Size = new System.Drawing.Size(264, 43);
            this.Sname_textbox.TabIndex = 8;
            // 
            // Ssex_textbox
            // 
            this.Ssex_textbox.Location = new System.Drawing.Point(687, 129);
            this.Ssex_textbox.Multiline = true;
            this.Ssex_textbox.Name = "Ssex_textbox";
            this.Ssex_textbox.Size = new System.Drawing.Size(264, 43);
            this.Ssex_textbox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(571, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "Sno";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(571, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 37);
            this.label2.TabIndex = 11;
            this.label2.Text = "Sname";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(571, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 37);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ssex";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sage_textbox
            // 
            this.Sage_textbox.Location = new System.Drawing.Point(687, 190);
            this.Sage_textbox.Multiline = true;
            this.Sage_textbox.Name = "Sage_textbox";
            this.Sage_textbox.Size = new System.Drawing.Size(264, 43);
            this.Sage_textbox.TabIndex = 13;
            // 
            // Sdept_textbox
            // 
            this.Sdept_textbox.Location = new System.Drawing.Point(687, 251);
            this.Sdept_textbox.Multiline = true;
            this.Sdept_textbox.Name = "Sdept_textbox";
            this.Sdept_textbox.Size = new System.Drawing.Size(264, 43);
            this.Sdept_textbox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(571, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 37);
            this.label4.TabIndex = 15;
            this.label4.Text = "Sage";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(571, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 37);
            this.label5.TabIndex = 16;
            this.label5.Text = "Sdept";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 587);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Sdept_textbox);
            this.Controls.Add(this.Sage_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ssex_textbox);
            this.Controls.Add(this.Sname_textbox);
            this.Controls.Add(this.Sno_textbox);
            this.Controls.Add(this.off_mysql);
            this.Controls.Add(this.on_mysql);
            this.Controls.Add(this.read);
            this.Controls.Add(this.update);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.create);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button read;
        private System.Windows.Forms.Button on_mysql;
        private System.Windows.Forms.Button off_mysql;
        private System.Windows.Forms.TextBox Sno_textbox;
        private System.Windows.Forms.TextBox Sname_textbox;
        private System.Windows.Forms.TextBox Ssex_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Sage_textbox;
        private System.Windows.Forms.TextBox Sdept_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

