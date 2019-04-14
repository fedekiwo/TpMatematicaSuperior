using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpMatematicaSuperior.Model.ComplexNumbers
{
    public class Complex
    {
        public Decimal Imaginary { get; set; }
        public Decimal Real { get; set; }

        public Complex(Decimal Real, Decimal Imaginary) {
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
            double sumOfTheSquares = this.GetMySumOfSquaresOf(this.Real, this.Imaginary);
            return Math.Sqrt(sumOfTheSquares);
        }

        public Double GetMySumOfSquaresOf(Decimal firstComplex, Decimal secondComplex)
        {
            int potencia = 2;
            return Math.Pow(Convert.ToDouble(firstComplex), potencia) + Math.Pow(Convert.ToDouble(secondComplex), potencia);
        }

        public Double GetMyAlphaAngle()
        {
            double argumento = (Convert.ToDouble(this.Imaginary) /Convert.ToDouble(this.Real));
            return Math.Atan(argumento);
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
            decimal aux1, aux2, aux3;
            aux1 = (firstComplex.Real * secondComplex.Real) + (firstComplex.Imaginary * secondComplex.Imaginary);
            aux2 = (secondComplex.Real * firstComplex.Imaginary) - (firstComplex.Real * secondComplex.Imaginary);
            aux3 = Convert.ToDecimal( Math.Pow(Convert.ToDouble(secondComplex.Real), 2) + Math.Pow(Convert.ToDouble(secondComplex.Imaginary), 2));
            return new Complex( aux1 / aux3 , aux2 / aux3);
        }

    }
}
