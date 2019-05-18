using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpMatematicaSuperior.Model.ComplexNumbers;

namespace TpMatematicaSuperior.Model.ComplexNumbers
{
    public class Fasor
    {
        private Double Amplitude;
        private String FuncionSinusoidal;
        private Double Frequency;
        private Double FaseAngle;

        public Double GetAmplitude { get { return Amplitude; } }
        public String GetFuntionSinusoidal { get { return FuncionSinusoidal; } }
        public Double GetFrequency { get { return Frequency; } }
        public Double GetFaseAngle { get { return FaseAngle; } }

        public Fasor(Double Amplitud, String FuncionSinusoidal, Double Frecuencia, Double AnguloFase)
        {
            if ((string.Equals(FuncionSinusoidal,"sin")) || (string.Equals(FuncionSinusoidal, "cos")))
            {
                this.Amplitude = Amplitud;
                this.FuncionSinusoidal = FuncionSinusoidal;
                this.Frequency = Frecuencia;
                this.FaseAngle = AnguloFase;
            }
            else
            {
                throw new InvalidFasorException();
            }
        }

        public static Fasor operator +(Fasor firstFasor, Fasor secondFasor)
        {
            if(firstFasor.GetFrequency == secondFasor.GetFrequency)
            {
                return Sumar(firstFasor, secondFasor);
            }
            else
            {
                throw new InvalidOperationWithFasores();
            }
        }
 
        public static Fasor Sumar(Fasor firstFasor, Fasor secondFasor)
        {
            if (firstFasor.GetFuntionSinusoidal != secondFasor.GetFuntionSinusoidal)
            {
                CorrectionOfSenusoidalFunctions(firstFasor, secondFasor);
            }
             ComplexBinomic firstBinomic = ConvertToBinomic(firstFasor);
             ComplexBinomic secondBinomic = ConvertToBinomic(secondFasor);
             ComplexBinomic result = firstBinomic + secondBinomic;
             return ConvertToFasor(result,firstFasor.GetFuntionSinusoidal,firstFasor.GetFrequency);

        }
    
        public static void CorrectionOfSenusoidalFunctions(Fasor firstFasor,Fasor secondFasor)
        {
            if(firstFasor.GetFuntionSinusoidal == "sin")
            {
                secondFasor.FuncionSinusoidal = firstFasor.GetFuntionSinusoidal;
                secondFasor.Frequency = secondFasor.GetFrequency - (Math.PI / 2);
            }
            else
            {
                 CorrectionOfSenusoidalFunctions(secondFasor, firstFasor);
            }
        }

        public static ComplexBinomic ConvertToBinomic(Fasor fasor)
        {
            return new ComplexBinomic(fasor.GetAmplitude * Math.Cos(fasor.GetFaseAngle), fasor.GetAmplitude * Math.Sin(fasor.GetFaseAngle));
        }
        public static Fasor ConvertToFasor(ComplexBinomic binomic, String funtionSinusoidal, Double frecuencia)
        {
            Double newAmplitud = binomic.GetMymodule();
            Double newAnguloFase = binomic.GetMyAlphaAngle(); // al usar la funcion GetMyAlphaAngle(), nos devuelve siempre el angulo corregido(Es decir en la pimera vulta)
            return new Fasor(newAmplitud, funtionSinusoidal, frecuencia, newAnguloFase);
        }
    }

}
