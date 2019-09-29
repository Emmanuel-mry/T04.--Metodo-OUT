using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion_Consola
{
    class Principal
    {
        public void CapturarDatos()
        {
            //Declaracion de variables locales
            int Totalcentavos; 
            int Pesos = 0;
            int Centavos = 0;

            Console.WriteLine("INGRESE LOS CENTAVOS QUE DESEA CONVERTIR"); //Capturando los centavos 
            Console.WriteLine();
            Totalcentavos = Convert.ToInt32(Console.ReadLine());

            Convertir(Totalcentavos, out Pesos, out Centavos); //declaracion de out
            Console.WriteLine("PESOS:"+" "+Pesos);
            Console.WriteLine("CENTAVOS"+" "+ Centavos);
            Console.ReadKey();



        }

        public void Convertir(int TotalCentavos, out int Pesos, out int Centavos) //Declaracion del out
        {
            //Aqui se realizan las operaciones
            Pesos = TotalCentavos / 100;
            Centavos = TotalCentavos % 100;
        }
    }
}
