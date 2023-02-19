using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HiddenScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(640, 480);
            this.ControlBox = false;
            this.Text = "";
        }

        private Point mousePoint;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                mousePoint = new Point(e.X, e.Y);
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                this.Left += e.X - mousePoint.X;
                this.Top += e.Y - mousePoint.Y;
            }
        }

        private void 背景色BToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();

            cd.Color = this.BackColor;
            cd.AllowFullOpen = true;
            cd.SolidColorOnly = false;

            if (cd.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = cd.Color;
            }
        }

        private void 最大化MToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void 元のサイズに戻すRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void 最前面に表示TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            this.TopMost = !this.TopMost;
            item.Checked = !item.Checked;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void 閉じるCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 変更CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "画像ファイル(*.png;*.jpg;*.gif;*.bmp)|*.png;*.jpg;*.gif;*.bmp";
            ofd.Title = "背景の選択";
            ofd.RestoreDirectory = true;
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.BackgroundImage = System.Drawing.Image.FromFile(ofd.FileName);
            }
        }

        private void 削除DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
        }

        private void バージョン情報AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog(this);
            f.Dispose();
        }
    }
}
