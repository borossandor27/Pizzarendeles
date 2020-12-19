
namespace WindowsFormsApp16
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox_vevok = new System.Windows.Forms.ListBox();
            this.textBox_Vevonev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_Pizzak = new System.Windows.Forms.ListBox();
            this.textBox_Pizza_neve = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_Db = new System.Windows.Forms.NumericUpDown();
            this.textBox_Pizzak_ara = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox_REndelt_pizzak = new System.Windows.Forms.ListBox();
            this.button_Rendeles = new System.Windows.Forms.Button();
            this.button_Insert = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Db)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_vevok
            // 
            this.listBox_vevok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_vevok.FormattingEnabled = true;
            this.listBox_vevok.Location = new System.Drawing.Point(3, 16);
            this.listBox_vevok.Name = "listBox_vevok";
            this.listBox_vevok.Size = new System.Drawing.Size(143, 411);
            this.listBox_vevok.TabIndex = 0;
            this.listBox_vevok.SelectedIndexChanged += new System.EventHandler(this.listBox_vevok_SelectedIndexChanged);
            // 
            // textBox_Vevonev
            // 
            this.textBox_Vevonev.Location = new System.Drawing.Point(253, 16);
            this.textBox_Vevonev.Name = "textBox_Vevonev";
            this.textBox_Vevonev.ReadOnly = true;
            this.textBox_Vevonev.Size = new System.Drawing.Size(100, 20);
            this.textBox_Vevonev.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vevő neve:";
            // 
            // listBox_Pizzak
            // 
            this.listBox_Pizzak.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_Pizzak.FormattingEnabled = true;
            this.listBox_Pizzak.Location = new System.Drawing.Point(3, 16);
            this.listBox_Pizzak.Name = "listBox_Pizzak";
            this.listBox_Pizzak.Size = new System.Drawing.Size(153, 261);
            this.listBox_Pizzak.TabIndex = 3;
            this.listBox_Pizzak.SelectedIndexChanged += new System.EventHandler(this.listBox_Pizzak_SelectedIndexChanged);
            // 
            // textBox_Pizza_neve
            // 
            this.textBox_Pizza_neve.Location = new System.Drawing.Point(219, 42);
            this.textBox_Pizza_neve.Name = "textBox_Pizza_neve";
            this.textBox_Pizza_neve.ReadOnly = true;
            this.textBox_Pizza_neve.Size = new System.Drawing.Size(123, 20);
            this.textBox_Pizza_neve.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kiválasztott pizza mennyisége";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kiválasztott pizza neve";
            // 
            // numericUpDown_Db
            // 
            this.numericUpDown_Db.Location = new System.Drawing.Point(219, 103);
            this.numericUpDown_Db.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Db.Name = "numericUpDown_Db";
            this.numericUpDown_Db.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_Db.TabIndex = 7;
            this.numericUpDown_Db.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_Db.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Db.ValueChanged += new System.EventHandler(this.numericUpDown_Db_ValueChanged);
            // 
            // textBox_Pizzak_ara
            // 
            this.textBox_Pizzak_ara.Location = new System.Drawing.Point(219, 164);
            this.textBox_Pizzak_ara.Name = "textBox_Pizzak_ara";
            this.textBox_Pizzak_ara.Size = new System.Drawing.Size(120, 20);
            this.textBox_Pizzak_ara.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Pizzaért fizetendő";
            // 
            // listBox_REndelt_pizzak
            // 
            this.listBox_REndelt_pizzak.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_REndelt_pizzak.FormattingEnabled = true;
            this.listBox_REndelt_pizzak.Location = new System.Drawing.Point(3, 16);
            this.listBox_REndelt_pizzak.Name = "listBox_REndelt_pizzak";
            this.listBox_REndelt_pizzak.Size = new System.Drawing.Size(194, 411);
            this.listBox_REndelt_pizzak.TabIndex = 10;
            // 
            // button_Rendeles
            // 
            this.button_Rendeles.Location = new System.Drawing.Point(180, 213);
            this.button_Rendeles.Name = "button_Rendeles";
            this.button_Rendeles.Size = new System.Drawing.Size(176, 37);
            this.button_Rendeles.TabIndex = 11;
            this.button_Rendeles.Text = "Megrendelem";
            this.button_Rendeles.UseVisualStyleBackColor = true;
            this.button_Rendeles.Click += new System.EventHandler(this.button_Rendeles_Click);
            // 
            // button_Insert
            // 
            this.button_Insert.Location = new System.Drawing.Point(188, 363);
            this.button_Insert.Name = "button_Insert";
            this.button_Insert.Size = new System.Drawing.Size(378, 40);
            this.button_Insert.TabIndex = 12;
            this.button_Insert.Text = "Rendelés rögzítése az adatbázisba";
            this.button_Insert.UseVisualStyleBackColor = true;
            this.button_Insert.Click += new System.EventHandler(this.button_Insert_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_Pizza_neve);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button_Rendeles);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDown_Db);
            this.groupBox1.Controls.Add(this.listBox_Pizzak);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_Pizzak_ara);
            this.groupBox1.Location = new System.Drawing.Point(188, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 280);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pizza választás";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox_vevok);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(149, 430);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vevők listája";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox_REndelt_pizzak);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(600, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 430);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Megrendelt pizzák";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 430);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Insert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Vevonev);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Pizza rendelés";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Db)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_vevok;
        private System.Windows.Forms.TextBox textBox_Vevonev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_Pizzak;
        private System.Windows.Forms.TextBox textBox_Pizza_neve;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_Db;
        private System.Windows.Forms.TextBox textBox_Pizzak_ara;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox_REndelt_pizzak;
        private System.Windows.Forms.Button button_Rendeles;
        private System.Windows.Forms.Button button_Insert;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

