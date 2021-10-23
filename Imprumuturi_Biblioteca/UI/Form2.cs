using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imprumuturi_Biblioteca
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            string path = "carti.txt";
            StreamReader stream = new StreamReader(path);
            string pairs;
            while ((pairs = stream.ReadLine()) != null)
            {
                string[] pair = pairs.Split(',');
                ListViewItem itm = new ListViewItem(pair[0]);
                itm.SubItems.Add(pair[1]);
                itm.SubItems.Add(pair[2]);
                listView1.Items.Add(itm);
            }
            stream.Close();
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
                    listView1.Items.Add(itm);
                }
                sr.Close();
            }
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
                            tw.WriteLineAsync(item.SubItems[0].Text + "," + item.SubItems[1].Text + "," + item.SubItems[2].Text + ",");
                        }
                        MessageBox.Show("Salvat cu succes!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void adaugaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form5 f5 = new Form5();
            f5.Text = "Adauga Carte";
            f5.button1.Text = "Adauga";
            if (DialogResult.OK == f5.ShowDialog())
            {
                if (f5.textBox2.Text.Length > 0 && f5.textBox3.Text.Length > 0)
                {
                    listView1.Items.Add((listView1.Items.Count + 1).ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(f5.textBox2.Text);
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(f5.textBox3.Text);
                }
                else
                {
                MessageBox.Show("Nu ati introdus titlul si autorul cartii!\nNu am adaugat nimic");
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

        ImageFormat img;
        Bitmap bt;
        Graphics screenShot;
        private void button3_click(object sender, EventArgs e)
        {
            //if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    this.Hide();
            //    Thread.Sleep(500);
            //    bt = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);
            //    screenShot = Graphics.FromImage(bt);
            //    screenShot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);
            //    switch (saveFileDialog1.FilterIndex)
            //    {
            //        case 0: img = ImageFormat.Bmp; break;
            //        case 1: img = ImageFormat.Png; break;
            //    }
            //    bt.Save(saveFileDialog1.FileName, img);
            //}
        }
        Bitmap bitmap;
        private void button2_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics grp = panel.CreateGraphics();
            Size formSize = this.ClientSize;
            bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
            grp = Graphics.FromImage(bitmap);
            Point panelLocation = PointToScreen(panel.Location);
            grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);
            DVPprintPreviewDialog1.Document = DVPprintDocument1;
            DVPprintPreviewDialog1.PrintPreviewControl.Zoom = 1;
            DVPprintPreviewDialog1.ShowDialog();
        }
        private void DVPprintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
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
