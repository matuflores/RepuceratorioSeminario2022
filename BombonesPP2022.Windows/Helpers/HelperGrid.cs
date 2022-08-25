using BombonesPP2022.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BombonesPP2022.Windows.Helpers
{
    public static class HelperGrid
    {
        public static void LimpiarGrilla(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

        }
        public static DataGridViewRow ConstruirFila(DataGridView dataGrid)
        {
            var r = new DataGridViewRow();
            r.CreateCells(dataGrid);
            return r;
        }

        public static void AgregarFila(DataGridView dataGrid, DataGridViewRow r)
        {
            dataGrid.Rows.Add(r);
        }

        public static void SetearFila(DataGridViewRow r, Object obj)
        {
            switch (obj)
            {
                case GeneroLiterario g:
                    r.Cells[0].Value = ((GeneroLiterario)obj).Descripcion;

                    break;
                case Autor a:
                    r.Cells[0].Value = ((Autor)obj).Apellido;
                    r.Cells[1].Value = ((Autor)obj).Nombre;
                    r.Cells[2].Value = ((Autor)obj).Nacionalidad;
                    break;
                case Editorial e:
                    r.Cells[0].Value = ((Editorial)obj).NombreEditorial;
                    break;
            }

            r.Tag = obj;

        }
    }
}
