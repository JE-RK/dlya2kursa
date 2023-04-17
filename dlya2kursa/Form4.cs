using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dlya2kursa
{
    public partial class Form4 : Form
    {
        Form2 form2;
        Car car;
        public Form4(Form2 form2, Car car)
        {
            this.form2 = form2;
            this.car = car;
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int[] mas = new int[10];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = random.Next(0, 10);
                label1.Text += mas[i];
            }
            label2.Text += car.brand;
            label3.Text += car.year_issue;
            label4.Text += car.color;
            label5.Text += car.transmission;
            label6.Text += car.price;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Поздравляем, {textBox2.Text}!");
            this.Close();
            form2.Show();
        }
    }
}
