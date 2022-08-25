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
    public partial class frmEditoriales : Form
    {
        public frmEditoriales()
        {
            InitializeComponent();
        }


        private EditorialesServicio servicio;
        private List<Editorial> lista;

        

        private void AbrirFormulario(frmEditoriales frmEditoriales)
        {
            frmEditoriales.TopLevel = false;
            frmEditoriales.FormBorderStyle = FormBorderStyle.None;
            frmEditoriales.Dock = DockStyle.Fill;

            DatosDataGridView.Controls.Add(frmEditoriales);

            frmEditoriales.Show();
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

        private void frmEditoriales_Load(object sender, EventArgs e)
        {
            servicio = new EditorialesServicio();
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
