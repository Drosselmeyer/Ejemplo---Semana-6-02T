using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_2___Herencia_y_Polimorfismo
{
    class Automovil:MedioTransporte
    {
        //Propiedades
        private string Matricula;
        //private string Color;
        //private string Marca;
        //private string Modelo;
        private int NoPuertas;

        //Constructor
        public Automovil()
        {
            this.Matricula = "";
            setColor("");
            setMarca("");
            setModelo("");
            this.NoPuertas = 0;
        }

        //Metodos setter y getters
        //Para Matricula
        public void setMatricula(string mat)
        {
            this.Matricula = mat;
        }

        public string getMatricula()
        {
            return this.Matricula;
        }

        //Para Color
        /*public void setColor(string col)
        {
            this.Color = col;
        }

        public string getColor()
        {
            return this.Color;
        }

        //Para Marca
        public void setMarca(string mar)
        {
            this.Marca = mar;
        }

        public string getMarca()
        {
            return this.Marca;
        }

        //Para Modelo
        public void setModelo(string mod)
        {
            this.Modelo = mod;
        }

        public string getModelo()
        {
            return this.Modelo;
        }*/

        //Para NoPuertas
        public void setNoPuertas(int nopuer)
        {
            this.NoPuertas = nopuer;
        }

        public int getNoPuertas()
        {
            return this.NoPuertas;
        }

        //Metodos de funcionamiento dentro del sistema
        public void ingresarDatos()
        {
            Console.WriteLine("Ingrese los datos del automovil: ");

            Console.Write("Ingrese la matricula: ");
            setMatricula(Console.ReadLine());

            Console.Write("Ingrese el color: ");
            setColor(Console.ReadLine());

            Console.Write("Ingrese la marca: ");
            setMarca(Console.ReadLine());

            Console.Write("Ingrese el modelo: ");
            setModelo(Console.ReadLine());

            Console.Write("Ingrese el numero de puertas: ");
            setNoPuertas(int.Parse(Console.ReadLine()));
        }

        public void mostrarDatos()
        {
            Console.WriteLine("Matricula: " + getMatricula());
            Console.WriteLine("Color: " + getColor());
            Console.WriteLine("Marca: " + getMarca());
            Console.WriteLine("Modelo: " + getModelo());
            Console.WriteLine("NoPuertas: " + getNoPuertas());
        }

        public override void arrancar()
        {
            Console.WriteLine("El automovil marca " + getMarca() +  " ha arrancado");
        }
    }
}
