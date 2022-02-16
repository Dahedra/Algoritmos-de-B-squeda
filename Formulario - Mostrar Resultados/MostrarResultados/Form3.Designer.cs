namespace MostrarResultados
{
    partial class Form3
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
            this.Enteros = new System.Windows.Forms.Label();
            this.BubleSort = new System.Windows.Forms.Label();
            this.MergeSort = new System.Windows.Forms.Label();
            this.QuickSort = new System.Windows.Forms.Label();
            this.SelectionSort = new System.Windows.Forms.Label();
            this.btn_MostrarBuble = new System.Windows.Forms.Button();
            this.btn_MostrarMerge = new System.Windows.Forms.Button();
            this.btn_MostrarQuick = new System.Windows.Forms.Button();
            this.btn_MostrarSelection = new System.Windows.Forms.Button();
            this.lbl_Cadenas = new System.Windows.Forms.Label();
            this.Btn_VolverAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Enteros
            // 
            this.Enteros.Location = new System.Drawing.Point(0, 0);
            this.Enteros.Name = "Enteros";
            this.Enteros.Size = new System.Drawing.Size(100, 23);
            this.Enteros.TabIndex = 13;
            // 
            // BubleSort
            // 
            this.BubleSort.AutoSize = true;
            this.BubleSort.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BubleSort.Location = new System.Drawing.Point(26, 130);
            this.BubleSort.Name = "BubleSort";
            this.BubleSort.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BubleSort.Size = new System.Drawing.Size(100, 26);
            this.BubleSort.TabIndex = 1;
            this.BubleSort.Text = "Buble Sort";
            // 
            // MergeSort
            // 
            this.MergeSort.AutoSize = true;
            this.MergeSort.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MergeSort.Location = new System.Drawing.Point(27, 188);
            this.MergeSort.Name = "MergeSort";
            this.MergeSort.Size = new System.Drawing.Size(107, 26);
            this.MergeSort.TabIndex = 2;
            this.MergeSort.Text = "Merge Sort";
            // 
            // QuickSort
            // 
            this.QuickSort.AutoSize = true;
            this.QuickSort.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuickSort.Location = new System.Drawing.Point(25, 252);
            this.QuickSort.Name = "QuickSort";
            this.QuickSort.Size = new System.Drawing.Size(101, 26);
            this.QuickSort.TabIndex = 3;
            this.QuickSort.Text = "Quick Sort";
            // 
            // SelectionSort
            // 
            this.SelectionSort.AutoSize = true;
            this.SelectionSort.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectionSort.Location = new System.Drawing.Point(25, 319);
            this.SelectionSort.Name = "SelectionSort";
            this.SelectionSort.Size = new System.Drawing.Size(130, 26);
            this.SelectionSort.TabIndex = 4;
            this.SelectionSort.Text = "Selection Sort";
            // 
            // btn_MostrarBuble
            // 
            this.btn_MostrarBuble.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MostrarBuble.Location = new System.Drawing.Point(233, 131);
            this.btn_MostrarBuble.Name = "btn_MostrarBuble";
            this.btn_MostrarBuble.Size = new System.Drawing.Size(119, 26);
            this.btn_MostrarBuble.TabIndex = 5;
            this.btn_MostrarBuble.Text = "Mostrar";
            this.btn_MostrarBuble.UseVisualStyleBackColor = true;
            this.btn_MostrarBuble.Click += new System.EventHandler(this.Btn_MostrarBuble_Click);
            // 
            // btn_MostrarMerge
            // 
            this.btn_MostrarMerge.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MostrarMerge.Location = new System.Drawing.Point(233, 188);
            this.btn_MostrarMerge.Name = "btn_MostrarMerge";
            this.btn_MostrarMerge.Size = new System.Drawing.Size(119, 23);
            this.btn_MostrarMerge.TabIndex = 6;
            this.btn_MostrarMerge.Text = "Mostrar";
            this.btn_MostrarMerge.UseVisualStyleBackColor = true;
            this.btn_MostrarMerge.Click += new System.EventHandler(this.Btn_MostrarMerge_Click);
            // 
            // btn_MostrarQuick
            // 
            this.btn_MostrarQuick.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MostrarQuick.Location = new System.Drawing.Point(233, 254);
            this.btn_MostrarQuick.Name = "btn_MostrarQuick";
            this.btn_MostrarQuick.Size = new System.Drawing.Size(119, 24);
            this.btn_MostrarQuick.TabIndex = 7;
            this.btn_MostrarQuick.Text = "Mostrar";
            this.btn_MostrarQuick.UseVisualStyleBackColor = true;
            this.btn_MostrarQuick.Click += new System.EventHandler(this.Btn_MostrarQuick_Click);
            // 
            // btn_MostrarSelection
            // 
            this.btn_MostrarSelection.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MostrarSelection.Location = new System.Drawing.Point(233, 322);
            this.btn_MostrarSelection.Name = "btn_MostrarSelection";
            this.btn_MostrarSelection.Size = new System.Drawing.Size(119, 23);
            this.btn_MostrarSelection.TabIndex = 8;
            this.btn_MostrarSelection.Text = "Mostrar";
            this.btn_MostrarSelection.UseVisualStyleBackColor = true;
            this.btn_MostrarSelection.Click += new System.EventHandler(this.Btn_MostrarSelection_Click);
            // 
            // lbl_Cadenas
            // 
            this.lbl_Cadenas.AutoSize = true;
            this.lbl_Cadenas.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cadenas.Location = new System.Drawing.Point(124, 32);
            this.lbl_Cadenas.Name = "lbl_Cadenas";
            this.lbl_Cadenas.Size = new System.Drawing.Size(113, 36);
            this.lbl_Cadenas.TabIndex = 14;
            this.lbl_Cadenas.Text = "Cadenas";
            // 
            // Btn_VolverAtras
            // 
            this.Btn_VolverAtras.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_VolverAtras.Location = new System.Drawing.Point(149, 397);
            this.Btn_VolverAtras.Name = "Btn_VolverAtras";
            this.Btn_VolverAtras.Size = new System.Drawing.Size(75, 35);
            this.Btn_VolverAtras.TabIndex = 15;
            this.Btn_VolverAtras.Text = "Atrás";
            this.Btn_VolverAtras.UseVisualStyleBackColor = true;
            this.Btn_VolverAtras.Click += new System.EventHandler(this.Btn_VolverAtras_Click);
            // 
            // Form3
            // 
            this.ClientSize = new System.Drawing.Size(364, 444);
            this.Controls.Add(this.Btn_VolverAtras);
            this.Controls.Add(this.lbl_Cadenas);
            this.Controls.Add(this.btn_MostrarSelection);
            this.Controls.Add(this.btn_MostrarQuick);
            this.Controls.Add(this.btn_MostrarMerge);
            this.Controls.Add(this.btn_MostrarBuble);
            this.Controls.Add(this.SelectionSort);
            this.Controls.Add(this.QuickSort);
            this.Controls.Add(this.MergeSort);
            this.Controls.Add(this.BubleSort);
            this.Controls.Add(this.Enteros);
            this.Name = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Enteros;
        private System.Windows.Forms.Label BubleSort;
        private System.Windows.Forms.Label MergeSort;
        private System.Windows.Forms.Label QuickSort;
        private System.Windows.Forms.Label SelectionSort;
        private System.Windows.Forms.Button btn_MostrarBuble;
        private System.Windows.Forms.Button btn_MostrarMerge;
        private System.Windows.Forms.Button btn_MostrarQuick;
        private System.Windows.Forms.Button btn_MostrarSelection;
        private System.Windows.Forms.Label lbl_Cadenas;
        private System.Windows.Forms.Button Btn_VolverAtras;
    }
}

