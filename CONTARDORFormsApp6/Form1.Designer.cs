namespace CONTARDORFormsApp6
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
            this.button1 = new System.Windows.Forms.Button();
            this.textDesde = new System.Windows.Forms.TextBox();
            this.textHasta = new System.Windows.Forms.TextBox();
            this.textBoxCONT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(382, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 143);
            this.button1.TabIndex = 0;
            this.button1.Text = "CONTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textDesde
            // 
            this.textDesde.Location = new System.Drawing.Point(93, 73);
            this.textDesde.Name = "textDesde";
            this.textDesde.Size = new System.Drawing.Size(261, 20);
            this.textDesde.TabIndex = 1;
            this.textDesde.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textHasta
            // 
            this.textHasta.Location = new System.Drawing.Point(93, 140);
            this.textHasta.Name = "textHasta";
            this.textHasta.Size = new System.Drawing.Size(261, 20);
            this.textHasta.TabIndex = 2;
            this.textHasta.TextChanged += new System.EventHandler(this.textHasta_TextChanged);
            // 
            // textBoxCONT
            // 
            this.textBoxCONT.Location = new System.Drawing.Point(93, 235);
            this.textBoxCONT.Name = "textBoxCONT";
            this.textBoxCONT.Size = new System.Drawing.Size(427, 20);
            this.textBoxCONT.TabIndex = 3;
            this.textBoxCONT.TextChanged += new System.EventHandler(this.textBoxCONT_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "DESDE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "HASTA";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CONTARDORFormsApp6.Properties.Resources.contar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCONT);
            this.Controls.Add(this.textHasta);
            this.Controls.Add(this.textDesde);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.Name = "Form1";
            this.Text = "CONTADOR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textDesde;
        private System.Windows.Forms.TextBox textHasta;
        private System.Windows.Forms.TextBox textBoxCONT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

