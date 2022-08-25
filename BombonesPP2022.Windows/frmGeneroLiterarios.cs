using BombonesPP2022.Entidades.Entidades;
using BombonesPP2022.Servicios.Servicios;
using BombonesPP2022.Windows.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BombonesPP2022.Windows
{
    public partial class frmGeneroLiterarios : Form
    {
        public frmGeneroLiterarios()
        {
            InitializeComponent();
        }

        private GenerosLiterariosServicios servicio;
        private List<GeneroLiterario> lista;

        private void AbrirFormulario(frmGeneroLiterarios frmGeneroLiterarios)
        {
            frmGeneroLiterarios.TopLevel = false;
            frmGeneroLiterarios.FormBorderStyle = FormBorderStyle.None;
            frmGeneroLiterarios.Dock = DockStyle.Fill;

            DatosDataGridView.Controls.Add(frmGeneroLiterarios);

            frmGeneroLiterarios.Show();
        }

        private void MostrarDatosEnGrilla()
        {
            HelperGrid.LimpiarGrilla(DatosDataGridView);
            foreach (var generoLiterario in lista)
            {
                var r = HelperGrid.ConstruirFila(DatosDataGridView);
                HelperGrid.SetearFila(r, generoLiterario);
                HelperGrid.AgregarFila(DatosDataGridView, r);
            }
        }

        private void frmGeneroLiterarios_Load(object sender, EventArgs e)
        {
            servicio = new GenerosLiterariosServicios();
            try
            {
                lista = servicio.GetLista();
                HelperForm.MostrarDatosEnGrilla(DatosDataGridView, lista);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
