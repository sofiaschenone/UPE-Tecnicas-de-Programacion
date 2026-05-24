using System;
using System.Collections.Generic;
using System.Text;

namespace AfterOffice.Dominio.DLL
{
    public class Cerveza
    {
     
        private string _nombre;
        private float _costoPorLitro;
        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }

        public float CostoPorLitro
        {
            get { return this._costoPorLitro; }
            set { this._costoPorLitro = value; }
        }

        public Cerveza(string nombre, float costoPorLitro)
        {
            this.Nombre = nombre;
            this.CostoPorLitro = costoPorLitro;
        }
        public string ObtenerNombre()
        {
            return this.Nombre;
        }

        public float ObtenerCosto()
        {
            return this.CostoPorLitro;
        }
    }
}