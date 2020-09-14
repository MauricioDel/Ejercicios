using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;


namespace MiCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] operadores = { "+", "-", "/", "*" };
            foreach (string op in operadores)
            {
                this.cmb_Operador.Items.Add(op);
            }

            this.cmb_Operador.Items.Add(" ");
            this.cmb_Operador.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmb_Operador.SelectedItem = ("/");

            btn_ConvertirABinario.Enabled = false;
            btn_ComvertirADecimal.Enabled = false;
        }
        private void Limpiar()
        {
            txt_Numero1.Clear();
            txt_Numero2.Clear();
            cmb_Operador.SelectedItem = null;
            lbl_Resultado.Text = "0";

            btn_ComvertirADecimal.Enabled = false;
            btn_ConvertirABinario.Enabled = false;
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ConvertirABinario_Click(object sender, EventArgs e)
        {
            Numero num = new Numero();
            lbl_Resultado.Text = num.DecimalBinario(lbl_Resultado.Text);
            btn_ComvertirADecimal.Enabled = true;
            btn_ConvertirABinario.Enabled = false;
        }





        private static double Operar(string numero1, string numero2, string operador)
        {
            return Entidades.Calculadora.Operar(new Numero(numero1), new Numero(numero2), operador);
        }

        private void btn_ComvertirADecimal_Click(object sender, EventArgs e)
        {
            Numero num = new Numero();

            lbl_Resultado.Text = num.BimarioDecimal(lbl_Resultado.Text);

            btn_ComvertirADecimal.Enabled = false;
            btn_ConvertirABinario.Enabled = true;
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void btn_Operar_Click(object sender, EventArgs e)
        {
            this.lbl_Resultado.Text = (Operar(txt_Numero1.Text, txt_Numero2.Text, cmb_Operador.Text)).ToString();

            btn_ConvertirABinario.Enabled = true;
            btn_ComvertirADecimal.Enabled = true;
        }

        private void cmb_Operador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
