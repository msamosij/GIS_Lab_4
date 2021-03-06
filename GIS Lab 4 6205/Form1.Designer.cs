﻿namespace GIS_Lab_4_6205
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńWszystkieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.widokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.przybliżToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oddalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pokażCałośćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.legend1 = new DotSpatial.Controls.Legend();
            this.map1 = new DotSpatial.Controls.Map();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.spatialToolStrip1 = new DotSpatial.Controls.SpatialToolStrip();
            this.daneWarstwyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.przesuńWarstweToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wGóreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wDółToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu,
            this.widokToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(847, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu
            // 
            this.Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajToolStripMenuItem,
            this.usuńWszystkieToolStripMenuItem,
            this.daneWarstwyToolStripMenuItem});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(64, 20);
            this.Menu.Text = "Warstwa";
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.dodajToolStripMenuItem.Text = "Dodaj";
            this.dodajToolStripMenuItem.Click += new System.EventHandler(this.dodajToolStripMenuItem_Click);
            // 
            // usuńWszystkieToolStripMenuItem
            // 
            this.usuńWszystkieToolStripMenuItem.Name = "usuńWszystkieToolStripMenuItem";
            this.usuńWszystkieToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.usuńWszystkieToolStripMenuItem.Text = "Usuń wszystkie";
            this.usuńWszystkieToolStripMenuItem.Click += new System.EventHandler(this.usuńWszystkieToolStripMenuItem_Click);
            // 
            // widokToolStripMenuItem
            // 
            this.widokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.przybliżToolStripMenuItem,
            this.oddalToolStripMenuItem,
            this.pokażCałośćToolStripMenuItem,
            this.przesuńWarstweToolStripMenuItem});
            this.widokToolStripMenuItem.Name = "widokToolStripMenuItem";
            this.widokToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.widokToolStripMenuItem.Text = "Widok";
            // 
            // przybliżToolStripMenuItem
            // 
            this.przybliżToolStripMenuItem.Name = "przybliżToolStripMenuItem";
            this.przybliżToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.przybliżToolStripMenuItem.Text = "Przybliż";
            this.przybliżToolStripMenuItem.Click += new System.EventHandler(this.przybliżToolStripMenuItem_Click);
            // 
            // oddalToolStripMenuItem
            // 
            this.oddalToolStripMenuItem.Name = "oddalToolStripMenuItem";
            this.oddalToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.oddalToolStripMenuItem.Text = "Oddal";
            this.oddalToolStripMenuItem.Click += new System.EventHandler(this.oddalToolStripMenuItem_Click);
            // 
            // pokażCałośćToolStripMenuItem
            // 
            this.pokażCałośćToolStripMenuItem.Name = "pokażCałośćToolStripMenuItem";
            this.pokażCałośćToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.pokażCałośćToolStripMenuItem.Text = "Pokaż całość";
            this.pokażCałośćToolStripMenuItem.Click += new System.EventHandler(this.pokażCałośćToolStripMenuItem_Click);
            // 
            // legend1
            // 
            this.legend1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.legend1.BackColor = System.Drawing.Color.White;
            this.legend1.ControlRectangle = new System.Drawing.Rectangle(0, 0, 187, 428);
            this.legend1.DocumentRectangle = new System.Drawing.Rectangle(0, 0, 187, 428);
            this.legend1.HorizontalScrollEnabled = true;
            this.legend1.Indentation = 30;
            this.legend1.IsInitialized = false;
            this.legend1.Location = new System.Drawing.Point(12, 52);
            this.legend1.MinimumSize = new System.Drawing.Size(5, 5);
            this.legend1.Name = "legend1";
            this.legend1.ProgressHandler = null;
            this.legend1.ResetOnResize = false;
            this.legend1.SelectionFontColor = System.Drawing.Color.Black;
            this.legend1.SelectionHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.legend1.Size = new System.Drawing.Size(187, 428);
            this.legend1.TabIndex = 1;
            this.legend1.Text = "legend1";
            this.legend1.VerticalScrollEnabled = true;
            // 
            // map1
            // 
            this.map1.AllowDrop = true;
            this.map1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.map1.BackColor = System.Drawing.Color.White;
            this.map1.CollectAfterDraw = false;
            this.map1.CollisionDetection = false;
            this.map1.ExtendBuffer = false;
            this.map1.FunctionMode = DotSpatial.Controls.FunctionMode.None;
            this.map1.IsBusy = false;
            this.map1.IsZoomedToMaxExtent = false;
            this.map1.Legend = this.legend1;
            this.map1.Location = new System.Drawing.Point(205, 52);
            this.map1.Name = "map1";
            this.map1.ProgressHandler = null;
            this.map1.ProjectionModeDefine = DotSpatial.Controls.ActionMode.Prompt;
            this.map1.ProjectionModeReproject = DotSpatial.Controls.ActionMode.Prompt;
            this.map1.RedrawLayersWhileResizing = false;
            this.map1.SelectionEnabled = true;
            this.map1.Size = new System.Drawing.Size(630, 428);
            this.map1.TabIndex = 2;
            this.map1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.map1_MouseDown);
            this.map1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.map1_MouseMove);
            this.map1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.map1_MouseUp);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 486);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(823, 158);
            this.dataGridView1.TabIndex = 3;
            // 
            // spatialToolStrip1
            // 
            this.spatialToolStrip1.ApplicationManager = null;
            this.spatialToolStrip1.Location = new System.Drawing.Point(0, 24);
            this.spatialToolStrip1.Map = this.map1;
            this.spatialToolStrip1.Name = "spatialToolStrip1";
            this.spatialToolStrip1.Size = new System.Drawing.Size(847, 25);
            this.spatialToolStrip1.TabIndex = 4;
            this.spatialToolStrip1.Text = "spatialToolStrip1";
            // 
            // daneWarstwyToolStripMenuItem
            // 
            this.daneWarstwyToolStripMenuItem.Name = "daneWarstwyToolStripMenuItem";
            this.daneWarstwyToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.daneWarstwyToolStripMenuItem.Text = "Dane Warstwy";
            this.daneWarstwyToolStripMenuItem.Click += new System.EventHandler(this.daneWarstwyToolStripMenuItem_Click);
            // 
            // przesuńWarstweToolStripMenuItem
            // 
            this.przesuńWarstweToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wGóreToolStripMenuItem,
            this.wDółToolStripMenuItem});
            this.przesuńWarstweToolStripMenuItem.Name = "przesuńWarstweToolStripMenuItem";
            this.przesuńWarstweToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.przesuńWarstweToolStripMenuItem.Text = "Przesuń Warstwe";
            // 
            // wGóreToolStripMenuItem
            // 
            this.wGóreToolStripMenuItem.Name = "wGóreToolStripMenuItem";
            this.wGóreToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.wGóreToolStripMenuItem.Text = "W góre";
            this.wGóreToolStripMenuItem.Click += new System.EventHandler(this.wGóreToolStripMenuItem_Click);
            // 
            // wDółToolStripMenuItem
            // 
            this.wDółToolStripMenuItem.Name = "wDółToolStripMenuItem";
            this.wDółToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.wDółToolStripMenuItem.Text = "W dół";
            this.wDółToolStripMenuItem.Click += new System.EventHandler(this.wDółToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 656);
            this.Controls.Add(this.spatialToolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.map1);
            this.Controls.Add(this.legend1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "6205";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuńWszystkieToolStripMenuItem;
        private DotSpatial.Controls.Legend legend1;
        private DotSpatial.Controls.Map map1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DotSpatial.Controls.SpatialToolStrip spatialToolStrip1;
        private System.Windows.Forms.ToolStripMenuItem widokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem przybliżToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem oddalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pokażCałośćToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem daneWarstwyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem przesuńWarstweToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wGóreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wDółToolStripMenuItem;

    }
}

