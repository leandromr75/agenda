using System;
using System.Data;
using System.Windows.Forms;


namespace Agenda_ArtChik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        DataTable lembrete;

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cad = new Cadastro();
            cad.ShowDialog();

            if (cad.DialogResult == DialogResult.Cancel)
            {
                dataGridView1.DataSource = DAL.ListaRegistro("tudo");

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (dataGridView1.Rows.Count > 0)
            {

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                richTextBox1.Text = "";
                richTextBox1.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[4].FormattedValue.ToString();
                textBox5.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[7].FormattedValue.ToString();
                textBox1.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].FormattedValue.ToString();
                textBox2.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[1].FormattedValue.ToString();
                textBox3.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[2].FormattedValue.ToString();
                textBox4.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[5].FormattedValue.ToString();
                textBox6.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[6].FormattedValue.ToString();
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = DAL.ListaLembrte(DateTime.Now.ToShortDateString());
            
            if (dataGridView2.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    dataGridView2.Columns[0].Width = 550;
                    
                }
            }
            dataGridView1.DataSource = DAL.ListaRegistro("tudo");

            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Columns[0].Width = 380;
                    dataGridView1.Columns[1].Width = 80;
                    dataGridView1.Columns[2].Width = 80;
                    dataGridView1.Columns[3].Width = 90;
                    dataGridView1.Columns[4].Width = 500;
                    dataGridView1.Columns[5].Width = 70;
                    dataGridView1.Columns[6].Width = 80;
                    dataGridView1.Columns[7].Width = 50;
                }
            }
            if (System.DateTime.Today.DayOfWeek.ToString() == "Friday")
            {
                //MessageBox.Show("Favor gerar relatório semanal de vendas.");
                MessageBox.Show("Necessário gerar relatório semanal de vendas.",
                    "Relatório", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            if (System.DateTime.Today.Day.ToString() == "1")
            {
                 //MessageBox.Show("Favor gerar relatório mensal de vendas e baixar mês anterior.");
                MessageBox.Show("Necessário gerar relatório mensal de vendas\n     e baixar mês anterior.",
                   "Relatório", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            }
            if (System.DateTime.Today.Day.ToString() == "2")
            {
                //MessageBox.Show("Favor gerar relatório mensal de vendas e baixar mês anterior.");
                MessageBox.Show("Necessário gerar relatório mensal de vendas\n     e baixar mês anterior.",
                   "Relatório", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            }
            if (System.DateTime.Today.Day.ToString() == "3")
            {
                //MessageBox.Show("Favor gerar relatório mensal de vendas e baixar mês anterior.");
                MessageBox.Show("Necessário gerar relatório mensal de vendas\n     e baixar mês anterior.",
                   "Relatório", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "Você deseja finalizar?";
            string caption = "Finalizar";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(this, message, caption, buttons,
            MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                if (String.IsNullOrEmpty(textBox5.Text) == false && textBox6.Text == "aberto")
                {
                    DAL.finaliza(textBox5.Text, System.DateTime.Today.ToShortDateString());
                    dataGridView1.DataSource = DAL.ListaRegistro("tudo");
                    if (dataGridView1.Rows.Count > 0)
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            dataGridView1.Columns[0].Width = 380;
                            dataGridView1.Columns[1].Width = 80;
                            dataGridView1.Columns[2].Width = 80;
                            dataGridView1.Columns[3].Width = 90;
                            dataGridView1.Columns[4].Width = 500;
                            dataGridView1.Columns[5].Width = 70;
                            dataGridView1.Columns[6].Width = 80;
                            dataGridView1.Columns[7].Width = 50;
                        }
                    }
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    richTextBox1.Text = "";
                }
            }
            
        }

        private void excluírRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Você deseja excluír este registro?";
            string caption = "Exclusão";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(this, message, caption, buttons,
            MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                if (String.IsNullOrEmpty(textBox5.Text) == false && textBox6.Text == "aberto")
                {
                    DAL.cancela(textBox5.Text);
                    dataGridView1.DataSource = DAL.ListaRegistro("tudo");
                    if (dataGridView1.Rows.Count > 0)
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            dataGridView1.Columns[0].Width = 380;
                            dataGridView1.Columns[1].Width = 80;
                            dataGridView1.Columns[2].Width = 80;
                            dataGridView1.Columns[3].Width = 90;
                            dataGridView1.Columns[4].Width = 500;
                            dataGridView1.Columns[5].Width = 70;
                            dataGridView1.Columns[6].Width = 80;
                            dataGridView1.Columns[7].Width = 50;
                        }
                    }
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    richTextBox1.Text = "";
                }     
            }
           
        }

        private void finalizadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DAL.ListaRegistro("um");
            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Columns[0].Width = 380;
                    dataGridView1.Columns[1].Width = 80;
                    dataGridView1.Columns[2].Width = 80;
                    dataGridView1.Columns[3].Width = 90;
                    dataGridView1.Columns[4].Width = 500;
                    dataGridView1.Columns[5].Width = 70;
                    dataGridView1.Columns[6].Width = 80;
                    dataGridView1.Columns[7].Width = 50;
                }
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            richTextBox1.Text = "";
        }

        private void emAndamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DAL.ListaRegistro("dois");
            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Columns[0].Width = 380;
                    dataGridView1.Columns[1].Width = 80;
                    dataGridView1.Columns[2].Width = 80;
                    dataGridView1.Columns[3].Width = 90;
                    dataGridView1.Columns[4].Width = 500;
                    dataGridView1.Columns[5].Width = 70;
                    dataGridView1.Columns[6].Width = 80;
                    dataGridView1.Columns[7].Width = 50;
                }
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            richTextBox1.Text = "";
        }

        private void finalizadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DAL.ListaRegistro("tres");
            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Columns[0].Width = 380;
                    dataGridView1.Columns[1].Width = 80;
                    dataGridView1.Columns[2].Width = 80;
                    dataGridView1.Columns[3].Width = 90;
                    dataGridView1.Columns[4].Width = 500;
                    dataGridView1.Columns[5].Width = 70;
                    dataGridView1.Columns[6].Width = 80;
                    dataGridView1.Columns[7].Width = 50;
                }
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            richTextBox1.Text = "";
        }

        private void emAndamentoAgendadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DAL.ListaRegistro("quatro");
            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Columns[0].Width = 380;
                    dataGridView1.Columns[1].Width = 80;
                    dataGridView1.Columns[2].Width = 80;
                    dataGridView1.Columns[3].Width = 90;
                    dataGridView1.Columns[4].Width = 500;
                    dataGridView1.Columns[5].Width = 70;
                    dataGridView1.Columns[6].Width = 80;
                    dataGridView1.Columns[7].Width = 50;
                }
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            richTextBox1.Text = "";
        }

        private void finalizadosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DAL.ListaRegistro("cinco");
            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Columns[0].Width = 380;
                    dataGridView1.Columns[1].Width = 80;
                    dataGridView1.Columns[2].Width = 80;
                    dataGridView1.Columns[3].Width = 90;
                    dataGridView1.Columns[4].Width = 500;
                    dataGridView1.Columns[5].Width = 70;
                    dataGridView1.Columns[6].Width = 80;
                    dataGridView1.Columns[7].Width = 50;
                }
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            richTextBox1.Text = "";
        }

        private void emAnadamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DAL.ListaRegistro("seis");
            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Columns[0].Width = 380;
                    dataGridView1.Columns[1].Width = 80;
                    dataGridView1.Columns[2].Width = 80;
                    dataGridView1.Columns[3].Width = 90;
                    dataGridView1.Columns[4].Width = 500;
                    dataGridView1.Columns[5].Width = 70;
                    dataGridView1.Columns[6].Width = 80;
                    dataGridView1.Columns[7].Width = 50;
                }
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            richTextBox1.Text = "";
        }

        private void tudoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DAL.ListaRegistro("tudo_tudo");
            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Columns[0].Width = 380;
                    dataGridView1.Columns[1].Width = 80;
                    dataGridView1.Columns[2].Width = 80;
                    dataGridView1.Columns[3].Width = 90;
                    dataGridView1.Columns[4].Width = 500;
                    dataGridView1.Columns[5].Width = 70;
                    dataGridView1.Columns[6].Width = 80;
                    dataGridView1.Columns[7].Width = 50;
                }
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            richTextBox1.Text = "";
        }

        private void todosFinalizadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DAL.ListaRegistro("tudo_finalizado");
            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Columns[0].Width = 380;
                    dataGridView1.Columns[1].Width = 80;
                    dataGridView1.Columns[2].Width = 80;
                    dataGridView1.Columns[3].Width = 90;
                    dataGridView1.Columns[4].Width = 500;
                    dataGridView1.Columns[5].Width = 70;
                    dataGridView1.Columns[6].Width = 80;
                    dataGridView1.Columns[7].Width = 50;
                }
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            richTextBox1.Text = "";
        }

        private void todosEmAbertoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DAL.ListaRegistro("tudo_aberto");
            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Columns[0].Width = 380;
                    dataGridView1.Columns[1].Width = 80;
                    dataGridView1.Columns[2].Width = 80;
                    dataGridView1.Columns[3].Width = 90;
                    dataGridView1.Columns[4].Width = 500;
                    dataGridView1.Columns[5].Width = 70;
                    dataGridView1.Columns[6].Width = 80;
                    dataGridView1.Columns[7].Width = 50;
                }
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            richTextBox1.Text = "";
        }

        private void richTextBox1_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox5.Text) == false && String.IsNullOrEmpty(richTextBox1.Text) == false)
            {
                if (textBox6.Text == "aberto")
                {
                    
                    DAL.Atualiza(textBox5.Text, richTextBox1.Text);
                    dataGridView1.DataSource = DAL.ListaRegistro("tudo");
                    if (dataGridView1.Rows.Count > 0)
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                            {
                                if (dataGridView1.Rows[i].Cells[7].Value.ToString() == textBox5.Text)
                                {
                                    dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[7];
                                    
                                }
                            }
                    }
                }
                
                
            }
            
        }

        private void finalizadosToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DAL.ListaRegistro("oito");
            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Columns[0].Width = 380;
                    dataGridView1.Columns[1].Width = 80;
                    dataGridView1.Columns[2].Width = 80;
                    dataGridView1.Columns[3].Width = 90;
                    dataGridView1.Columns[4].Width = 500;
                    dataGridView1.Columns[5].Width = 70;
                    dataGridView1.Columns[6].Width = 80;
                    dataGridView1.Columns[7].Width = 50;
                }
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            richTextBox1.Text = "";
        }

        private void emAndamentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DAL.ListaRegistro("sete");
            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Columns[0].Width = 380;
                    dataGridView1.Columns[1].Width = 80;
                    dataGridView1.Columns[2].Width = 80;
                    dataGridView1.Columns[3].Width = 90;
                    dataGridView1.Columns[4].Width = 500;
                    dataGridView1.Columns[5].Width = 70;
                    dataGridView1.Columns[6].Width = 80;
                    dataGridView1.Columns[7].Width = 50;
                }
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            richTextBox1.Text = "";
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            
            label6.Text = DateTime.Now.Hour.ToString();
            label6.Text += "h:" + DateTime.Now.Minute.ToString();
            label6.Text += "m:" + DateTime.Now.Second.ToString() + "s";
            label7.Text = DateTime.Now.ToLongDateString();

            if (DateTime.Now.Second.ToString() == "0")
            {
                 if (dataGridView2.Rows.Count > 0)
                {
                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        if (dataGridView2.Rows[i].Cells[4].Value.ToString() == DateTime.Now.Hour.ToString() && dataGridView2.Rows[i].Cells[5].Value.ToString() == DateTime.Now.Minute.ToString())
                        {
                            //MessageBox.Show("Favor gerar relatório mensal de vendas e baixar mês anterior.");
                            MessageBox.Show("Compromisso: " + dataGridView2.Rows[i].Cells[0].Value.ToString() + " as " + dataGridView2.Rows[i].Cells[2].Value.ToString() + "Hs e " + dataGridView2.Rows[i].Cells[3].Value.ToString() + "Minutos.",
                               "Alarme!", MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
                        }
                    }
                 }
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                if (String.IsNullOrEmpty(textBox1.Text) == true)
                {
                    MessageBox.Show("Selecione um Cliente");
                    return;
                }

                dataGridView1.DataSource = DAL.Lista("Lista", textBox1.Text);
                if (dataGridView1.Rows.Count > 0)
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        dataGridView1.Columns[0].Width = 380;
                        dataGridView1.Columns[1].Width = 80;
                        dataGridView1.Columns[2].Width = 80;
                        dataGridView1.Columns[3].Width = 90;
                        dataGridView1.Columns[4].Width = 500;
                        dataGridView1.Columns[5].Width = 70;
                        dataGridView1.Columns[6].Width = 80;
                        dataGridView1.Columns[7].Width = 50;
                    }
                }
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                richTextBox1.Text = "";
                progressBar1.Visible = true;
                timer3.Enabled = true;
            }
            if (checkBox1.Checked == true)
            {
                 if (String.IsNullOrEmpty(textBox7.Text) == true)
                {
                    MessageBox.Show("Campos Vazio");
                    return;
                }
                 dataGridView1.DataSource = DAL.ListaCliente3(textBox7.Text);
                 if (dataGridView1.Rows.Count > 0)
                 {
                     for (int i = 0; i < dataGridView1.Rows.Count; i++)
                     {
                         dataGridView1.Columns[0].Width = 380;
                         dataGridView1.Columns[1].Width = 80;
                         dataGridView1.Columns[2].Width = 80;
                         dataGridView1.Columns[3].Width = 90;
                         dataGridView1.Columns[4].Width = 500;
                         dataGridView1.Columns[5].Width = 70;
                         dataGridView1.Columns[6].Width = 80;
                         dataGridView1.Columns[7].Width = 50;
                     }
                 }
                 textBox1.Text = "";
                 textBox2.Text = "";
                 textBox3.Text = "";
                 textBox4.Text = "";
                 textBox5.Text = "";
                 textBox6.Text = "";
                 richTextBox1.Text = "";
                 progressBar1.Visible = true;
                 timer3.Enabled = true;
            }
            
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox5.Text) == false)
            {
                if (textBox6.Text == "aberto")
                {

                    DAL.Atualiza(textBox5.Text, richTextBox1.Text);
                    dataGridView1.DataSource = DAL.ListaRegistro("tudo");
                    if (dataGridView1.Rows.Count > 0)
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            if (dataGridView1.Rows[i].Cells[7].Value.ToString() == textBox5.Text)
                            {
                                dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[7];

                            }
                        }
                    }
                    progressBar1.Visible = true;
                    timer2.Enabled = true;

                }


            }
        }
        int cont2 = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
           
                progressBar1.PerformStep();
                cont2++;
                if (cont2 >=12)
                {
                    cont2 = 0;
                    progressBar1.Value = 0;
                    progressBar1.Visible = false;
                    timer2.Enabled = false;
                }    
            
            
        }
        int cont3 = 0;
        private void timer3_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            cont3++;
            if (cont3 >= 12)
            {
                cont3 = 0;
                progressBar1.Value = 0;
                progressBar1.Visible = false;
                timer3.Enabled = false;
            }    
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Form sen = new Senha();
            sen.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form lem = new Lembrete();
            lem.ShowDialog();
            dataGridView2.DataSource = DAL.ListaLembrte(DateTime.Now.ToShortDateString());

            if (dataGridView2.Rows.Count > 0)
            {
                
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    dataGridView2.Columns[0].Width = 550;
                   
                }
            }
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}
