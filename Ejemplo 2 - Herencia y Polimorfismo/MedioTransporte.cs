using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_2___Herencia_y_Polimorfismo
{
    abstract class MedioTransporte
    {
        //Declaramos las propiedades
        private string Color;
        private string Marca;
        private string Modelo;

        //Metodos setter y getters
        //Para Color
        public void setColor(string col)
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
        }

        //Metodos fijos
        public abstract void arrancar();
    }
}
