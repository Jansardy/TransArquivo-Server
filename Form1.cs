using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransArquivo_Server
{
    public partial class frmServidor : Form
    {
        Task tarefa;

        public frmServidor()
        {
            InitializeComponent();
        }

        private void frmServidor_Load(object sender, EventArgs e)
        {
            lblLink_Pasta.Text = FTServer.PastaRecepcaoArquivos;
            FTServer.ListaMensagem = listBox1;
        }

        private void btn_Conexao_Click(object sender, EventArgs e)
        {
            try
            {
                FTServer.EnderocoIP = txtBox_IP.Text;
                FTServer.PortaHost = Convert.ToInt32(txtPorta.Text);

                tarefa = Task.Factory.StartNew(() =>
                {
                    FTServer.IniciarServidor();
                });
            }
            catch (Exception ex)
            {
                listBox1.Invoke(new Action(() =>
                {
                    listBox1.Items.Add("Erro ao conectar: " + ex.Message);
                    listBox1.SetSelected(listBox1.Items.Count - 1, true);
                }));
            }
        }

        private void btn_StopConection_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Restart();
            }
            catch (Exception ex)
            {
                listBox1.Invoke(new Action(() =>
                {
                    listBox1.Items.Add("Erro : " + ex.Message);
                    listBox1.SetSelected(listBox1.Items.Count - 1, true);
                }));
            }
        }

        private void lblLink_Pasta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() != DialogResult.Cancel)
            {
                FTServer.PastaRecepcaoArquivos = dialog.SelectedPath + @"\";
                lblLink_Pasta.Text = FTServer.PastaRecepcaoArquivos;
            }
        }
    }
}
