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

namespace Imprumuturi_Biblioteca
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            string path = "imprumuturi.txt";
            StreamReader stream = new StreamReader(path);
            string pairs;
            while ((pairs = stream.ReadLine()) != null)
            {
                string[] pair = pairs.Split(',');
                ListViewItem itm = new ListViewItem(pair[0]);
                itm.SubItems.Add(pair[1]);
                itm.SubItems.Add(pair[2]);
                itm.SubItems.Add(pair[3]);
                itm.SubItems.Add(pair[4]);
                listView1.Items.Add(itm);
            }
            stream.Close();
        }


        private void salveazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void salvareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "text|*.txt", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                    {
                        foreach (ListViewItem item in listView1.Items)
                        {
                            tw.WriteLineAsync(item.SubItems[0].Text + "," + item.SubItems[1].Text + "," + item.SubItems[2].Text + "," + item.SubItems[3].Text + "," + item.SubItems[4].Text + ",");
                        }
                        MessageBox.Show("Salvat cu succes!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void deschidereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in listView1.Items)
                itm.Remove();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "";
            ofd.Filter = "Text|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofd.FileName);
                string pairs;
                while ((pairs = sr.ReadLine()) != null)
                {
                    string[] pair = pairs.Split(',');
                    ListViewItem itm = new ListViewItem(pair[0]);
                    itm.SubItems.Add(pair[1]);
                    itm.SubItems.Add(pair[2]);
                    itm.SubItems.Add(pair[3]);
                    itm.SubItems.Add(pair[4]);
                    listView1.Items.Add(itm);
                }
                sr.Close();
            }
        }

        private void adaugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Text = "Adauga Imprumut";
            f7.button1.Text = "Adauga";
            if (DialogResult.OK == f7.ShowDialog())
            {
                if (f7.textBox1.Text.Length > 0 && f7.textBox2.Text.Length > 0 && f7.textBox3.Text.Length > 0 && f7.textBox4.Text.Length > 0)
                {
                    listView1.Items.Add((listView1.Items.Count + 1).ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(f7.textBox1.Text);
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(f7.textBox2.Text);
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(f7.textBox3.Text);
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(f7.textBox4.Text);
                }
                else
                {
                    MessageBox.Show("Nu ati introdus datele imprumutului!\nReincercati");
                }
            }
        }

        private void modificaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Text = "Modifica Imprumut";
            f7.button1.Text = "Modifica";
            ListView.SelectedListViewItemCollection cels = listView1.SelectedItems;
            if (cels.Count == 0) MessageBox.Show("Nu ati selectat nimic!");
            else
            {
                f7.textBox1.Text = cels[0].SubItems[1].Text;
                f7.textBox2.Text = cels[0].SubItems[2].Text;
                f7.textBox3.Text = cels[0].SubItems[3].Text;
                f7.textBox4.Text = cels[0].SubItems[4].Text;
                if (DialogResult.OK == f7.ShowDialog())
                {
                    if (f7.textBox1.Text.Length > 0 && f7.textBox2.Text.Length > 0 && f7.textBox3.Text.Length > 0 && f7.textBox4.Text.Length > 0)
                    {
                        cels[0].SubItems[1].Text = f7.textBox1.Text;
                        cels[0].SubItems[2].Text = f7.textBox2.Text;
                        cels[0].SubItems[3].Text = f7.textBox3.Text;
                        cels[0].SubItems[4].Text = f7.textBox4.Text;
                    }
                    else
                    {
                        MessageBox.Show("Nu ati introdus toate datele imprumutului modificat!\nModificare esuata");
                    }
                }
            }
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection cels = listView1.SelectedItems;
            if (cels.Count == 0) MessageBox.Show("Nu ati selectat nimic!");
            else
            {
                listView1.Items.Remove(cels[0]);
            }
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Asigurati-va ca ati salvat fisierul aferent acestei sesiuni.\nAcesta nu este salvat automat!\nDoriti sa iesiti?", "Confirmare iesire", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Hide();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
