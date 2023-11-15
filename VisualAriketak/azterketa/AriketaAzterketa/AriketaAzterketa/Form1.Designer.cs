namespace AriketaAzterketa
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.userControl11 = new CookpadDll.UserControl1();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NANtextbox = new System.Windows.Forms.TextBox();
            this.IzenaTextBox = new System.Windows.Forms.TextBox();
            this.EmailaTextBox = new System.Windows.Forms.TextBox();
            this.EzizenaTextBox = new System.Windows.Forms.TextBox();
            this.ErrezataIDTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(12, 42);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(538, 452);
            this.userControl11.TabIndex = 0;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022"});
            this.comboBox1.Location = new System.Drawing.Point(638, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "2022";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(638, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "NAN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(638, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "IZENA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(638, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "EMAILA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(638, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "EZIZENA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(638, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "ERREZETA ID";
            // 
            // NANtextbox
            // 
            this.NANtextbox.Location = new System.Drawing.Point(742, 156);
            this.NANtextbox.Name = "NANtextbox";
            this.NANtextbox.Size = new System.Drawing.Size(193, 20);
            this.NANtextbox.TabIndex = 7;
            // 
            // IzenaTextBox
            // 
            this.IzenaTextBox.Location = new System.Drawing.Point(742, 202);
            this.IzenaTextBox.Name = "IzenaTextBox";
            this.IzenaTextBox.Size = new System.Drawing.Size(193, 20);
            this.IzenaTextBox.TabIndex = 8;
            // 
            // EmailaTextBox
            // 
            this.EmailaTextBox.Location = new System.Drawing.Point(742, 242);
            this.EmailaTextBox.Name = "EmailaTextBox";
            this.EmailaTextBox.Size = new System.Drawing.Size(193, 20);
            this.EmailaTextBox.TabIndex = 9;
            // 
            // EzizenaTextBox
            // 
            this.EzizenaTextBox.Location = new System.Drawing.Point(742, 277);
            this.EzizenaTextBox.Name = "EzizenaTextBox";
            this.EzizenaTextBox.Size = new System.Drawing.Size(193, 20);
            this.EzizenaTextBox.TabIndex = 10;
            // 
            // ErrezataIDTextBox
            // 
            this.ErrezataIDTextBox.Location = new System.Drawing.Point(742, 315);
            this.ErrezataIDTextBox.Name = "ErrezataIDTextBox";
            this.ErrezataIDTextBox.Size = new System.Drawing.Size(193, 20);
            this.ErrezataIDTextBox.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(806, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "bidali";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 645);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ErrezataIDTextBox);
            this.Controls.Add(this.EzizenaTextBox);
            this.Controls.Add(this.EmailaTextBox);
            this.Controls.Add(this.IzenaTextBox);
            this.Controls.Add(this.NANtextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.userControl11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CookpadDll.UserControl1 userControl11;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NANtextbox;
        private System.Windows.Forms.TextBox IzenaTextBox;
        private System.Windows.Forms.TextBox EmailaTextBox;
        private System.Windows.Forms.TextBox EzizenaTextBox;
        private System.Windows.Forms.TextBox ErrezataIDTextBox;
        private System.Windows.Forms.Button button1;
    }
}

