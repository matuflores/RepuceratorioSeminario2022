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
    public partial class frmAutores : Form
    {
        public frmAutores()
        {
            InitializeComponent();
        }


        private AutoresServicios servicio;
        private List<Autor> lista;

        private void frmAutores_Load(object sender, EventArgs e)
        {
            servicio = new AutoresServicios();
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
        private void AbrirFormulario(frmAutores frmAutores)
        {
            frmAutores.TopLevel = false;
            frmAutores.FormBorderStyle = FormBorderStyle.None;
            frmAutores.Dock = DockStyle.Fill;

            DatosDataGridView.Controls.Add(frmAutores);

            frmAutores.Show();
        }

        private void MostrarDatosEnGrilla()
        {
            HelperGrid.LimpiarGrilla(DatosDataGridView);
            foreach (var autor in lista)
            {
                var r = HelperGrid.ConstruirFila(DatosDataGridView);
                HelperGrid.SetearFila(r, autor);
                HelperGrid.AgregarFila(DatosDataGridView, r);
            }
        }
    }
}
