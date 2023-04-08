namespace Ul_ejemplo_1
{
    partial class txtN1
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
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtN_1 = new System.Windows.Forms.TextBox();
            this.txtN_2 = new System.Windows.Forms.TextBox();
            this.btnPrimos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(262, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "CALCULAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans MT", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(202, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 40);
            this.label4.TabIndex = 4;
            this.label4.Text = "OPERACIONES";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(111, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Numero1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(114, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Numero2";
            // 
            // txtN_1
            // 
            this.txtN_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN_1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtN_1.Location = new System.Drawing.Point(264, 65);
            this.txtN_1.Name = "txtN_1";
            this.txtN_1.Size = new System.Drawing.Size(186, 31);
            this.txtN_1.TabIndex = 7;
            // 
            // txtN_2
            // 
            this.txtN_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN_2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtN_2.Location = new System.Drawing.Point(264, 106);
            this.txtN_2.Name = "txtN_2";
            this.txtN_2.Size = new System.Drawing.Size(186, 31);
            this.txtN_2.TabIndex = 8;
            // 
            // btnPrimos
            // 
            this.btnPrimos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimos.Location = new System.Drawing.Point(162, 267);
            this.btnPrimos.Name = "btnPrimos";
            this.btnPrimos.Size = new System.Drawing.Size(365, 35);
            this.btnPrimos.TabIndex = 9;
            this.btnPrimos.Text = "MOSTRAR N NUMEROS PRIMOS";
            this.btnPrimos.UseVisualStyleBackColor = true;
            this.btnPrimos.Click += new System.EventHandler(this.btnPrimos_Click);
            // 
            // txtN1
            // 
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(552, 361);
            this.Controls.Add(this.btnPrimos);
            this.Controls.Add(this.txtN_2);
            this.Controls.Add(this.txtN_1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Name = "txtN1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textN1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtN_1;
        private System.Windows.Forms.TextBox txtN_2;
        private System.Windows.Forms.Button btnPrimos;
    }
}

