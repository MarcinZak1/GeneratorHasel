namespace GeneratorHasel
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
            this.liczbaHasel = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.dlugoscHasla = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbWszystko = new System.Windows.Forms.RadioButton();
            this.rbCyfryiLit = new System.Windows.Forms.RadioButton();
            this.rbCyfry = new System.Windows.Forms.RadioButton();
            this.listaHasel = new System.Windows.Forms.ListBox();
            this.btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.liczbaHasel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlugoscHasla)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // liczbaHasel
            // 
            this.liczbaHasel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liczbaHasel.Location = new System.Drawing.Point(300, 8);
            this.liczbaHasel.Margin = new System.Windows.Forms.Padding(2);
            this.liczbaHasel.Maximum = new decimal(new int[] {
            25000,
            0,
            0,
            0});
            this.liczbaHasel.Name = "liczbaHasel";
            this.liczbaHasel.Size = new System.Drawing.Size(88, 26);
            this.liczbaHasel.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Liczba haseł";
            // 
            // dlugoscHasla
            // 
            this.dlugoscHasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dlugoscHasla.Location = new System.Drawing.Point(112, 9);
            this.dlugoscHasla.Margin = new System.Windows.Forms.Padding(2);
            this.dlugoscHasla.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.dlugoscHasla.Name = "dlugoscHasla";
            this.dlugoscHasla.Size = new System.Drawing.Size(88, 26);
            this.dlugoscHasla.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Długość hasła: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbWszystko);
            this.groupBox1.Controls.Add(this.rbCyfryiLit);
            this.groupBox1.Controls.Add(this.rbCyfry);
            this.groupBox1.Location = new System.Drawing.Point(28, 56);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(214, 171);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Typ hasła";
            // 
            // rbWszystko
            // 
            this.rbWszystko.AutoSize = true;
            this.rbWszystko.Location = new System.Drawing.Point(26, 115);
            this.rbWszystko.Margin = new System.Windows.Forms.Padding(2);
            this.rbWszystko.Name = "rbWszystko";
            this.rbWszystko.Size = new System.Drawing.Size(143, 17);
            this.rbWszystko.TabIndex = 2;
            this.rbWszystko.TabStop = true;
            this.rbWszystko.Text = "Cyfry, litery, zn. specjalne";
            this.rbWszystko.UseVisualStyleBackColor = true;
            // 
            // rbCyfryiLit
            // 
            this.rbCyfryiLit.AutoSize = true;
            this.rbCyfryiLit.Location = new System.Drawing.Point(26, 75);
            this.rbCyfryiLit.Margin = new System.Windows.Forms.Padding(2);
            this.rbCyfryiLit.Name = "rbCyfryiLit";
            this.rbCyfryiLit.Size = new System.Drawing.Size(77, 17);
            this.rbCyfryiLit.TabIndex = 1;
            this.rbCyfryiLit.TabStop = true;
            this.rbCyfryiLit.Text = "Cyfry i litery";
            this.rbCyfryiLit.UseVisualStyleBackColor = true;
            // 
            // rbCyfry
            // 
            this.rbCyfry.AutoSize = true;
            this.rbCyfry.Checked = true;
            this.rbCyfry.Location = new System.Drawing.Point(26, 34);
            this.rbCyfry.Margin = new System.Windows.Forms.Padding(2);
            this.rbCyfry.Name = "rbCyfry";
            this.rbCyfry.Size = new System.Drawing.Size(76, 17);
            this.rbCyfry.TabIndex = 0;
            this.rbCyfry.TabStop = true;
            this.rbCyfry.Text = "Tylko cyfry";
            this.rbCyfry.UseVisualStyleBackColor = true;
            // 
            // listaHasel
            // 
            this.listaHasel.FormattingEnabled = true;
            this.listaHasel.Location = new System.Drawing.Point(28, 252);
            this.listaHasel.Margin = new System.Windows.Forms.Padding(2);
            this.listaHasel.Name = "listaHasel";
            this.listaHasel.Size = new System.Drawing.Size(342, 186);
            this.listaHasel.TabIndex = 13;
            this.listaHasel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listaHasel_MouseDoubleClick);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(287, 118);
            this.btn.Margin = new System.Windows.Forms.Padding(2);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(74, 40);
            this.btn.TabIndex = 10;
            this.btn.Text = "Generuj";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 446);
            this.Controls.Add(this.liczbaHasel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dlugoscHasla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listaHasel);
            this.Controls.Add(this.btn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.liczbaHasel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlugoscHasla)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown liczbaHasel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown dlugoscHasla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbWszystko;
        private System.Windows.Forms.RadioButton rbCyfryiLit;
        private System.Windows.Forms.RadioButton rbCyfry;
        private System.Windows.Forms.ListBox listaHasel;
        private System.Windows.Forms.Button btn;
    }
}

