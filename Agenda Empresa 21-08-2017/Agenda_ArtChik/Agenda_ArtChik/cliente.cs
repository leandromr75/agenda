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
    public partial class cliente : Form
    {
        public cliente()
        {
            InitializeComponent();
        }

        private void cliente_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DAL.ListaCliente();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) == false)
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        if (textBox1.Text == dataGridView1.Rows[i].Cells[0].Value.ToString())
                        {
                            MessageBox.Show("Já está cadastrado");
                            return;
                        }
                       
                    }
                    DAL.InsereCliente(textBox1.Text);
                    dataGridView1.DataSource = DAL.ListaCliente();
                    textBox1.Text = "";
                }
                if (dataGridView1.Rows.Count <= 0)
                {
                    DAL.InsereCliente(textBox1.Text);
                    dataGridView1.DataSource = DAL.ListaCliente();
                    textBox1.Text = "";
                }
                
            }
            else
            {
                MessageBox.Show("Informar Nome / Razão Social / Fantasia ");
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                
                Global.cliente.clientes = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].FormattedValue.ToString();
                this.Close();
            
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) == false)
            {
                dataGridView1.DataSource = DAL.ListaCliente2(textBox1.Text);
            }
            else
            {
                dataGridView1.DataSource = DAL.ListaCliente();
            }
        }
    }
}
