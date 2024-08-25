using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carnicería
{
    public partial class Form1 : Form
    {
        private Form activateForm = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Asegúrate de que MELI sea visible al inicio
            MELI.Visible = true;
        }

        private void openChildForm(Form childForm)
        {
            if (activateForm != null)
                activateForm.Close();

            activateForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(childForm);
            pnlContenedor.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            // Oculta el botón MELI cuando se abre un formulario secundario
            MELI.Visible = false;
        }

        private void ShowMainForm()
        {
            // Cierra el formulario secundario activo
            if (activateForm != null)
            {
                activateForm.Close();
                activateForm = null;
            }

            // Limpia el panel de formularios secundarios
            pnlContenedor.Controls.Clear();

            // Asegúrate de que el botón MELI sea visible
            if (!pnlContenedor.Controls.Contains(MELI))
            {
                pnlContenedor.Controls.Add(MELI);
            }
            MELI.Visible = true;
        }

        private void Pedidos_Click(object sender, EventArgs e)
        {
            Pedidos pedidos = new Pedidos();
            openChildForm(pedidos);
        }

        private void Proveedores_Click(object sender, EventArgs e)
        {
            Proveedores proveedores = new Proveedores();
            openChildForm(proveedores);
        }

        private void Home_Click(object sender, EventArgs e)
        {
            ShowMainForm();
        }

        private void Clientes_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            openChildForm(clientes);
        }

        private void Precios_Click(object sender, EventArgs e)
        {
            Precios precios = new Precios();
            openChildForm(precios);
        }

        private void Stock_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            openChildForm(stock);
        }

        private void MELI_Click(object sender, EventArgs e)
        {
            // Agrega el código para el botón MELI aquí si es necesario
        }
    }
}
