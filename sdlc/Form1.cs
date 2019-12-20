using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sdlc
{
    public partial class Form1 : Form
    {
        private object close;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Login your account");
            this.Height = this.Height;
            this.Width = this.Width;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Pink;
            string msg = "";
            msg = msg + "Backgroud color Form:" + this.BackColor.ToString() + "\n";
            msg = msg + "Button click:" + label4.Text;
            Text = msg;
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 registration = new Form2();
            
                registration.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 registration = new Form3();

            registration.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to exit ?",
                "Error", MessageBoxButtons.YesNoCancel);
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightYellow;
            string msg = "";
            msg = msg + "Backgroud color Form:" + this.BackColor.ToString() + "\n";
            msg = msg + "Button click:" + label3.Text;
            Text = msg;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        
        }
    }
}
