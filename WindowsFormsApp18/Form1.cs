using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            switch (button.Text)
            {
                case "button1": panel1.Visible = false;
                    panel2.Visible=false;
                    panel3.Visible = false; break;
                case "button2": panel1.Visible = true;
                    panel2.Visible = false;
                    panel3.Visible = false;
                    break;
                case "button3": panel2.Visible = true;;
                    panel3.Visible = false;
                    break;
                case "button4": panel3.Visible = true;
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
        }
    }
}
