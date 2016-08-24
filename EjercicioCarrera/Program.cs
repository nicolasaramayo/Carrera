using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseTres
{
    class Program
    {
        static void Main()
        {
            Carrera carrrera;
            carrrera = new Carrera();
            carrrera.porTiempo(5);
            carrrera.MostrarCarrera();
            

            //Le asigno el tamaño a la rueda.
            Rueda objRueda = new Rueda(22);

            /*

            Efabricante fabricante;

            fabricante = Efabricante.Honda;
            
            Console.WriteLine(fabricante);
            fabricante = (Efabricante) 1; // Casteo 1 que seria el 2 fabricante del enumerado ya que es el tipo de dato.


           Console.WriteLine(fabricante);
            Auto nuevoAuto1 = new Auto();
            Auto nuevoAuto2 = new Auto();
            Auto nuevoAuto3 = new Auto();*/
            
            Console.ReadKey();
        }
    }
}
