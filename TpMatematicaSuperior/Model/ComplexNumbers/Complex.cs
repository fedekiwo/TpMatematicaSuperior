using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpMatematicaSuperior.Model.ComplexNumbers
{
    public class Complex
    {
        public Double Imaginary { get; set; }
        public Double Real { get; set; }

        public Complex(Double Real, Double Imaginary) {
            this.Real = Real;
            this.Imaginary = Imaginary;
        }

        public string GetNumber() {
            return this.Real.ToString() + " " + this.Imaginary.ToString() +  "j";
        }

        private Complex GetMyConjugate() {
            return new Complex(this.Real, - this.Imaginary);
        }

        private Complex GetMyOpposite()
        {
            return new Complex(-this.Real, -this.Imaginary);
        }
        
        public Double GetMymodule()
        {
            double sumOfTheSquares = this.GetMySumOfSquaresOf();
            return Math.Sqrt(sumOfTheSquares);
        }

        public Double GetMySumOfSquaresOf()
        {
            int potencia = 2;
            return Math.Pow(this.Real, potencia) + Math.Pow(this.Imaginary, potencia);
        }

        public Double GetMyAlphaAngle()
        {
            double argument = 0;
            double angle = 0;
            if (this.Real != 0 && this.Imaginary != 0)
            {
                argument = (this.Imaginary / this.Real);
                angle = Math.Atan(argument) + this.GetAngleCorrection();
            }
            else if (this.Real == 0 && this.Imaginary != 0)
            {
                angle = this.Imaginary > 0 ? Math.PI / 2 : Math.PI * 3 / 2;
            }
            else if (this.Imaginary == 0 && this.Real != 0 && this.Real < 0)
            {
                angle = Math.PI; 
            }

            return angle;
        }

        private double GetAngleCorrection()
        {
            double angleCorrection = 0;

            if ((this.Real < 0 && this.Imaginary > 0) || (this.Real < 0 && this.Imaginary < 0)) {
                angleCorrection = Math.PI;
            }
            else if (this.Imaginary < 0)
            {
                angleCorrection = 2 * Math.PI;
            }

            return angleCorrection;
        }

        public static Complex operator +(Complex firstComplex, Complex secondComplex) {
            return new Complex(firstComplex.Real + secondComplex.Real, 
                               firstComplex.Imaginary + secondComplex.Imaginary);
        }
        public static Complex operator -(Complex firstComplex, Complex secondComplex) {
            return firstComplex + secondComplex.GetMyOpposite();
        }

        public static Complex operator *(Complex firstComplex, Complex secondComplex) {
            return new Complex(firstComplex.Real * secondComplex.Real,
                               firstComplex.Imaginary * secondComplex.Imaginary);
        }

        public static Complex operator /(Complex firstComplex, Complex secondComplex)
        {
            double aux1, aux2, aux3;
            aux1 = (firstComplex.Real * secondComplex.Real) + (firstComplex.Imaginary * secondComplex.Imaginary);
            aux2 = (secondComplex.Real * firstComplex.Imaginary) - (firstComplex.Real * secondComplex.Imaginary);
            aux3 = Math.Pow(Convert.ToDouble(secondComplex.Real), 2) + Math.Pow(Convert.ToDouble(secondComplex.Imaginary), 2);
            return new Complex( aux1 / aux3 , aux2 / aux3);
        }

    }
}
