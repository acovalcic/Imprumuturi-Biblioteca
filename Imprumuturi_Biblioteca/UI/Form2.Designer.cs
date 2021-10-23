using System.Windows.Forms;

namespace Imprumuturi_Biblioteca
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salveazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deschidereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manipulareDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printareCapturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.DVPprintPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.DVPprintDocument1 = new System.Drawing.Printing.PrintDocument();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salveazaToolStripMenuItem,
            this.manipulareDateToolStripMenuItem,
            this.printareToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(415, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salveazaToolStripMenuItem
            // 
            this.salveazaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deschidereToolStripMenuItem,
            this.salvareToolStripMenuItem});
            this.salveazaToolStripMenuItem.Name = "salveazaToolStripMenuItem";
            this.salveazaToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.salveazaToolStripMenuItem.Text = "Operatiuni Fisier";
            // 
            // deschidereToolStripMenuItem
            // 
            this.deschidereToolStripMenuItem.Name = "deschidereToolStripMenuItem";
            this.deschidereToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.deschidereToolStripMenuItem.Text = "Deschidere";
            this.deschidereToolStripMenuItem.Click += new System.EventHandler(this.deschidereToolStripMenuItem_Click);
            // 
            // salvareToolStripMenuItem
            // 
            this.salvareToolStripMenuItem.Name = "salvareToolStripMenuItem";
            this.salvareToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.salvareToolStripMenuItem.Text = "Salvare";
            this.salvareToolStripMenuItem.Click += new System.EventHandler(this.salvareToolStripMenuItem_Click);
            // 
            // manipulareDateToolStripMenuItem
            // 
            this.manipulareDateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaToolStripMenuItem,
            this.stergeToolStripMenuItem});
            this.manipulareDateToolStripMenuItem.Name = "manipulareDateToolStripMenuItem";
            this.manipulareDateToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.manipulareDateToolStripMenuItem.Text = "Manipulare Date";
            // 
            // adaugaToolStripMenuItem
            // 
            this.adaugaToolStripMenuItem.Name = "adaugaToolStripMenuItem";
            this.adaugaToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.adaugaToolStripMenuItem.Text = "Adauga";
            this.adaugaToolStripMenuItem.Click += new System.EventHandler(this.adaugaToolStripMenuItem_Click);
            // 
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.stergeToolStripMenuItem.Text = "Sterge";
            this.stergeToolStripMenuItem.Click += new System.EventHandler(this.stergeToolStripMenuItem_Click);
            // 
            // printareToolStripMenuItem
            // 
            this.printareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printareCapturaToolStripMenuItem});
            this.printareToolStripMenuItem.Name = "printareToolStripMenuItem";
            this.printareToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.printareToolStripMenuItem.Text = "Print";
            // 
            // printareCapturaToolStripMenuItem
            // 
            this.printareCapturaToolStripMenuItem.Name = "printareCapturaToolStripMenuItem";
            this.printareCapturaToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.printareCapturaToolStripMenuItem.Text = "Printare";
            this.printareCapturaToolStripMenuItem.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 24);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(415, 443);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Cod Carte";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Titlu";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Autor";
            this.columnHeader3.Width = 150;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // DVPprintPreviewDialog1
            // 
            this.DVPprintPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.DVPprintPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.DVPprintPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.DVPprintPreviewDialog1.Enabled = true;
            this.DVPprintPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("DVPprintPreviewDialog1.Icon")));
            this.DVPprintPreviewDialog1.Name = "DVPprintPreviewDialog1";
            this.DVPprintPreviewDialog1.Visible = false;
            // 
            // DVPprintDocument1
            // 
            this.DVPprintDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.DVPprintDocument1_PrintPage);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(566, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 52);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(635, 318);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 52);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_click);
            // 
            // printDialog1
            // 
            this.printDialog1.AllowCurrentPage = true;
            this.printDialog1.AllowSelection = true;
            this.printDialog1.UseEXDialog = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "bmp";
            this.saveFileDialog1.FileName = "image";
            this.saveFileDialog1.Filter = "BMP|*.bmp|PNG|*.png";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 467);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lista Carti";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salveazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deschidereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manipulareDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ToolStripMenuItem printareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printareCapturaToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private PrintPreviewDialog DVPprintPreviewDialog1;
        private System.Drawing.Printing.PrintDocument DVPprintDocument1;
        private Button button2;
        private Button button3;
        private PrintDialog printDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}