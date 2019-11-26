using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_ArtChik
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(comboBox1.Text) == true)
            {
                MessageBox.Show("Favor escolher o tipo de Registro");
                return;
            }
            else
            {
                if (comboBox1.Text == "OS")
                {
                    if (String.IsNullOrEmpty(textBox3.Text) == true)
                    {
                        MessageBox.Show("Favor informar o número da Ordem de Serviço");
                        return;
                    }
                    if (String.IsNullOrEmpty(textBox3.Text) == false)
                    {
                        DAL.InsereRegistro(textBox1.Text,textBox2.Text,textBox3.Text,"","",comboBox1.Text,"aberto");
                        this.Close();
                        
                    }
                }
                else
                {
                    DAL.InsereRegistro(textBox1.Text, textBox2.Text, textBox3.Text, "", "", comboBox1.Text, "aberto");
                    this.Close();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form cli = new cliente();
            cli.ShowDialog();
            
            if (cli.DialogResult == DialogResult.Cancel)
            {
                textBox1.Text = Global.cliente.clientes;
            }
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            textBox2.Text = System.DateTime.Today.ToShortDateString();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}
