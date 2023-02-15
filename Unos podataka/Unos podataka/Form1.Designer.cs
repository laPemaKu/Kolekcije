namespace Unos_podataka
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
            this.txtBoxMarka = new System.Windows.Forms.TextBox();
            this.txtBoxModel = new System.Windows.Forms.TextBox();
            this.cmbBoxVrsta = new System.Windows.Forms.ComboBox();
            this.btnUnos = new System.Windows.Forms.Button();
            this.txtBoxIspis = new System.Windows.Forms.TextBox();
            this.btnIspis = new System.Windows.Forms.Button();
            this.btnObrada = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxMarka
            // 
            this.txtBoxMarka.Location = new System.Drawing.Point(23, 22);
            this.txtBoxMarka.Name = "txtBoxMarka";
            this.txtBoxMarka.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMarka.TabIndex = 0;
            // 
            // txtBoxModel
            // 
            this.txtBoxModel.Location = new System.Drawing.Point(23, 62);
            this.txtBoxModel.Name = "txtBoxModel";
            this.txtBoxModel.Size = new System.Drawing.Size(100, 20);
            this.txtBoxModel.TabIndex = 1;
            // 
            // cmbBoxVrsta
            // 
            this.cmbBoxVrsta.FormattingEnabled = true;
            this.cmbBoxVrsta.Items.AddRange(new object[] {
            "Avion",
            "Automobil",
            "Brod"});
            this.cmbBoxVrsta.Location = new System.Drawing.Point(23, 100);
            this.cmbBoxVrsta.Name = "cmbBoxVrsta";
            this.cmbBoxVrsta.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxVrsta.TabIndex = 2;
            this.cmbBoxVrsta.SelectedIndexChanged += new System.EventHandler(this.cmbBoxVrsta_SelectedIndexChanged);
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(23, 149);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(75, 23);
            this.btnUnos.TabIndex = 3;
            this.btnUnos.Text = "&Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // txtBoxIspis
            // 
            this.txtBoxIspis.Location = new System.Drawing.Point(200, 12);
            this.txtBoxIspis.Multiline = true;
            this.txtBoxIspis.Name = "txtBoxIspis";
            this.txtBoxIspis.Size = new System.Drawing.Size(239, 233);
            this.txtBoxIspis.TabIndex = 7;
            this.txtBoxIspis.TabStop = false;
            // 
            // btnIspis
            // 
            this.btnIspis.Location = new System.Drawing.Point(364, 261);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(75, 23);
            this.btnIspis.TabIndex = 5;
            this.btnIspis.Text = "&Ispis";
            this.btnIspis.UseVisualStyleBackColor = true;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // btnObrada
            // 
            this.btnObrada.Location = new System.Drawing.Point(200, 261);
            this.btnObrada.Name = "btnObrada";
            this.btnObrada.Size = new System.Drawing.Size(75, 23);
            this.btnObrada.TabIndex = 4;
            this.btnObrada.Text = "&Obrada";
            this.btnObrada.UseVisualStyleBackColor = true;
            this.btnObrada.Click += new System.EventHandler(this.btnObrada_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Marka:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Vrsta:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnObrada);
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.txtBoxIspis);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.cmbBoxVrsta);
            this.Controls.Add(this.txtBoxModel);
            this.Controls.Add(this.txtBoxMarka);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxMarka;
        private System.Windows.Forms.TextBox txtBoxModel;
        private System.Windows.Forms.ComboBox cmbBoxVrsta;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.TextBox txtBoxIspis;
        private System.Windows.Forms.Button btnIspis;
        private System.Windows.Forms.Button btnObrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

