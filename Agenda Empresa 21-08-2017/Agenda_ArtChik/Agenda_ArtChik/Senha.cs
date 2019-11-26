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
    public partial class Senha : Form
    {
        public Senha()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "15101982")
            {
                this.Close();
                Form inf = new Info();
                inf.ShowDialog();
                
            }
            else
            {
                this.Close();
            }
        }
    }
}
