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
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void Info_Load(object sender, EventArgs e)
        {
            DataTable ti = DAL.ListaSenha();
            richTextBox1.Text = ti.Rows[0]["dados"].ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DAL.Atualiza2("1", richTextBox1.Text);
            progressBar1.Visible = true;
            timer1.Enabled = true;

            DataTable ti = DAL.ListaSenha();
            richTextBox1.Text = ti.Rows[0]["dados"].ToString();

        }
        int cont4 = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            cont4++;
            if (cont4 >= 12)
            {
                cont4 = 0;
                progressBar1.Value = 0;
                progressBar1.Visible = false;
                timer1.Enabled = false;
            }    
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        List<int> found = null;

        private void cb_findAll_Click(object sender, EventArgs e)
        {
            DataTable ti = DAL.ListaSenha();
            richTextBox1.Text = ti.Rows[0]["dados"].ToString();          
             
            int cursorPos = richTextBox1.SelectionStart;
            clearHighlights(richTextBox1);
            found = FindAll(richTextBox1, comboBox1.Text, 0);
            HighlightAll(richTextBox1, Color.Red, found, comboBox1.Text.Length);
            richTextBox1.Select(cursorPos, 0);

            int pos = -1;
            for (int f = 0; f < found.Count; f++)
                if (found[f] > richTextBox1.SelectionStart) { pos = found[f]; break; }
            if (pos >= 0) richTextBox1.Select(pos, comboBox1.Text.Length);
            richTextBox1.ScrollToCaret();
            richTextBox1.Focus();
        }

        private void cb_findNext_Click(object sender, EventArgs e)
        {
            int pos = -1;
            for (int f = 0; f < found.Count; f++)
                if (found[f] > richTextBox1.SelectionStart) { pos = found[f]; break; }
            if (pos >= 0) richTextBox1.Select(pos, comboBox1.Text.Length);
            richTextBox1.ScrollToCaret();
        }

        private void cb_findPrev_Click(object sender, EventArgs e)
        {
            int pos = -1;
            for (int f = 0; f < found.Count; f++)
                if (found[f] >= richTextBox1.SelectionStart) { if (f >= 1) pos = found[f - 1]; break; }
            if (pos >= 0) richTextBox1.Select(pos, comboBox1.Text.Length);
            richTextBox1.ScrollToCaret();
        }

        public List<int> FindAll(RichTextBox rtb, string txtToSearch, int searchStart)
        {
            List<int> found = new List<int>();
            if (txtToSearch.Length <= 0) return found;

            int pos = rtb.Find(txtToSearch, searchStart, RichTextBoxFinds.None);
            while (pos >= 0)
            {
                found.Add(pos);
                pos = rtb.Find(txtToSearch, pos + txtToSearch.Length, RichTextBoxFinds.None);
            }
            return found;
        }

        public void HighlightAll(RichTextBox rtb, Color color, List<int> found, int length)
        {
            foreach (int p in found)
            {
                rtb.Select(p, length);
                rtb.SelectionColor = color;
            }
        }

        void clearHighlights(RichTextBox rtb)
        {
            int cursorPos = rtb.SelectionStart;    // store cursor
            rtb.Select(0, rtb.TextLength);         // select all
            rtb.SelectionColor = rtb.ForeColor;    // default text color
            rtb.Select(cursorPos, 0);              // reset cursor
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            found = new List<int>();         // clear list
            clearHighlights(richTextBox1);            // clear highlights
        }
        private void rtb_TextChanged(object sender, EventArgs e)
        {
            found = new List<int>();
            clearHighlights(richTextBox1);
        }
    }
}
