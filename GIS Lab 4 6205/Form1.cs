using DotSpatial.Controls;
using DotSpatial.Topology;
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
        bool moving = false;
        double x, y;

        public Form1()
        {
            InitializeComponent();
        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            map1.AddLayer();

            //if (map1.Layers.Count > 0)
            //{
            //    DataTable dt;
            //    MapPolygonLayer stateLayer = default(MapPolygonLayer);

            //    stateLayer = (MapPolygonLayer)map1.Layers[0];

            //    if (stateLayer == null)
            //    {
            //        MessageBox.Show("The layer is not a polygon layer.");
            //    }
            //    else
            //    {
            //        //Get the shapefile's attribute table to our datatable dt
            //        dt = stateLayer.DataSet.DataTable;
            //        //Set the datagridview datasource from datatable dt
            //        dataGridView1.DataSource = dt;
            //    }
            //}
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

        private void map1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                moving = true;
                x = e.X;
                y = e.Y;
            }
        }

        private void map1_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
        }

        private void map1_MouseMove(object sender, MouseEventArgs e)
        {
            if(moving)
            {
                map1.ViewExtents.SetCenter(new Coordinate(map1.ViewExtents.Center.X - (x - e.X)/100, map1.ViewExtents.Center.Y - (y - e.Y)/100));
                map1.Refresh();
                x = e.X;
                y = e.Y;
            }
        }

        private void daneWarstwyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IMapLayer layer = map1.Layers.SelectedLayer;
            DataTable dt;
            
            if(layer != null)
            {
                if(layer is IMapPolygonLayer)
                {
                    dt = (layer as IMapPolygonLayer).DataSet.DataTable;
                    dataGridView1.DataSource = dt;
                }
                else if(layer is IMapLineLayer)
                {
                    dt = (layer as IMapLineLayer).DataSet.DataTable;
                    dataGridView1.DataSource = dt;
                }
                else if(layer is IMapPointLayer)
                {
                    dt = (layer as IMapPointLayer).DataSet.DataTable;
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void wGóreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IMapLayer layer = map1.Layers.SelectedLayer;
            IMapLayer tmp;
            int index;

            if(layer != null)
            {
                index = map1.Layers.IndexOf(layer);
                if (index < (map1.Layers.Count - 1))
                {
                    tmp = map1.Layers[index + 1];
                    map1.Layers[index + 1] = layer;
                    map1.Layers[index] = tmp;
                    legend1.Refresh();
                }
            }
        }

        private void wDółToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IMapLayer layer = map1.Layers.SelectedLayer;
            IMapLayer tmp;
            int index;

            if (layer != null)
            {
                index = map1.Layers.IndexOf(layer);
                if (index > 0)
                {
                    tmp = map1.Layers[index - 1];
                    map1.Layers[index] = tmp;
                    map1.Layers[index - 1] = layer;
                    legend1.Refresh();
                }
            }
        }
    }
}
