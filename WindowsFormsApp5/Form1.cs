using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salvarClick(object sender, EventArgs e)
        {
            try
            {
                StreamWriter stream = new StreamWriter(@"C:\\Arquivos\\" + TXT_NOME.Text + TXT_SOBRENOME.Text + ".txt");
                stream.WriteLine("Nome:   " + TXT_NOME.Text);
                stream.WriteLine("Sobrenome:   " + TXT_SOBRENOME.Text);
                stream.WriteLine("Endereço:   " + TXT_ENDERECO.Text);
                stream.WriteLine("Endereço:   " + TXT_ARQUIVO.Text);
                stream.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void lerClick(object sender, EventArgs e)
        {
            try
            {
                StreamReader stream = new StreamReader(@"C:\\Arquivos\\" + TXT_NOME.Text + TXT_SOBRENOME.Text + ".txt");
                TXT_ARQUIVO.Text = stream.ReadToEnd();
                stream.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
