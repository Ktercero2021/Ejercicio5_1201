namespace Ejercicio5_1201
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1_filas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2_columnas = new System.Windows.Forms.TextBox();
            this.btn_ejecutar = new System.Windows.Forms.Button();
            this.listBox1_imprimir = new System.Windows.Forms.ListBox();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese Filas:";
            // 
            // textBox1_filas
            // 
            this.textBox1_filas.Location = new System.Drawing.Point(280, 116);
            this.textBox1_filas.Name = "textBox1_filas";
            this.textBox1_filas.Size = new System.Drawing.Size(100, 20);
            this.textBox1_filas.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese Columnas:";
            // 
            // textBox2_columnas
            // 
            this.textBox2_columnas.Location = new System.Drawing.Point(280, 154);
            this.textBox2_columnas.Name = "textBox2_columnas";
            this.textBox2_columnas.Size = new System.Drawing.Size(100, 20);
            this.textBox2_columnas.TabIndex = 3;
            // 
            // btn_ejecutar
            // 
            this.btn_ejecutar.Location = new System.Drawing.Point(261, 203);
            this.btn_ejecutar.Name = "btn_ejecutar";
            this.btn_ejecutar.Size = new System.Drawing.Size(76, 34);
            this.btn_ejecutar.TabIndex = 4;
            this.btn_ejecutar.Text = "Ejecutar";
            this.btn_ejecutar.UseVisualStyleBackColor = true;
            this.btn_ejecutar.Click += new System.EventHandler(this.btn_ejecutar_Click);
            // 
            // listBox1_imprimir
            // 
            this.listBox1_imprimir.FormattingEnabled = true;
            this.listBox1_imprimir.Location = new System.Drawing.Point(231, 243);
            this.listBox1_imprimir.Name = "listBox1_imprimir";
            this.listBox1_imprimir.Size = new System.Drawing.Size(149, 134);
            this.listBox1_imprimir.TabIndex = 5;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(403, 343);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 34);
            this.btn_limpiar.TabIndex = 6;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(493, 343);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 34);
            this.btn_salir.TabIndex = 7;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(580, 407);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.listBox1_imprimir);
            this.Controls.Add(this.btn_ejecutar);
            this.Controls.Add(this.textBox2_columnas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1_filas);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1_filas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2_columnas;
        private System.Windows.Forms.Button btn_ejecutar;
        private System.Windows.Forms.ListBox listBox1_imprimir;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_salir;
    }
}

