using System;
using System.Collections.Generic;
using System.Text;

namespace AfterOffice.Dominio.DLL
{
    public class Venta
    {
        private int _id;
        private float _litrosVendidos;
        private float _precioCobrado;
        private Barril _barrilOrigen; // Relación estructural a la clase Barril
 
        public string Cerveza
        {
            get
            {
                if (this._barrilOrigen != null && this._barrilOrigen.ObtenerCerveza() != null)
                {
                    return this._barrilOrigen.ObtenerCerveza().ObtenerNombre();
                }
                return "Sin especificar";
            }
        }

        public int Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        public float LitrosVendidos
        {
            get { return this._litrosVendidos; }
            set { this._litrosVendidos = value; }
        }

        public float PrecioCobrado
        {
            get { return this._precioCobrado; }
            set { this._precioCobrado = value; }
        }

        public Barril BarrilOrigen
        {
            get { return this._barrilOrigen; }
            set { this._barrilOrigen = value; }
        }
        public Venta(int id, float litros, float precio, Barril barril)
        {
            this.Id = id;
            this.LitrosVendidos = litros;
            this.PrecioCobrado = precio;
            this.BarrilOrigen = barril;
        }

        // Calcula la ganancia pura: Precio Cobrado - (Costo por Litro * Litros Vendidos)
        public float CalcularGanancia()
        {
            // Delegación: le pedimos el costo a la Cerveza a través del Barril de origen
            float costoPorLitro = this.BarrilOrigen.ObtenerCerveza().ObtenerCosto();
            float costoTotalDeEstaVenta = costoPorLitro * this.LitrosVendidos;

            return this.PrecioCobrado - costoTotalDeEstaVenta;
        }

        public float ObtenerLitros()
        {
            return this.LitrosVendidos;
        }

        public Barril ObtenerBarril()
        {
            return this.BarrilOrigen;
        }
    }
}