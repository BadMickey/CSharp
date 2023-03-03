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
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            var nome = txtNome.Text;
            try
            {
                int numero = int.Parse(txtNumero.Text);

                if(numero == 2)
                {
                    throw new ErroDeProposito("Erro de propósito");
                }
                else if(numero == 4)
                {
                    throw new Exception("Erro de propósito genérico");

                }
                numero += 100;
                MessageBox.Show("Olá " + nome + " o resultado do número mais 100 é: " + numero);
            }
            catch (FormatException Errformat)
            {
                MessageBox.Show("Olá cliente, você não teria digitado letra no lugar de números? " + Errformat.Message);
                txtNumero.Focus();
            }
            catch(ErroDeProposito errProposito)
            {
                MessageBox.Show("Erro de propósito: " + errProposito.StackTrace);

            }
            catch(Exception err)
            {
                MessageBox.Show("Olá cliente, você não teria digitado letra no lugar de números? ");
            }
            finally
            {
                MessageBox.Show("Todas as linhas de exceções tratadas");
            }
        }

        private void masktxtNmr_Leave(object sender, EventArgs e)
        {
            if (masktxtNmr.MaskCompleted)
            {
                MessageBox.Show("Máscara completa");
            }
            else
            {
                MessageBox.Show("Máscara incompleta");
            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(masktxtNmr.Text);
        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Busca sendo realizada, visando: " + tooltxtBusca);
        }
    }
    public class ErroDeProposito : Exception
    {
        public ErroDeProposito(string erro):base(erro) 
        {
            
        }
    }
}
