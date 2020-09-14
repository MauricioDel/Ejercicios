using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero ;

        public string SetNumero
        {
            set
            {
                numero = ValidarNumero(value);
            }
                           
         }
        //metodos
        public string BimarioDecimal(string binario)
        {
            bool flag = true;
            EsBinario(binario);
            int[] cadEnterio = new int[binario.Length];
            double numero = 0;
          string retorno= " ";
            //Recorro todo el array de caracteres igresados
            for (int i = 0; i < binario.Length; i++)
            {
                //trasformo a punto flotante y valido 
                cadEnterio[i] = (int)char.GetNumericValue(binario[i]);
                if (cadEnterio[i] != 0 && cadEnterio[i] != 1)
                {
                    flag = false;
                    break;
                }


            }
            // si es verdadero recorro todo el array de nuevo 
            if (flag == true)
            {
                for (int i = 0; i < binario.Length; i++)
                {
                    numero += cadEnterio[i] * Math.Pow(2, binario.Length - i - 1);


                }
                retorno = numero.ToString();
            }
            else
            {
                retorno = ("\n Valor invalido");
            }

            return retorno;
        }

        //retorna el numero binario o un mensaje de error
        public string DecimalBinario(double numero)
        {
            return DecimalBinario(numero.ToString());
        }

        //convierto un decimal a binario , en caso contrario manda un error 

        public string DecimalBinario(string numero)
        {
            string retornar = "";
            decimal num1;
            uint num2;

            if (decimal.TryParse(numero, out num1))
            {
                if (UInt32.TryParse(numero, out num2))
                {
                    retornar = Convert.ToString(Convert.ToInt32(numero, 10), 2);
                }
                else
                {
                    retornar = "\n VAlor invalido\n";
                }
            }
            
             //retorna el numero binario o un mensaje de error
           else
            {
              retornar = "\n VAlor invalido\n";
            }
            return retornar;
        }

       

        public Numero(double numero) : this(numero.ToString())
        {

        }
        //Asigno 0 al atributo numero
        public Numero() : this(0)
        {

        }
      public Numero(string strNumero)
        {
            SetNumero = strNumero;
        }
        //sobrecarga de los constructores
        public static double operator +(Numero num1, Numero num2)
        {
            return num1.numero + num2.numero;
        }
        public static double operator -(Numero num1, Numero num2)
        {
            return num1.numero - num2.numero;
        }
        public static double operator *(Numero num1, Numero num2)
        {
            return num1.numero * num2.numero;
        }
        public static double operator /(Numero num1, Numero num2)
        {
            if (num2.numero != 0)
            {
                return num1.numero / num2.numero;
            }
            else
            {
                return double.MinValue;

            }
        }

        //validar q sea un numero
        private double ValidarNumero(string strNumero)
        {
            double aux = 0;
            double numero;
            if (Double.TryParse(strNumero, out numero))
            {
                aux = numero;
            }
            return aux;
        }

        private static bool EsBinario(string binario)
        {
            ulong aux = ulong.Parse(binario);

            if (aux == 0 || aux == 1)
            {
                return true;
            }
            else
                return false;

        }


    }
}
