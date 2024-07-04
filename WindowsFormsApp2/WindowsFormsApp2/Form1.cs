using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //int num = -100;
            //string name = "300";

            ////name = num;
            //name = num.ToString();
            //name = 400.ToString();

            ////num = name;
            //num = int.Parse(name);
            //num = int.Parse("200");
            //num = int.Parse("abc");

            //var name = "John";
            //var num = 1000;
            //var one_char = 'A';

            //textBox_print.Text += name.GetType();
            //textBox_print.Text += "\r\n";
            //textBox_print.Text += num.GetType();
            //textBox_print.Text += "\r\n";
            //textBox_print.Text += one_char.GetType();

            //int sum = Add(1, 2);
            //textBox_print.Text += "\r\n";
            //textBox_print.Text += sum.ToString();

            //IdentifyAnimal("Dog");

            //for (int i = 0; i < 10; i++)
            //{
            //    textBox_print.Text += i.ToString();
            //    textBox_print.Text += "\r\n";
            //}
            //textBox_print.Text += "\r\n";

            //for (int i = 9; i >= 0; i--)
            //{
            //    textBox_print.Text += i.ToString();
            //    textBox_print.Text += "\r\n";
            //}
            //textBox_print.Text += "\r\n";

            //for (int i = 0; i < 10; i++)
            //{
            //    if (i % 2 == 0) continue;
            //    textBox_print.Text += i.ToString();
            //    textBox_print.Text += "\r\n";
            //}
            //textBox_print.Text += "\r\n";

            //for (int i = 1; i < 10; i+=2)
            //{
            //    textBox_print.Text += i.ToString();
            //    textBox_print.Text += "\r\n";
            //}
            //textBox_print.Text += "\r\n";

            //int[] numbers = {9,8,7,6,5,4,3,2,1,0};
            //foreach (var item in numbers)
            //{
            //    textBox_print.Text += item.ToString();
            //    textBox_print.Text += "\r\n";
            //}
            //textBox_print.Text += "\r\n";

            //int[] odds = { 1,3,5,7,9 };
            //foreach (var item in odds)
            //{
            //    textBox_print.Text += item.ToString();
            //    textBox_print.Text += "\r\n";
            //}

            int count = 1;
            textBox_print.Text += "Loop Start!\r\n";
            while (count < 5)
            {
                textBox_print.Text += count.ToString();
                textBox_print.Text += "\r\n";
                count++;
            }

            textBox_print.Text += "Loop Start!\r\n";
            for (int count2 = 1;  count2 < 5; count2++)
            {
                textBox_print.Text += count2.ToString();
                textBox_print.Text += "\r\n";
            }
        }

        //int Add(int x, int y)
        //{
        //    int a = x;
        //    int b = y;
        //    int result = a + b;
        //    return result;
        //}

        int Add(int x, int y)
        {
            int sum = x + y;
            if (sum < 1 && sum > -1)
            {
                return -1;
            }
            else if (sum < 101) 
            {
                return 1;
            }
            else if (sum < 201)
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }

        public void IdentifyAnimal(string animal)
        {
            switch(animal)
            {
                case "Dog":
                    textBox_print.Text = $"This is a {animal}";
                    break;
                case "Cat":
                    textBox_print.Text = "This is a " + animal;
                    break;
                case "Bird":
                    textBox_print.Text = "This is a bird.";
                    break;
                default:
                    textBox_print.Text = "Unknown animal!";
                    break;
            }
        }
    }
}
