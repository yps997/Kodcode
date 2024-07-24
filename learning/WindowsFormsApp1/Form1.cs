using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void enter_Click(object sender, EventArgs e)
        {
            int x = 2;
            int y = 6;
            string s = "yair";
            float f = 1.4f;
            Console.WriteLine((s+y+f).GetType());
            Console.WriteLine((y+x).GetType());
            Console.WriteLine((x+f).GetType());
            Console.WriteLine((f+x).GetType());
            Console.WriteLine((s + y + f).GetType());
            Console.WriteLine(y + x);
            Console.WriteLine(x + f);
            Console.WriteLine(f + x);


        }
    }
}

