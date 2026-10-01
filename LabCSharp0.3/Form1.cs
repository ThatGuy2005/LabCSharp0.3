using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LabCSharp0._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.MouseHover += new EventHandler(button2_MouseHover);
            button1.MouseHover += new EventHandler(button1_MouseHover);
            button3.MouseHover += new EventHandler(button3_MouseHover);
            button4.MouseHover += new EventHandler(button4_MouseHover);
        }
        private void button2_MouseHover(object sender, EventArgs e)
        {
            this.Location = new Point(this.Location.X, this.Location.Y - 10);
        }
        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.Location = new Point(this.Location.X + 10, this.Location.Y);
        }
        private void button3_MouseHover(object sender, EventArgs e)
        {
            this.Location = new Point(this.Location.X - 10, this.Location.Y);
        }
        private void button4_MouseHover(object sender, EventArgs e)
        {
            this.Location = new Point(this.Location.X, this.Location.Y + 10);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
