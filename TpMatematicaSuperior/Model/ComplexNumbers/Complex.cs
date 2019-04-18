using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpMatematicaSuperior.Model.ComplexNumbers
{
    public class Complex
    {
        private double Imaginary;
        private double Real;
        public double ImaginaryPart { get { return Imaginary; } }
        public double RealPart { get { return Real; } }

        public Complex(double Real, double Imaginary) {
            this.Real = Real;
            this.Imaginary = Imaginary;
            
        }

        public string GetBinomicForm() {
            return this.Real.ToString() + " " + this.Imaginary.ToString() +  "j";
        }

        public string GetPolarForm() {
            return "[" + this.GetMymodule().ToString() + " ; " + this.GetMyAlphaAngle().ToString() + "]";
        }

        private static double GetImaginaryPartByModuleAndAngle(double module, double angle) {
            return module * Math.Round(Math.Sin(angle), 15); 
        }
        
        //Hay que redondear por que si no te hay veces que en vez de 0 tira 6.12303176911189E-17 (0.00000000000000006) 

        private static double GetRealPartByModuleAndAngle(double module, double angle)
        {
            return module * Math.Round(Math.Cos(angle), 15);
        }
        
        private static Complex GetComplexByModuleAndAngle(double module, double angle) {
            return new Complex(GetRealPartByModuleAndAngle(module, angle),
                                      GetImaginaryPartByModuleAndAngle(module, angle));
        }

        private Complex GetMyConjugate() {
            return new Complex(this.Real, - this.Imaginary);
        }

        private Complex GetMyOpposite() {
            return new Complex(-this.Real, -this.Imaginary);
        }
        
        public double GetMymodule() {
            double sumOfTheSquares = this.GetMySumOfSquaresOf();
            return Math.Sqrt(sumOfTheSquares);
        }

        public double GetMySumOfSquaresOf() {
            int potencia = 2;
            return Math.Pow(this.Real, potencia) + Math.Pow(this.Imaginary, potencia);
        }

        public double GetMyAlphaAngle() {
            double angle = 0;
            if (this.Real != 0 && this.Imaginary != 0) {
                double argument = (this.Imaginary / this.Real);
                angle = Math.Atan(argument);
                angle += this.GetAngleCorrection();
            }
            else if (this.Real == 0 && this.Imaginary != 0) {
                angle = this.Imaginary > 0 ? Math.PI / 2 : Math.PI * 3 / 2;
            }
            else if (this.Imaginary == 0 && this.Real != 0 && this.Real < 0) {
                angle = Math.PI; 
            }

            return angle;
        }

        private double GetAngleCorrection()
        {
            double angleCorrection = 0;

            if ((this.Real < 0 && this.Imaginary > 0) || (this.Real < 0 && this.Imaginary < 0))
            {
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

        public static Complex operator *(Complex complex, double scalar) {
            return new Complex(complex.Real * scalar,
                               complex.Imaginary * scalar);
        }

        public static Complex operator *(double scalar, Complex complex) {
            return complex * scalar;
        }

        public static Complex operator /(Complex firstComplex, Complex secondComplex) {
            return GetComplexByModuleAndAngle(firstComplex.GetMymodule() / secondComplex.GetMymodule(), 
                                                  firstComplex.GetMyAlphaAngle() - secondComplex.GetMyAlphaAngle());
        }

    }

    
}
