using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
   
{
   public static class Calculadora
    {
         private static string ValidarOperador(char operador)
         {
            string aux = operador.ToString();

            if (aux == "'+'" || aux == "-" || aux == "*" || aux == "/")
            {
                return aux;
            }
            else
            {
                return "+";
            }

                 
         }
        // El método Operar será de clase: validará y realizará la operación pedida entre ambos números. 

        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double retorno = 0;
            char aux = char.Parse(operador);

            switch (ValidarOperador(aux))
            {

                case "+":
                    {
                        retorno = num1 + num2;
                        break;
                    }
                case "-":
                    {
                        retorno = (num1 - num2);
                        break;
                    }
                case "*":
                    {
                        retorno = (num1 * num2);
                        break;
                    }
                case "/":
                    {
                        retorno = (num1 / num2);
                        break;
                    }

                default:
                    retorno = num1 + num2;
                    break;

            }

            return retorno;



        }
    }
}
