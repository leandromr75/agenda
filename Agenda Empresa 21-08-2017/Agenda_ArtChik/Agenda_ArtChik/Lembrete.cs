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
    public partial class Lembrete : Form
    {
        public Lembrete()
        {
            InitializeComponent();
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox2.Text = monthCalendar1.SelectionStart.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // MessageBox.Show( DateTime.Now.ToShortDateString());
            if (String.IsNullOrEmpty(textBox1.Text) == false && String.IsNullOrEmpty(textBox2.Text) == false
                && String.IsNullOrEmpty(comboBox5.Text) == false && String.IsNullOrEmpty(comboBox4.Text) == false)
            {
                DAL.InsereLembrete(textBox1.Text, textBox2.Text, comboBox5.Text, comboBox4.Text, comboBox7.Text, comboBox6.Text, comboBox9.Text, comboBox8.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Campos obrigatórios vazios",
                   "Erro", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox7.Text = comboBox5.Text;
            comboBox9.Text = comboBox5.Text;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox6.Text = comboBox4.Text;
            comboBox8.Text = comboBox4.Text;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Cyan;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }
    }
}
