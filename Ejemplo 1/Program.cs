using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaramos una instancia de automovil
            Automovil[] automoviles = new Automovil[3];

            //Inicializamos valores con el constructor a cada espacio del arreglo
            for(int i = 0; i<3; i++)
            {
                automoviles[i] = new Automovil();
            }

            //Este imprimira una matricula vacia
            /*Console.WriteLine("----------------------------------------------");
            Console.WriteLine("La matricula del automovil es: " + automoviles[0].getMatricula());

            //Solicitaremos la matricula y la imprimiremos
            Console.WriteLine("----------------------------------------------");
            Console.Write("Ingrese la matricula a almacenar: ");
            automoviles[0].setMatricula(Console.ReadLine());
            Console.WriteLine("La matricula del automovil es: " + automoviles[0].getMatricula());*/

            //Registraremos los 3 autos a la vez
            for(int i = 0; i<3; i++)
            {
                Console.WriteLine("Datos del automovil No: "+ i+1);
                automoviles[i].ingresarDatos();
                Console.WriteLine("----------------------------------------------");
            }

            //Mostramos todos los automoviles
            foreach(Automovil auto in automoviles)
            {
                auto.mostrarDatos();
                Console.WriteLine("----------------------------------------------");
            }



            //Detenemos la ejecucion
            Console.ReadKey();

        }
    }
}
