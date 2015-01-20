using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIS_Lab_4_6205
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            map1.AddLayer();
        }

        private void usuńWszystkieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            map1.Layers.Clear();
        }

        private void przybliżToolStripMenuItem_Click(object sender, EventArgs e)
        {
            map1.ZoomIn();
        }

        private void oddalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            map1.ZoomOut();
        }

        private void pokażCałośćToolStripMenuItem_Click(object sender, EventArgs e)
        {
            map1.ZoomToMaxExtent();
        }
    }
}
