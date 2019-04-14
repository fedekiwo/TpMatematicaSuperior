using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpMatematicaSuperior.Model.ComplexNumbers;

namespace TpMatematicaSuperior
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Complex n1 = new Complex(-1, 3);
            Complex n2 = new Complex(2, -5);

            var sum = n1 + n2;
            var subs = n1 - n2;
            var mult = n1 * n2;
            var div = n1 / n2;
            Console.WriteLine("Suma: " + sum.GetNumber());
            Console.WriteLine("Resta: " + subs.GetNumber());
            Console.WriteLine("Mult: " + mult.GetNumber());
            Console.WriteLine("Modulo del primer numero: " + n1.GetMymodule());
            Console.WriteLine("Modulo del segundo numero: " + n2.GetMymodule());
            Console.WriteLine("Angulo Alpha del primer numero: " + n1.GetMyAlphaAngle());
            Console.WriteLine("Angulo Alpha del segundo numero: " + n2.GetMyAlphaAngle());
            Console.WriteLine("Div: " + div.GetNumber());
            Console.WriteLine(Math.PI);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }
}
