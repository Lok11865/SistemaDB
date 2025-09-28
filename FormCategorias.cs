using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormCategorias : Form
    {
        public FormCategorias()
        {
            InitializeComponent();
            SetupPlaceholderText(); // Agregar esta línea
        }

        private void SetupPlaceholderText()
        {
            // Configurar el texto de placeholder manualmente
            this.txtBuscar.Text = "Buscar categoría...";
            this.txtBuscar.ForeColor = Color.Gray;

            this.txtBuscar.Enter += (sender, e) =>
            {
                if (this.txtBuscar.Text == "Buscar categoría...")
                {
                    this.txtBuscar.Text = "";
                    this.txtBuscar.ForeColor = Color.Black;
                }
            };

            this.txtBuscar.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(this.txtBuscar.Text))
                {
                    this.txtBuscar.Text = "Buscar categoría...";
                    this.txtBuscar.ForeColor = Color.Gray;
                }
            };
        }

        // Los demás métodos de evento se mantienen igual...
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            // Lógica para nuevo
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Lógica para guardar
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Lógica para editar
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Lógica para eliminar
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Lógica para cancelar
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Lógica para actualizar
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Lógica para buscar
        }

        private void dgvCategorias_SelectionChanged(object sender, EventArgs e)
        {
            // Lógica cuando cambia selección
        }
    }
}