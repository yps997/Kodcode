using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace learning
{
    public partial class Form1 : Form
    { 
        int x = 0;
        private Dog[] dogs = new Dog[4];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] ages = new int[10];
            ages[0] = 23;
            ages[1] = 43;
            Console.WriteLine(ages[0]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

    }

        private void btnDog_Click(object sender, EventArgs e)
        {
                Dog dog = new Dog("milu", "milk", 3.4f, 20.4f);
                Console.WriteLine(dog.Weight);
                dog.Size(45.5f, 20.3f);
                dog.Foody();
                dog.Run();
                

            dogs[0] = new Dog("m", "m", 3.2f, 21.4f);
            dogs[1] = new Dog("mi", "mi", 3.8f, 23.4f);
            dogs[2] = new Dog("mil", "mil", 3.9f, 25.4f);
            dogs[3] = new Dog("milu", "milk", 3.4f, 90.4f);
            foreach (var item in dogs)
            { 
            Console.WriteLine( item.Food );
                Console.WriteLine(item.Ditails());
            }
        }
    }
}