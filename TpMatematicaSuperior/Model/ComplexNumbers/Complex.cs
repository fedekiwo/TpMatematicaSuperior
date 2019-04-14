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
    }
}
