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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "Olá " + ((Estado)cbEstados.SelectedItem).Id;
        }

        private void btnAbrir_Click_1(object sender, EventArgs e)
        {
            var form = new FrmShow();
            form.lblMensagem.Text = txtResultado.Text;
            form.Show();
        }
        private void fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void abrirCadastro_Click(object sender, EventArgs e)
        {
            new FrmCadastro().Show();
        }

        private void abrirLerTexto_Click(object sender, EventArgs e)
        {
            new FrmTexto().Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var contextMenu = new ContextMenu();
            contextMenu.MenuItems.Add(new MenuItem("Abrir Ler Texto", abrirLerTexto_Click));
            contextMenu.MenuItems.Add(new MenuItem("Fechar", fechar_Click));
            contextMenu.MenuItems.Add(new MenuItem("Abrir cadastro", abrirCadastro_Click));
            notifyIcon.ContextMenu = contextMenu;

            atualizaHora();

            /*********************************************/
            cbEstados.DataSource = Estado.Lista();
            cbEstados.Text = "Selecione";

            /*********************************************/

            /*
            cbEstados.Items.Clear();
            foreach (Estado es in Estado.Lista())
            {
                cbEstados.Items.Add(es);
            }*/
            /*********************************************/

            //Forma simples
            //dataGridView.DataSource = Estado.Lista();

            //forma mais complexa
            /*ataGridView.ColumnCount = 2;
             dataGridView.Columns[0].Name = "Id";
             dataGridView.Columns[1].Name = "Nome";

             var rows = new List<string[]>();
             foreach (Estado estado in Estado.Lista())
             {
                 string[] row1 = new string[] { estado.Id.ToString(), estado.Nome };
                 rows.Add(row1);
             }
             foreach (string[] rowArray in rows)
             {
                 dataGridView.Rows.Add(rowArray);
             }*/

            //maneira intermediaria
            //utilizando link
            var data = from estado in Estado.Lista()
                       //where estado.Id == 1 || estado.Id == 2
                       orderby estado.Nome
                       select new
                       {
                           Id = estado.Id,
                           Nome = estado.Nome
                       };
            dataGridView.DataSource = data.ToList();
        }

        private void atualizaHora()
        {
            lblHoraDia.Text = "Dia e Hora atual: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void novoTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmTexto = new FrmTexto();
            frmTexto.MdiParent = MDISingleton.InstanciaMDI();
            frmTexto.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmSobre().Show();
        }

        private void licençaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmLicenca().Show();
        }

        private void doaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmDoacao().Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            atualizaHora();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmCadastro().Show();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Cliquei no icone duas vezes");
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("Cliquei no icone");
        }

        private void btnNotificacao_Click(object sender, EventArgs e)
        {
            notifyIcon.ShowBalloonTip(10, "Notificação", "Erro na App", ToolTipIcon.None);
        }

        private void btnMDI_Click(object sender, EventArgs e)
        {
            new MDIParentPrincipal().Show();
        }
    }
}
