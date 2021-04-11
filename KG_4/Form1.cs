using KG_4.Algorithms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KG_4
{
    public partial class Form1 : Form
    {
        private Dictionary<int, IAlgorithm> algorithms = new Dictionary<int, IAlgorithm>()
        {
            { 0, new CDA() },
            { 1, new Brezenkhem() },
            { 2, new BrezenkhemCircle() },
            { 3, new StepByStep() }
        };

        private IAlgorithm algorithm = new CDA();

        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox.CreateGraphics();

            for (int i = 1; i < 49; i++)
            {
                g.DrawLine(
                    Pens.Black,
                    i * 10,
                    0,
                    i * 10,
                    500);
                g.DrawLine(
                    Pens.Black,
                    0,
                    i * 10,
                    500,
                    i * 10);
            }

            List<Point> points = algorithm.Invoke(
                (int)x1Selector.Value,
                (int)y1Selector.Value,
                (int)x2Selector.Value,
                (int)y2Selector.Value);

            StringBuilder sb = new StringBuilder();

            foreach (var point in points)
            {
                g.FillRectangle(Brushes.Red, point.X * 10, point.Y * 10, 10, 10);
                sb.Append($"({point.X}; {point.Y})\n");
            }

            pointsInfo.Text = sb.ToString();

            g.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox.CreateGraphics();

            g.FillRectangle(Brushes.White, 0, 0, 550, 550);

            for (int i = 1; i < 49; i++)
            {
                g.DrawLine(
                    Pens.Black,
                    i * 10,
                    0,
                    i * 10,
                    500);
                g.DrawLine(
                    Pens.Black,
                    0,
                    i * 10,
                    500,
                    i * 10);
            }

            pointsInfo.Text = String.Empty;

            g.Dispose();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBox1.Items.Count; ++ix)
                if (ix != e.Index) checkedListBox1.SetItemChecked(ix, false);

            algorithm = algorithms[e.Index];
        }
    }
}
    