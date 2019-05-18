using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpMatematicaSuperior.Model.ComplexNumbers
{
    public class Fasor
    {
        private Double Amplitud;
        private String FuncionTrigonometrica;
        private Double Frecuencia;
        private Double AnguloFase;


        public Double GetAmplitud { get { return Amplitud; } }
        public String GetFuncionTrigonometrica { get { return FuncionTrigonometrica; } }
        public Double GetFrecuencia { get { return Frecuencia; } }
        public Double GetAnguloFase { get { return AnguloFase; } }

        public Fasor(Double Amplitud, String FuncionTrigonometrica, Double Frecuencia, Double AnguloFase)
        {
            if (FuncionTrigonometrica != "sin" || FuncionTrigonometrica!= "cos")
            {
                throw new InvalidFasorException();
            }
            else
            {
                this.Amplitud = Amplitud;
                this.FuncionTrigonometrica = FuncionTrigonometrica;
                this.Frecuencia = Frecuencia;
                this.AnguloFase = AnguloFase;
            }
        }
    }
}
