using BombonesPP2022.Entidades.Entidades;
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
    public partial class frmEditorialesAE : Form
    {
        public frmEditorialesAE()
        {
            InitializeComponent();
        }


        private Editorial editorial;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (editorial != null)
            {
                EditorialTextBox.Text = editorial.NombreEditorial;
            }
        }

        public Editorial GetEditorial()
        {
            return editorial;
        }

        

        private bool ValidarDatos()
        {
            errorProvider1.Clear();
            bool valido = true;
            if (string.IsNullOrEmpty(EditorialTextBox.Text))
            {
                valido = false;
                errorProvider1.SetError(EditorialTextBox, "Ingrese una Editorial");
            }

            return valido;
        }

        public void SetEditorial(Editorial editorial)
        {
            this.editorial = editorial;
        }

        private void CancelarIconButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OKIconButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (editorial == null)
                {
                    editorial = new Editorial();
                }

                editorial.NombreEditorial = EditorialTextBox.Text;

                DialogResult = DialogResult.OK;
            }
        }
    }
}
