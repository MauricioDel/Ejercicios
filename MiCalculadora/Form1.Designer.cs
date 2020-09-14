namespace MiCalculadora
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
            this.btn_Operar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.btn_ConvertirABinario = new System.Windows.Forms.Button();
            this.btn_ComvertirADecimal = new System.Windows.Forms.Button();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.txt_Numero1 = new System.Windows.Forms.TextBox();
            this.txt_Numero2 = new System.Windows.Forms.TextBox();
            this.cmb_Operador = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_Operar
            // 
            this.btn_Operar.Location = new System.Drawing.Point(2, 124);
            this.btn_Operar.Name = "btn_Operar";
            this.btn_Operar.Size = new System.Drawing.Size(100, 47);
            this.btn_Operar.TabIndex = 0;
            this.btn_Operar.Text = "Operar";
            this.btn_Operar.UseVisualStyleBackColor = true;
            this.btn_Operar.Click += new System.EventHandler(this.btn_Operar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(135, 124);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(109, 47);
            this.btn_limpiar.TabIndex = 1;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Location = new System.Drawing.Point(257, 124);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(97, 47);
            this.btn_Cerrar.TabIndex = 2;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // btn_ConvertirABinario
            // 
            this.btn_ConvertirABinario.Location = new System.Drawing.Point(48, 197);
            this.btn_ConvertirABinario.Name = "btn_ConvertirABinario";
            this.btn_ConvertirABinario.Size = new System.Drawing.Size(141, 46);
            this.btn_ConvertirABinario.TabIndex = 3;
            this.btn_ConvertirABinario.Text = "Comberitr a Binario";
            this.btn_ConvertirABinario.UseVisualStyleBackColor = true;
            this.btn_ConvertirABinario.Click += new System.EventHandler(this.btn_ConvertirABinario_Click);
            // 
            // btn_ComvertirADecimal
            // 
            this.btn_ComvertirADecimal.Location = new System.Drawing.Point(208, 197);
            this.btn_ComvertirADecimal.Name = "btn_ComvertirADecimal";
            this.btn_ComvertirADecimal.Size = new System.Drawing.Size(146, 46);
            this.btn_ComvertirADecimal.TabIndex = 4;
            this.btn_ComvertirADecimal.Text = "Convertir a Decimal";
            this.btn_ComvertirADecimal.UseVisualStyleBackColor = true;
            this.btn_ComvertirADecimal.Click += new System.EventHandler(this.btn_ComvertirADecimal_Click);
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Location = new System.Drawing.Point(254, 35);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(0, 13);
            this.lbl_Resultado.TabIndex = 5;
            // 
            // txt_Numero1
            // 
            this.txt_Numero1.Location = new System.Drawing.Point(2, 85);
            this.txt_Numero1.Name = "txt_Numero1";
            this.txt_Numero1.Size = new System.Drawing.Size(100, 20);
            this.txt_Numero1.TabIndex = 6;
            // 
            // txt_Numero2
            // 
            this.txt_Numero2.Location = new System.Drawing.Point(268, 86);
            this.txt_Numero2.Name = "txt_Numero2";
            this.txt_Numero2.Size = new System.Drawing.Size(100, 20);
            this.txt_Numero2.TabIndex = 7;
            // 
            // cmb_Operador
            // 
            this.cmb_Operador.FormattingEnabled = true;
            this.cmb_Operador.Location = new System.Drawing.Point(135, 86);
            this.cmb_Operador.Name = "cmb_Operador";
            this.cmb_Operador.Size = new System.Drawing.Size(109, 21);
            this.cmb_Operador.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 255);
            this.Controls.Add(this.cmb_Operador);
            this.Controls.Add(this.txt_Numero2);
            this.Controls.Add(this.txt_Numero1);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.btn_ComvertirADecimal);
            this.Controls.Add(this.btn_ConvertirABinario);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_Operar);
            this.Name = "Form1";
            this.Text = "Calculadora de Maurico Delgadillo 2°C";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Operar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Button btn_ConvertirABinario;
        private System.Windows.Forms.Button btn_ComvertirADecimal;
        private System.Windows.Forms.Label lbl_Resultado;
        private System.Windows.Forms.TextBox txt_Numero1;
        private System.Windows.Forms.TextBox txt_Numero2;
        private System.Windows.Forms.ComboBox cmb_Operador;
    }
}

