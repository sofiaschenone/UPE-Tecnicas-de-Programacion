namespace AfterOffice.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbBarriles = new ComboBox();
            cmbVasos = new ComboBox();
            btnVender = new Button();
            btnRecaudacion = new Button();
            lblResultado = new Label();
            btnBarrilMasRecaudador = new Button();
            btnCervezaMasVendida = new Button();
            btnBarrilMasSirvio = new Button();
            btnBarrilMenosSirvio = new Button();
            btnCervezaMasGanancia = new Button();
            btnCervezaMayorLitros = new Button();
            btnCervezaMenorLitros = new Button();
            dgvVentas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // cmbBarriles
            // 
            cmbBarriles.FormattingEnabled = true;
            cmbBarriles.Location = new Point(12, 47);
            cmbBarriles.Name = "cmbBarriles";
            cmbBarriles.Size = new Size(347, 23);
            cmbBarriles.TabIndex = 0;
            // 
            // cmbVasos
            // 
            cmbVasos.FormattingEnabled = true;
            cmbVasos.Location = new Point(12, 106);
            cmbVasos.Name = "cmbVasos";
            cmbVasos.Size = new Size(253, 23);
            cmbVasos.TabIndex = 1;
            // 
            // btnVender
            // 
            btnVender.BackColor = SystemColors.ButtonFace;
            btnVender.Location = new Point(346, 106);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(129, 23);
            btnVender.TabIndex = 2;
            btnVender.Text = "Registrar Venta";
            btnVender.UseVisualStyleBackColor = false;
            btnVender.Click += btnVender_Click;
            // 
            // btnRecaudacion
            // 
            btnRecaudacion.BackColor = SystemColors.ActiveCaption;
            btnRecaudacion.Location = new Point(532, 48);
            btnRecaudacion.Name = "btnRecaudacion";
            btnRecaudacion.Size = new Size(219, 23);
            btnRecaudacion.TabIndex = 3;
            btnRecaudacion.Text = "Calcular Recaudación Total";
            btnRecaudacion.UseVisualStyleBackColor = false;
            btnRecaudacion.Click += btnRecaudacion_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(532, 96);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(68, 15);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "Resultado...";
            // 
            // btnBarrilMasRecaudador
            // 
            btnBarrilMasRecaudador.BackColor = SystemColors.ActiveCaption;
            btnBarrilMasRecaudador.Location = new Point(811, 48);
            btnBarrilMasRecaudador.Name = "btnBarrilMasRecaudador";
            btnBarrilMasRecaudador.Size = new Size(221, 23);
            btnBarrilMasRecaudador.TabIndex = 5;
            btnBarrilMasRecaudador.Text = "Barril más Recaudador";
            btnBarrilMasRecaudador.UseVisualStyleBackColor = false;
            btnBarrilMasRecaudador.Click += btnBarrilMasRecaudador_Click;
            // 
            // btnCervezaMasVendida
            // 
            btnCervezaMasVendida.BackColor = SystemColors.ActiveCaption;
            btnCervezaMasVendida.Location = new Point(811, 178);
            btnCervezaMasVendida.Name = "btnCervezaMasVendida";
            btnCervezaMasVendida.Size = new Size(221, 23);
            btnCervezaMasVendida.TabIndex = 6;
            btnCervezaMasVendida.Text = "Cerveza más Vendida";
            btnCervezaMasVendida.UseVisualStyleBackColor = false;
            btnCervezaMasVendida.Click += btnCervezaMasVendida_Click;
            // 
            // btnBarrilMasSirvio
            // 
            btnBarrilMasSirvio.BackColor = SystemColors.ActiveCaption;
            btnBarrilMasSirvio.Location = new Point(811, 88);
            btnBarrilMasSirvio.Name = "btnBarrilMasSirvio";
            btnBarrilMasSirvio.Size = new Size(221, 23);
            btnBarrilMasSirvio.TabIndex = 7;
            btnBarrilMasSirvio.Text = "Barril que Más Sirvió";
            btnBarrilMasSirvio.UseVisualStyleBackColor = false;
            btnBarrilMasSirvio.Click += btnBarrilMasSirvio_Click;
            // 
            // btnBarrilMenosSirvio
            // 
            btnBarrilMenosSirvio.BackColor = SystemColors.ControlLight;
            btnBarrilMenosSirvio.Location = new Point(811, 282);
            btnBarrilMenosSirvio.Name = "btnBarrilMenosSirvio";
            btnBarrilMenosSirvio.Size = new Size(221, 23);
            btnBarrilMenosSirvio.TabIndex = 8;
            btnBarrilMenosSirvio.Text = "Barril que Menos Sirvió";
            btnBarrilMenosSirvio.UseVisualStyleBackColor = false;
            // 
            // btnCervezaMasGanancia
            // 
            btnCervezaMasGanancia.BackColor = SystemColors.ActiveCaption;
            btnCervezaMasGanancia.Location = new Point(811, 228);
            btnCervezaMasGanancia.Name = "btnCervezaMasGanancia";
            btnCervezaMasGanancia.Size = new Size(221, 23);
            btnCervezaMasGanancia.TabIndex = 9;
            btnCervezaMasGanancia.Text = "Cerveza con Mayor Ganancia";
            btnCervezaMasGanancia.UseVisualStyleBackColor = false;
            btnCervezaMasGanancia.Click += btnCervezaMasGanancia_Click;
            // 
            // btnCervezaMayorLitros
            // 
            btnCervezaMayorLitros.BackColor = SystemColors.ActiveCaption;
            btnCervezaMayorLitros.Location = new Point(811, 135);
            btnCervezaMayorLitros.Name = "btnCervezaMayorLitros";
            btnCervezaMayorLitros.Size = new Size(221, 23);
            btnCervezaMayorLitros.TabIndex = 10;
            btnCervezaMayorLitros.Text = "Mayor Cantidad de Cerveza Vendida";
            btnCervezaMayorLitros.UseVisualStyleBackColor = false;
            btnCervezaMayorLitros.Click += btnCervezaMayorLitros_Click;
            // 
            // btnCervezaMenorLitros
            // 
            btnCervezaMenorLitros.BackColor = SystemColors.ControlLight;
            btnCervezaMenorLitros.Location = new Point(811, 330);
            btnCervezaMenorLitros.Name = "btnCervezaMenorLitros";
            btnCervezaMenorLitros.Size = new Size(221, 23);
            btnCervezaMenorLitros.TabIndex = 11;
            btnCervezaMenorLitros.Text = "Menor Cantidad de Cerveza Vendida";
            btnCervezaMenorLitros.UseVisualStyleBackColor = false;
            btnCervezaMenorLitros.Click += btnCervezaMenorLitros_Click_1;
            // 
            // dgvVentas
            // 
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.GridColor = SystemColors.InactiveCaption;
            dgvVentas.Location = new Point(21, 150);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.Size = new Size(454, 263);
            dgvVentas.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 443);
            Controls.Add(dgvVentas);
            Controls.Add(btnCervezaMenorLitros);
            Controls.Add(btnCervezaMayorLitros);
            Controls.Add(btnCervezaMasGanancia);
            Controls.Add(btnBarrilMenosSirvio);
            Controls.Add(btnBarrilMasSirvio);
            Controls.Add(btnCervezaMasVendida);
            Controls.Add(btnBarrilMasRecaudador);
            Controls.Add(lblResultado);
            Controls.Add(btnRecaudacion);
            Controls.Add(btnVender);
            Controls.Add(cmbVasos);
            Controls.Add(cmbBarriles);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbBarriles;
        private ComboBox cmbVasos;
        private Button btnVender;
        private Button btnRecaudacion;
        private Label lblResultado;
        private Button btnBarrilMasRecaudador;
        private Button btnCervezaMasVendida;
        private Button btnBarrilMasSirvio;
        private Button btnBarrilMenosSirvio;
        private Button btnCervezaMasGanancia;
        private Button btnCervezaMayorLitros;
        private Button btnCervezaMenorLitros;
        private DataGridView dgvVentas;
    }
}
