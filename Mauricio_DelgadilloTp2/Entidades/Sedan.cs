﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Security;

namespace Entidades
{
    
    public class Sedan : Vehiculo
    {
       #region Enumerado
        public enum ETipo { CuatroPuertas, CincoPuertas }
        ETipo tipo;
        #endregion

        #region Constructores y sobracarga de los mismos
        /// <summary>
        /// Por defecto, TIPO será CuatroPuertas
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        /// 


        public Sedan(EMarca marca, string chasis, ConsoleColor color)
            :this (marca , chasis ,color ,ETipo.CuatroPuertas )
        {
            
        }
        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo)
            : base(marca, chasis, color)
        {
            this.tipo = tipo;
        }

        #endregion

        #region Propiedad
        /// <summary>
        /// Sedan son 'Mediano'
        /// </summary>       
        protected override ETamanio Tamanio
        {
            get
            {

                return ETamanio.Mediano;
            }
        }
        #endregion

        #region Metodo mostar
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("TAMAÑO : "+ this.Tamanio);
            sb.AppendLine("TIPO : " + this.tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}
