using System;
using System.Windows.Forms;
using AfterOffice.Dominio.DLL;

namespace AfterOffice.UI
{
    public partial class Form1 : Form
    {

        private AfterOffice.Dominio.DLL.AfterOffice _afterOffice;
        private int _idVentaContador = 1;

        public Form1()
        {

            InitializeComponent();
            _afterOffice = new AfterOffice.Dominio.DLL.AfterOffice();
            CargarDatosDePrueba();
        }

        private void CargarDatosDePrueba()
        {
            try
            {

                Cerveza rubiaNac = new Cerveza("Rubia Nacional (UPE Craft)", 5000f);
                Cerveza negraNac = new Cerveza("Negra Porter Nacional", 5800f);
                Cerveza rojaNac = new Cerveza("Roja IPA Nacional", 6200f);
                Cerveza rubiaExt = new Cerveza("Rubia Premium Alemana", 7500f);
                Cerveza ipaExt = new Cerveza("Imperial IPA USA", 8200f);

                _afterOffice.RegistrarBarril(new Barril(1, 50f, rubiaNac));
                _afterOffice.RegistrarBarril(new Barril(2, 50f, negraNac));
                _afterOffice.RegistrarBarril(new Barril(3, 30f, rojaNac));
                _afterOffice.RegistrarBarril(new Barril(4, 30f, rubiaExt));
                _afterOffice.RegistrarBarril(new Barril(5, 20f, ipaExt));

                ActualizarComboBarriles();

                cmbVasos.Items.Clear();
                cmbVasos.Items.Add("Vaso de 1/2 Litro");
                cmbVasos.Items.Add("Chopp de 3/4 Litro");
                cmbVasos.Items.Add("Jarra de 3 Litros");

                if (cmbVasos.Items.Count > 0)
                {
                    cmbVasos.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}");
            }
        }

        private void ActualizarComboBarriles()
        {
            cmbBarriles.Items.Clear();
            foreach (Barril b in _afterOffice.ObtenerBarriles())
            {
                cmbBarriles.Items.Add($"Barril #{b.Id} - {b.ObtenerCerveza().ObtenerNombre()} (Stock: {b.ObtenerStock()}L)");
            }

            if (cmbBarriles.Items.Count > 0)
            {
                cmbBarriles.SelectedIndex = 0;
            }
        }
        private void btnVender_Click(object sender, EventArgs e)
        {
            try
            {
                int indiceBarril = cmbBarriles.SelectedIndex;
                if (indiceBarril == -1) return;

                Barril barrilSeleccionado = _afterOffice.ObtenerBarriles()[indiceBarril];

                float litros = 0f;
                if (cmbVasos.SelectedIndex == 0) litros = 0.5f;
                if (cmbVasos.SelectedIndex == 1) litros = 0.75f;
                if (cmbVasos.SelectedIndex == 2) litros = 3.0f;

                float costoLitro = barrilSeleccionado.ObtenerCerveza().ObtenerCosto();
                float precioPorLitro = costoLitro * 1.50f;
                float precioFinalCobrado = precioPorLitro * litros;

                barrilSeleccionado.DescontarLitros(litros);

                Venta nuevaVenta = new Venta(_idVentaContador++, litros, precioFinalCobrado, barrilSeleccionado);
                _afterOffice.RegistrarVenta(nuevaVenta);

                // Refrescamos los datos
                ActualizarComboBarriles();
                cmbBarriles.SelectedIndex = indiceBarril;
                // Refrescamos la tabla visual en pantalla
                ActualizarGrillaVentas();

                MessageBox.Show($"¡Venta realizada con éxito!\nPrecio final cobrado: ${precioFinalCobrado:N2}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnRecaudacion_Click(object sender, EventArgs e)
        {
            float total = _afterOffice.TotalRecaudadoDia();
            lblResultado.Text = $"Recaudación Total del After Office: ${total:N2}";
        }

        private void btnBarrilMasRecaudador_Click(object sender, EventArgs e)
        {
            Barril masRecaudador = _afterOffice.BarrilMasRecaudador();

            if (masRecaudador != null)
            {
                lblResultado.Text = $"Barril más recaudador: #{masRecaudador.Id} ({masRecaudador.ObtenerCerveza().ObtenerNombre()})";
            }
            else
            {
                lblResultado.Text = "No hay ventas registradas aún.";
            }
        }

        private void btnCervezaMasVendida_Click(object sender, EventArgs e)
        {
            Cerveza masVendida = _afterOffice.CervezaMasVendida();

            if (masVendida != null)
            {
                lblResultado.Text = $"Cerveza más vendida: {masVendida.ObtenerNombre()}";
            }
            else
            {
                lblResultado.Text = "No hay ventas registradas aún.";
            }
        }

        private void btnCervezaMenorLitros_Click(object sender, EventArgs e)
        {
            lblResultado.Text = _afterOffice.CervezaMenorLitros();
        }

        private void btnBarrilMasSirvio_Click(object sender, EventArgs e)
        {
            // Le pedimos la string armada al AfterOffice y la mostramos directo en el label
            lblResultado.Text = _afterOffice.BarrilMasCervezaSirvio();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCervezaMasGanancia_Click(object sender, EventArgs e)
        {
            Cerveza cv = _afterOffice.CervezaMasGanancia();
            lblResultado.Text = cv != null ? $"Más ganancia: {cv.ObtenerNombre()}" : "Sin ventas";
        }

        private void btnCervezaMayorLitros_Click(object sender, EventArgs e)
        {
            lblResultado.Text = _afterOffice.CervezaMayorLitros();
        }

        private void btnCervezaMenorLitros_Click_1(object sender, EventArgs e)
        {
            lblResultado.Text = _afterOffice.BarrilMenosCervezaSirvio();
        }
        private void ActualizarGrillaVentas()
        {
           
            dgvVentas.DataSource = null;
        
            dgvVentas.DataSource = _afterOffice.Ventas;

            if (dgvVentas.Columns.Count > 0)
            {
                if (dgvVentas.Columns["Id"] != null)
                    dgvVentas.Columns["Id"].Visible = false;
               
                if (dgvVentas.Columns["BarrilOrigen"] != null)
                    dgvVentas.Columns["BarrilOrigen"].Visible = false;

                if (dgvVentas.Columns["LitrosVendidos"] != null)
                    dgvVentas.Columns["LitrosVendidos"].HeaderText = "Litros Servidos";

                if (dgvVentas.Columns["PrecioCobrado"] != null)
                {
                    dgvVentas.Columns["PrecioCobrado"].HeaderText = "Total Cobrado";
                    dgvVentas.Columns["PrecioCobrado"].DefaultCellStyle.Format = "C2"; // Formato moneda $
                }

                if (dgvVentas.Columns["Cerveza"] != null)
                    dgvVentas.Columns["Cerveza"].HeaderText = "Variedad de Cerveza";
            }
        }
    }
}