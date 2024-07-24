using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int[] numbers = { 1, 2, 3, 4, 5, 2, 43, 45, 6, 7, 5, 4, 3, 35, 5, 7, 8, 9, 65, 4, 32, 2 };
        public Form1()
        {

            InitializeComponent();
        }


        private void validateAge_Click(object sender, EventArgs e)
        {
            Array.Find(numbers, num => num == num % 2);
            reversArray(numbers);
            Console.WriteLine();
        }

        private void txtbox_TextChanged(object sender, EventArgs e)
        {

        }
        private void reversArray (int[] numbers)
        {
            Array.Reverse(numbers);
            Array.ForEach (numbers, Console.WriteLine);
        }
    }
}
