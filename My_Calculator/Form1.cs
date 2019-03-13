using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Calculator
{
    public partial class win_cal : Form
    {
        double m = 0;
        double value = 0;
        string mathOparation = "";
        bool opration_pressed = false;
        string sm = null;
        int mrCount = 0;

        SpecialOparation sop = new SpecialOparation();


        public win_cal()
        {
            InitializeComponent();
        }

        private void win_cal_Load(object sender, EventArgs e)
        {
            button22.Enabled = false;
            button23.Enabled = false;
            generalToolStripMenuItem.Enabled = false;
            this.Height = 320;
            this.Width = 350;
        }//Windows Load

        private void nb_add(object sender, EventArgs e)
        {
            if (result.Text == "0" || opration_pressed)
            {
                result.Clear();
            }
            if (result.Text != null)
            {
                result.SelectedText = null;
            }
            Button b = (Button)sender;
            opration_pressed = false;
            if (b.Text == ".")
            {
                if (!result.Text.Contains("."))
                    result.Text = result.Text + b.Text;
            }
            else
                result.Text = result.Text + b.Text;
            show.Focus();
        }//Number/Data Adding

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }//exit button

        private void oparation_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (sop.spOparationPressed)
            {
                sop.secondValue = int.Parse(result.Text);
                value = sop.Oparation();
                result.Text = value.ToString();
                equal.PerformClick();
                mathOparation = b.Text;
                opration_pressed = true;

                show.Text = result.Text + " " + mathOparation;
                sm = show.Text;
            }
            else if (value != 0)
            {
                equal.PerformClick();
                mathOparation = b.Text;
                opration_pressed = true;

                show.Text = result.Text + " " + mathOparation;
                sm = show.Text;
            }
            else
            {
                mathOparation = b.Text;
                opration_pressed = true;

                show.Text = result.Text + " " + mathOparation;
                sm = show.Text;

                value = double.Parse(result.Text);
            }
            MathOparation.MainValue = value;
            show.Focus();
        }//Oparation button click

        private void calculate(object sender, EventArgs e)
        {
            show.Text = "";

            if (sop.spOparationPressed)
            {
                sop.secondValue = double.Parse(result.Text);
                value = sop.Oparation();
                result.Text = value.ToString();
            }

            if (sm == null)
            {
                sm = sop.show;
                show.Text = sm + "=";
            }else
            show.Text = sm + " " + result.Text + " =";
            sm = null;

            opration_pressed = true;
            switch (mathOparation)
            {
                case "+":
                    result.Text = MathOparation.Add(double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = MathOparation.Sub(double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = MathOparation.Multi(double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = MathOparation.Div(double.Parse(result.Text)).ToString();
                    break;
                default :
                    break;
            }

            value = double.Parse(result.Text);
            mathOparation = "";
            show.Focus();
        }//= Button click/ calculating 

        private void cClick(object sender, EventArgs e)
        {
            result.Text = "0";
            show.Text = "";
            mathOparation = "";
            opration_pressed = false;
            value = 0;
            show.Focus();
        }//clear text

        private void ceClick(object sender, EventArgs e)
        {
            result.Text = "";
            show.Focus();
        }//clean data

        private void button14_Click(object sender, EventArgs e)
        {
            m = m + double.Parse(result.Text);
            opration_pressed = true;
            mrCount += 1;
            button22.Enabled = true;
            button23.Enabled = true;
            show.Focus();
        }//M+ button click

        private void button21_Click(object sender, EventArgs e)
        {
            m = m - double.Parse(result.Text);
            mrCount -= 1;
            opration_pressed = true;
            button22.Enabled = true;
            button23.Enabled = true;
            show.Focus();
        }//M- button click

        private void button22_Click(object sender, EventArgs e)
        {
            result.Text = m.ToString();
            opration_pressed = true;
            show.Focus();
        }//show M memory data

        private void button23_Click(object sender, EventArgs e)
        {
            m = 0;
            mrCount = 0;
            opration_pressed = true;
            button22.Enabled = false;
            button23.Enabled = false;
            show.Focus();
        }//clear memory data

        private void aboutAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab1 = new AboutBox1();
            ab1.ShowDialog(this);
        }//about app Dialog

        private void aboutMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about_me am = new about_me();
            am.ShowDialog(this);
      
        }//about me Dialog

        private void advancedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Height = 500;
            generalToolStripMenuItem.Enabled = true;
            advancedToolStripMenuItem.Enabled = false;
        }//show advanced button

        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Height = 320;
            generalToolStripMenuItem.Enabled = false;
            advancedToolStripMenuItem.Enabled = true;
        }//show general button

        private void win_cal_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Key Press
            
            switch (e.KeyChar.ToString())
            {
                case "1":
                    one.PerformClick();
                    break;
                case "2":
                    two.PerformClick();
                    break;
                case "3":
                    three.PerformClick();
                    break;
                case "4":
                    four.PerformClick();
                    break;
                case "5":
                    five.PerformClick();
                    break;
                case "6":
                    six.PerformClick();
                    break;
                case "7":
                    seven.PerformClick();
                    break;
                case "8":
                    eight.PerformClick();
                    break;
                case "9":
                    nine.PerformClick();
                    break;
                case "0":
                    zero.PerformClick();
                    break;
                case "+":
                    add.PerformClick();
                    break;
                case "-":
                    sub.PerformClick();
                    break;
                case "*":
                    mul.PerformClick();
                    break;
                case "/":
                    div.PerformClick();
                    break;
                case "=":
                    equal.PerformClick();
                    break;
                case "\r":
                    equal.PerformClick();
                    break;
                default:
                    break;
            }
        }//Working With Key Press

        private void speacialOparator_Click(object sender, EventArgs e)
        {
            opration_pressed = true;
            Button b = (Button)sender;
            string bn = b.Text;
            value = sop.StartOparation(bn, double.Parse(result.Text));
            result.Text = value.ToString();
            show.Text = sop.show;
            show.Focus();
        }

        private void avg_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(this,"Make Sure of Using Memory(M+)","Tips",MessageBoxButtons.YesNo);
            if (r.ToString().Equals("Yes"))
            {
                show.Text = "Total: " + m + " Data Length: " + mrCount;
                result.Text = (m / mrCount).ToString();
            }
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://shbsovon.blogspot.com/");
        }
    }
}
