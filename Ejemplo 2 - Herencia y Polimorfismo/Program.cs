using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_2___Herencia_y_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaramos una instancia de automovil
            Automovil[] automoviles = new Automovil[2];
            Motocicleta[] motocicletas = new Motocicleta[2];

            //Esto no se debe poder hacer, las clases padre no tienen
            //que ser instanciadas, solo a las clases hijo
            //Para evitar eso utilizamos la palabra reservada abstract
            //MedioTransporte medio = new MedioTransporte();

            //Inicializamos valores con el constructor a cada espacio del arreglo
            for (int i = 0; i < 2; i++)
            {
                automoviles[i] = new Automovil();
                motocicletas[i] = new Motocicleta();
            }

            //Registraremos los 2 autos a la vez
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Datos del automovil No: " + ( i + 1));
                automoviles[i].ingresarDatos();
                Console.WriteLine("----------------------------------------------");
            }

            //Registraremos los 2 motos a la vez
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Datos del motocicletas No: " + (i + 1));
                motocicletas[i].ingresarDatos();
                Console.WriteLine("----------------------------------------------");
            }

            //Mostramos todos los automoviles
            foreach (Automovil auto in automoviles)
            {
                auto.mostrarDatos();
                auto.arrancar();
                Console.WriteLine("----------------------------------------------");
            }

            //Mostramos todos las motocicletas
            foreach (Motocicleta moto in motocicletas)
            {
                moto.mostrarDatos();
                moto.arrancar();
                Console.WriteLine("----------------------------------------------");
            }



            //Detenemos la ejecucion
            Console.ReadKey();

        }
    }
}
