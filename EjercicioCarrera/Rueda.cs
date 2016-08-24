using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseTres
{
    public class Rueda
    {
        public string marca;
        public float tamaño;
        


        /// <summary>
        /// Va inicializar la marca en 'Sin marca' y tamaño en '0'.
        /// </summary>
        public Rueda()
        {
            //Implementación del código a rueda(int ...
            this.marca = "Sin marca";
            this.tamaño = 0;
        }

        public Rueda(string marca)
        {
            this.marca = marca;
        }


        /* No se reutiliza código. */
        //public Rueda(int tamaño)
        //{
        //    this.tamaño = tamaño; //Marca va a estar en 'null'
        //    this.marca = "Sin marca";
        //}

        public Rueda(int tamaño):this()
        {
            this.tamaño = tamaño; //Marca va a estar en 'null'
            this.marca = "Sin marca";
        }

        /// <summary>
        /// Recibe como parametro la marca y el tamaño.
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="tamaño"></param>
        public Rueda(string marca, int tamaño):this(tamaño) //Tiene límites yo eligo a que asignar, si el entero o el string.
        {
            this.marca = marca;
            //this.tamaño = tamaño;
        }


        public Rueda(int tamaño, string marca)
        {
            this.tamaño = tamaño;
            this.marca = marca;
        }

       


        public void MostrarRueda()
        { 
            Console.WriteLine("Tamaño: {0}", this.tamaño);
        }
    }
}
