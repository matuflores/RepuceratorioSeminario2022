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

        private void NuevoIconButton_Click(object sender, EventArgs e)
        {
            frmEditorialesAE frm = new frmEditorialesAE() { Text = "Agregar una editorial" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                Editorial editorial = frm.GetEditorial();
                if (!servicio.Existe(editorial))
                {
                    int registrosAfectados = servicio.Agregar(editorial);
                    if (registrosAfectados == 0)
                    {
                        MessageBox.Show("No se agregaron registros...",
                            "Advertencia",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                    else
                    {
                        var r = HelperGrid.ConstruirFila(DatosDataGridView);
                        HelperGrid.SetearFila(r, editorial);
                        HelperGrid.AgregarFila(DatosDataGridView, r);
                        MessageBox.Show("Registro agregado","Mensaje", MessageBoxButtons.OK,MessageBoxIcon.Information);

                    }

                }
                else
                {
                    MessageBox.Show("La editorial ya existe","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BorrarIconButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count == 0)
            {
                return;
            }

            try
            {
                var r = DatosDataGridView.SelectedRows[0];
                Editorial editorial = (Editorial)r.Tag;
                DialogResult dr = MessageBox.Show($"¿Desea eliminar la editorial {editorial.NombreEditorial}?", "Confirmar Eliminación",MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No)
                {
                    return;
                }
                DatosDataGridView.Rows.Remove(r);
                MessageBox.Show("Editorial eliminada","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditarIconButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count == 0)
            {
                return;
            }

            var r = DatosDataGridView.SelectedRows[0];
            Editorial editorial = (Editorial)r.Tag;
            Editorial editorialSecond = (Editorial)editorial.Clone();
            try
            {
                frmEditorialesAE frm = new frmEditorialesAE() { Text = "Editar la Editorial" };
                frm.SetEditorial(editorial);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }

                editorial = frm.GetEditorial();
                if (!servicio.Existe(editorial))
                {
                    int registrosAfectados = servicio.Editar(editorial);
                    if (registrosAfectados == 0)
                    {
                        MessageBox.Show("No se pudo modificar el registro","Advertencia",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        HelperGrid.SetearFila(r, editorial);
                        MessageBox.Show("Registro modificado","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }

                }
                else
                {
                    HelperGrid.SetearFila(r, editorialSecond);
                    MessageBox.Show("El registro ya existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception exception)
            {
                //SetearFila(r, paisAuxiliar);
                HelperGrid.SetearFila(r, editorialSecond);
                MessageBox.Show(exception.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
