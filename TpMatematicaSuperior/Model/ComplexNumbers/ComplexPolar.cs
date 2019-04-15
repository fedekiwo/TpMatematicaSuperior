﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpMatematicaSuperior.Model.ComplexNumbers
{
    public class ComplexPolar
    {
        private Double Module;
        private Double Angle;
        public Double ModulePart { get { return Module; } }
        public Double AnglePart { get { return Angle; } }

        public ComplexPolar(Double Module, Double Angle)
        {
            this.Module = Module;
            this.Angle = Angle;
        }

        public string GetNumber()
        {
            return "[" + this.Module.ToString() + " , " + this.Angle.ToString() + "]";
        }

        public ComplexBinomic ConvertToBinomicForm()
        {
            return new ComplexBinomic(this.Module * Math.Cos(this.Angle) , this.Module * Math.Sin(this.Angle));
        }

        public ComplexPolar Potencia(double numero)
        {
            return new ComplexPolar(Math.Pow(this.Module, numero), numero * this.Angle);
        }





    }
}
