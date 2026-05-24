using System;
using System.Collections.Generic;
using System.Linq;

namespace AfterOffice.Dominio.DLL
{
    public class AfterOffice
    {
       
        private List<Barril> _barriles;
        private List<Venta> _ventas;
        public List<Barril> Barriles
        {
            get { return this._barriles; }
            set { this._barriles = value; }
        }

        public List<Venta> Ventas
        {
            get { return this._ventas; }
            set { this._ventas = value; }
        }

        public AfterOffice()
        {
            this.Barriles = new List<Barril>();
            this.Ventas = new List<Venta>();
        }
        public void RegistrarBarril(Barril barril)
        {
            if (barril != null)
            {
                this.Barriles.Add(barril);
            }
        }

        public void RegistrarVenta(Venta venta)
        {
            if (venta != null)
            {
                this.Ventas.Add(venta);
            }
        }


        // Calcular la recaudación total del after
        public float TotalRecaudadoDia()
        {
            if (this.Ventas.Count == 0) return 0;
            return this.Ventas.Sum(static v => v.PrecioCobrado);
        }

        // Obtener el barril que más dinero recaudó
        public Barril BarrilMasRecaudador()
        {
            if (this.Ventas.Count == 0) return null;

            return this.Ventas
                .GroupBy(static v => v.BarrilOrigen)
                .OrderByDescending(static grupo => grupo.Sum(static v => v.PrecioCobrado))
                .Select(static grupo => grupo.Key)
                .FirstOrDefault();
        }

        // Mostrar la cerveza más vendida (por cantidad de vasos servidos)
        public Cerveza CervezaMasVendida()
        {
            if (this.Ventas.Count == 0) return null;

            return this.Ventas
                .GroupBy(static v => v.BarrilOrigen.ObtenerCerveza())
                .OrderByDescending(static grupo => grupo.Count())
                .Select(static grupo => grupo.Key)
                .FirstOrDefault();
        }
        public Cerveza CervezaMasGanancia()
        {
            if (this.Ventas.Count == 0) return null;
            return this.Ventas
                .GroupBy(static v => v.BarrilOrigen.ObtenerCerveza())
                .OrderByDescending(static grupo => grupo.Sum(static v => v.CalcularGanancia()))
                .Select(static grupo => grupo.Key)
                .FirstOrDefault();
        }

        public string BarrilMasCervezaSirvio()
        {
            if (this.Ventas.Count == 0) return "No hay ventas";

            var ganador = this.Ventas
                .GroupBy(static v => v.BarrilOrigen)
                .Select(static g => new { Barril = g.Key, TotalLitros = g.Sum(static v => v.LitrosVendidos) })
                .OrderByDescending(static x => x.TotalLitros)
                .FirstOrDefault();

            return $"Barril #{ganador.Barril.Id} - Sirvió: {ganador.TotalLitros}L";
        }

        public string BarrilMenosCervezaSirvio()
        {
            if (this.Ventas.Count == 0) return "No hay ventas";

            var perdedor = this.Ventas
                .GroupBy(static v => v.BarrilOrigen)
                .Select(static g => new { Barril = g.Key, TotalLitros = g.Sum(static v => v.LitrosVendidos) })
                .OrderBy(static x => x.TotalLitros) // Ordena de menor a mayor
                .FirstOrDefault();

            return $"Barril #{perdedor.Barril.Id} - Sirvió: {perdedor.TotalLitros}L";
        }
        public string CervezaMayorLitros()
        {
            if (this.Ventas.Count == 0) return "No hay ventas";
            var max = this.Ventas
                .GroupBy(static v => v.BarrilOrigen.ObtenerCerveza())
                .Select(static g => new { Cerveza = g.Key, Litros = g.Sum(static v => v.LitrosVendidos) })
                .OrderByDescending(static x => x.Litros)
                .FirstOrDefault();

            return $"Mayor volumen: {max.Cerveza.ObtenerNombre()} ({max.Litros}L)";
        }
        public string CervezaMenorLitros()
        {
            if (this.Ventas.Count == 0) return "No hay ventas";
            var min = this.Ventas
                .GroupBy(static v => v.BarrilOrigen.ObtenerCerveza())
                .Select(static g => new { Cerveza = g.Key, Litros = g.Sum(static v => v.LitrosVendidos) })
                .OrderBy(static x => x.Litros)
                .FirstOrDefault();

            return $"Menor volumen: {min.Cerveza.ObtenerNombre()} ({min.Litros}L)";
        }
        public List<Barril> ObtenerBarriles()
        {
            return this.Barriles;
        }
    }
}