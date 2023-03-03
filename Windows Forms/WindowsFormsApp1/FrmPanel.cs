using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmPanel : Form
    {
        public FrmPanel()
        {
            InitializeComponent();
        }

        private void btnAlerta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O dado digitado é: " + txtNome.Text);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            pnlCadastro.Visible = true;
            pnlLista.Visible = false;
        }

        private void FrmPanel_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Estado.Lista();
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            pnlLista.Visible = true;
            pnlCadastro.Visible = false;
        }
    }
}
