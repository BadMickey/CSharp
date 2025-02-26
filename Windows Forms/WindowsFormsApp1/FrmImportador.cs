﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace WindowsFormsApp1
{
    public partial class FrmImportador : Form
    {
        private string[] lines;
        public FrmImportador()
        {
            InitializeComponent();
        }

        private void FrmImportador_Load(object sender, EventArgs e)
        {
            string fileName = @"C:\Arquivos\Dados_Importar.txt";
            using (var StreamReader = File.OpenText(fileName))
            {
                lines = StreamReader.ReadToEnd().Split("/r/n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                progressBar.Maximum = lines.Length;
                progressBar.Minimum = 0;
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            string todasLinhas = string.Empty;
            for (var i = 0; i < lines.Length; i++)
            {
                var line = lines[i];
                progressBar.Value = (i + 1);

                todasLinhas += line + " - " + i + " - Importado\n";


                txtLogs.Update();
            }
            txtLogs.Text = "Todos os dados foram importados";

        }
    }
}
