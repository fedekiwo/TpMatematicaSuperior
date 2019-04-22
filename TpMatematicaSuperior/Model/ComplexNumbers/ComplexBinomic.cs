using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpMatematicaSuperior.Model.ComplexNumbers
{
    public class ComplexBinomic
    {
        private Double Imaginary;
        private Double Real;
        public Double ImaginaryPart { get { return Imaginary; } }
        public Double RealPart { get { return Real; } }

        public ComplexBinomic(Double Real, Double Imaginary)
        {
            this.Real = Real;
            this.Imaginary = Imaginary;

        }

        // 1. Estructura de Datos y Transformaciones

        public string GetNumber()
        {
            return this.Real.ToString() + " " + this.Imaginary.ToString() + "j";
        }

        public ComplexPolar ConvertToPolarForm()
        {
            return new ComplexPolar(this.GetMymodule(), this.GetMyAlphaAngle());
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

        // 2. Operaciones Basicas

        private ComplexBinomic GetMyConjugate()
        {
            return new ComplexBinomic(this.Real, -this.Imaginary);
        }

        private ComplexBinomic GetMyOpposite()
        {
            return new ComplexBinomic(-this.Real, -this.Imaginary);
        }

        public static ComplexBinomic operator +(ComplexBinomic firstComplex, ComplexBinomic secondComplex)
        {
            return new ComplexBinomic(firstComplex.Real + secondComplex.Real,
                               firstComplex.Imaginary + secondComplex.Imaginary);
        }
        public static ComplexBinomic operator -(ComplexBinomic firstComplex, ComplexBinomic secondComplex)
        {
            return firstComplex + secondComplex.GetMyOpposite();
        }

        public static ComplexBinomic operator *(ComplexBinomic firstComplex, ComplexBinomic secondComplex)
        {
            return new ComplexBinomic(firstComplex.Real * secondComplex.Real,
                               firstComplex.Imaginary * secondComplex.Imaginary);
        }

        public static ComplexBinomic operator *(ComplexBinomic complex, double scalar)
        {
            return new ComplexBinomic(complex.Real * scalar,
                               complex.Imaginary * scalar);
        }

        public static ComplexBinomic operator *(double scalar, ComplexBinomic complex)
        {
            return complex * scalar;
        }

        public static ComplexBinomic operator /(ComplexBinomic firstComplex, ComplexBinomic secondComplex)
        {
            double aux1, aux2, aux3;
            aux1 = (firstComplex.Real * secondComplex.Real) + (firstComplex.Imaginary * secondComplex.Imaginary);
            aux2 = (secondComplex.Real * firstComplex.Imaginary) - (firstComplex.Real * secondComplex.Imaginary);
            aux3 = Math.Pow(Convert.ToDouble(secondComplex.Real), 2) + Math.Pow(Convert.ToDouble(secondComplex.Imaginary), 2);
            return new ComplexBinomic(aux1 / aux3, aux2 / aux3);

        }

    }


}
