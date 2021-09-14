using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_2___Herencia_y_Polimorfismo
{
    class Motocicleta:MedioTransporte
    {
        //Declaramos las propiedades
        //private string Color;
        //private string Marca;
        //private string Modelo;
        private string TipoMotor;

        //Constructor
        public Motocicleta()
        {
            setColor("");
            setMarca("");
            setModelo("");
            this.TipoMotor = "";
        }

        //Metodos setter y getters
        //Para Color
        //public void setColor(string col)
        //{
        //    this.Color = col;
        //}

        //public string getColor()
        //{
        //    return this.Color;
        //}

        //Para Marca
        //public void setMarca(string mar)
        //{
        //    this.Marca = mar;
        //}

        //public string getMarca()
        //{
        //    return this.Marca;
        //}

        //Para Modelo
        //public void setModelo(string mod)
        //{
        //    this.Modelo = mod;
        //}

        //public string getModelo()
        //{
        //    return this.Modelo;
        //}

        //Para TipoMotor
        public void setTipoMotor(string tipomot)
        {
            this.TipoMotor = tipomot;
        }

        public string getTipoMotor()
        {
            return this.TipoMotor;
        }

        //Metodos de funcionamiento dentro del sistema
        public void ingresarDatos()
        {
            Console.WriteLine("Ingrese los datos de la motocicleta: ");

            Console.Write("Ingrese el color: ");
            setColor(Console.ReadLine());

            Console.Write("Ingrese la marca: ");
            setMarca(Console.ReadLine());

            Console.Write("Ingrese el modelo: ");
            setModelo(Console.ReadLine());

            Console.Write("Ingrese el tipo de motor: ");
            setTipoMotor(Console.ReadLine());
        }

        public void mostrarDatos()
        {
            Console.WriteLine("Color: " + getColor());
            Console.WriteLine("Marca: " + getMarca());
            Console.WriteLine("Modelo: " + getModelo());
            Console.WriteLine("Tipo de Motor: " + getTipoMotor());
        }

        public override void arrancar()
        {
            Console.WriteLine("La motocicleta modelo "+ getModelo() + " ha arrancado");
        }
    }
}
