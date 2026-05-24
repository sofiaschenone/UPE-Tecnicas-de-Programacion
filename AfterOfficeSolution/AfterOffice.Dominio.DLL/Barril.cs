using System;
using System.Collections.Generic;
using System.Text;

namespace AfterOffice.Dominio.DLL
{
    public class Barril
    {
        private int _id;
        private float _capacidadLitros;
        private float _litrosDisponibles;
        private Cerveza _tipoCerveza; // Relación estructural a la clase Cerveza

        public int Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        public float CapacidadLitros
        {
            get { return this._capacidadLitros; }
            set { this._capacidadLitros = value; }
        }

        public float LitrosDisponibles
        {
            get { return this._litrosDisponibles; }
            set { this._litrosDisponibles = value; }
        }

        public Cerveza TipoCerveza
        {
            get { return this._tipoCerveza; }
            set { this._tipoCerveza = value; }
        }

        public Barril(int id, float capacidad, Cerveza cerveza)
        {
            this.Id = id;
            this.CapacidadLitros = capacidad;
            this.LitrosDisponibles = capacidad; // El barril arranca lleno por defecto
            this.TipoCerveza = cerveza;
        }
        public void DescontarLitros(float cantidad)
        {
            
            if (this.LitrosDisponibles < cantidad)
            {
                throw new Exception($"No hay stock suficiente en el barril N° {this.Id}. Quedan solo {this.LitrosDisponibles}L.");
            }
            this.LitrosDisponibles -= cantidad;
        }

        public float ObtenerStock()
        {
            return this.LitrosDisponibles;
        }

        public Cerveza ObtenerCerveza()
        {
            return this.TipoCerveza;
        }
    }
}