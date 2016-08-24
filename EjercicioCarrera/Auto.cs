using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseTres
{
    public class Auto
    {
        private Efabricante fabricante;
        private int KmRecorridos;
        public Rueda rdDI;
        public Rueda rdDD;
        public Rueda rdTI;
        public Rueda rdTD;
        public static int ContadorDeobjetos;
        private static  Random rnd;
        
        
        static Auto()
        {
            Auto.ContadorDeobjetos = 0;
            rnd = new Random();
        }
        
        public Auto()
        {                                 
            this.fabricante = (Efabricante)rnd.Next(0,3);
            this.rdDD = new Rueda();
            this.rdDI = new Rueda();
            this.rdTI = new Rueda();
            this.rdTD = new Rueda();

            Auto.ContadorDeobjetos++;
        }
        
        public static bool comprarAuto(Auto car1, Auto car2)
        {
            if (car1.fabricante == car2.fabricante)
                return true;
            
            return false;
        }

        public void MostarAuto()
        {
            Console.WriteLine("Fabricante: {0} Kilometraje: {1}KM",this.fabricante,this.KmRecorridos);
        }

        public void VolverAcero()
        {
            this.KmRecorridos = 0;
        }

        public void AgregarKilometros(int kilometros)
        {
            this.KmRecorridos += kilometros;
        }
    }
}
