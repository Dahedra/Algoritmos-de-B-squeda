namespace MostrarResultados
{
    partial class MenuPrincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Enteros = new System.Windows.Forms.Button();
            this.btn_Reales = new System.Windows.Forms.Button();
            this.btn_Cadenas = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resultados de las Pruebas";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccione tipo de dato";
            // 
            // btn_Enteros
            // 
            this.btn_Enteros.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Enteros.Location = new System.Drawing.Point(197, 161);
            this.btn_Enteros.Name = "btn_Enteros";
            this.btn_Enteros.Size = new System.Drawing.Size(123, 53);
            this.btn_Enteros.TabIndex = 2;
            this.btn_Enteros.Text = "Enteros";
            this.btn_Enteros.UseVisualStyleBackColor = true;
            this.btn_Enteros.Click += new System.EventHandler(this.Btn_Enteros_Click);
            // 
            // btn_Reales
            // 
            this.btn_Reales.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reales.Location = new System.Drawing.Point(197, 265);
            this.btn_Reales.Name = "btn_Reales";
            this.btn_Reales.Size = new System.Drawing.Size(123, 53);
            this.btn_Reales.TabIndex = 3;
            this.btn_Reales.Text = "Reales";
            this.btn_Reales.UseVisualStyleBackColor = true;
            this.btn_Reales.Click += new System.EventHandler(this.Btn_Reales_Click);
            // 
            // btn_Cadenas
            // 
            this.btn_Cadenas.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cadenas.Location = new System.Drawing.Point(197, 367);
            this.btn_Cadenas.Name = "btn_Cadenas";
            this.btn_Cadenas.Size = new System.Drawing.Size(123, 52);
            this.btn_Cadenas.TabIndex = 4;
            this.btn_Cadenas.Text = "Cadenas";
            this.btn_Cadenas.UseVisualStyleBackColor = true;
            this.btn_Cadenas.Click += new System.EventHandler(this.Btn_Cadenas_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.Location = new System.Drawing.Point(450, 429);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(75, 34);
            this.Btn_Salir.TabIndex = 5;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 475);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.btn_Cadenas);
            this.Controls.Add(this.btn_Reales);
            this.Controls.Add(this.btn_Enteros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Enteros;
        private System.Windows.Forms.Button btn_Reales;
        private System.Windows.Forms.Button btn_Cadenas;
        private System.Windows.Forms.Button Btn_Salir;
    }
}