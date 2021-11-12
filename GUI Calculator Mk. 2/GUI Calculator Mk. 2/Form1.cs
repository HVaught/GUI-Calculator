using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Calculator_Mk._2
{
    public partial class Form1 : Form
    {
        Solver s = new Solver();
        public Form1()
        {
            InitializeComponent();
            string newLine = Environment.NewLine;
            display.Font = new Font("Arial", 18, FontStyle.Bold);
            display.Text = newLine + "-----------------";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            s.Accumulate("+");
            display.Text = s.getTop() + Environment.NewLine + "-----------------";
        }

        private void oneBut_Click(object sender, EventArgs e)
        {
            s.Accumulate("1");
            display.Text = s.getTop() + Environment.NewLine + "-----------------";
        }

        private void twoBut_Click(object sender, EventArgs e)
        {
            s.Accumulate("2");
            display.Text = s.getTop() + Environment.NewLine + "-----------------";
        }

        private void threeBut_Click(object sender, EventArgs e)
        {
            s.Accumulate("3");
            display.Text = s.getTop() + Environment.NewLine + "-----------------";
        }

        private void fourBut_Click(object sender, EventArgs e)
        {
            s.Accumulate("4");
            display.Text = s.getTop() + Environment.NewLine + "-----------------";
        }

        private void fiveBut_Click(object sender, EventArgs e)
        {
            s.Accumulate("5");
            display.Text = s.getTop() + Environment.NewLine + "-----------------";
        }

        private void sixBut_Click(object sender, EventArgs e)
        {
            s.Accumulate("6");
            display.Text = s.getTop() + Environment.NewLine + "-----------------";
        }

        private void sevenBut_Click(object sender, EventArgs e)
        {
            s.Accumulate("7");
            display.Text = s.getTop() + Environment.NewLine + "-----------------";
        }

        private void eightBut_Click(object sender, EventArgs e)
        {
            s.Accumulate("8");
            display.Text = s.getTop() + Environment.NewLine + "-----------------";
        }

        private void nineBut_Click(object sender, EventArgs e)
        {
            s.Accumulate("9");
            display.Text = s.getTop() + Environment.NewLine + "-----------------";
        }

        private void zeroBut_Click(object sender, EventArgs e)
        {
            s.Accumulate("0");
            display.Text = s.getTop() + Environment.NewLine + "-----------------";
        }

        private void dotBut_Click(object sender, EventArgs e)
        {
            s.Accumulate(".");
            display.Text = s.getTop() + Environment.NewLine + "-----------------";
        }

        private void acBut_Click(object sender, EventArgs e)
        {
            s.Clear();
            display.Text = Environment.NewLine + "-----------------";
        }

        private void polarityBut_Click(object sender, EventArgs e)
        {
            s.Accumulate("-");
            display.Text = s.getTop() + Environment.NewLine + "-----------------";
        }

        private void percentBut_Click(object sender, EventArgs e)
        {
            s.Accumulate("%");
            display.Text = s.getTop() + Environment.NewLine + "-----------------";
        }

        private void divideBut_Click(object sender, EventArgs e)
        {
            s.Accumulate("/");
            display.Text = s.getTop() + Environment.NewLine + "-----------------";
        }

        private void minusBut_Click(object sender, EventArgs e)
        {
            s.Accumulate("-");
            display.Text = s.getTop() + Environment.NewLine + "-----------------";
        }

        private void timesBut_Click(object sender, EventArgs e)
        {
            s.Accumulate("*");
            display.Text = s.getTop() + Environment.NewLine + "-----------------";
        }

        private void equalBut_Click(object sender, EventArgs e)
        {
            display.Text = s.getTop() + Environment.NewLine + "-----------------"
                + Environment.NewLine + s.Solve(s.getTop());
        }
    }
}
