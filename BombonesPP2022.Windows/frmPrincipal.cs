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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void GenerosButton_Click(object sender, EventArgs e)
        {
            Form generosLiterarios = new frmGeneroLiterarios();
            generosLiterarios.Show();
        }

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Desea cerrar la aplicación?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void AutoresButton_Click(object sender, EventArgs e)
        {
            Form autor = new frmAutores();
            autor.Show();
        }

        private void EditorialesButton_Click(object sender, EventArgs e)
        {
            Form editorial = new frmEditoriales();
            editorial.Show();
        }
    }
}
