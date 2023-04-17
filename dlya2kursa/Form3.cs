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
    public partial class Form3 : Form
    {
        Form1 form1;
        public Form3(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = comboBox1.SelectedItem.ToString();
            if (item == "Свой вариант")
            {
                textBox1.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false;
            }
        }
        List<Car> cars = new List<Car>() {
        new Car("BMW", 1990, "Black", "Автомат", 300000),
        new Car("BMW", 1990, "Black", "Автомат", 50000),
        new Car("OPEL", 1990, "Black", "Автомат", 50000)
        };

        private void button2_Click(object sender, EventArgs e)
        {
            string item = comboBox1.SelectedItem.ToString();
            string brand;
            
            if(item == "Свой вариант")
            {
                brand = textBox1.Text;
            }
            else
            {
                brand = item;
            }
            string transon;
            if (radioButton1.Checked)
            {
                transon = radioButton1.Text;
            }
            else
            {
                transon = radioButton2.Text;
            }
            
            Car car = new Car(brand, Convert.ToInt32(textBox2.Text), comboBox2.SelectedIndex.ToString(), transon, Convert.ToInt32(textBox3.Text));
            listBox1.Items.Add($"{car.brand}, {car.year_issue}, {car.color}, {car.transmission}, {car.price}");

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            foreach (var car in cars)
            {
                listBox1.Items.Add($"{car.brand}, {car.year_issue}, {car.color}, {car.transmission}, {car.price}");
            }
        }
    }
}
