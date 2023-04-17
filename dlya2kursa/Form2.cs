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
    public partial class Form2 : Form
    {
        Form1 form1;

        public Form2(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            form1.Show();

        }
        List<Car> cars = new List<Car>() {
        new Car("BMW", 1990, "Black", "Автомат", 300000),
        new Car("BMW", 1990, "Black", "Автомат", 50000),
        new Car("OPEL", 1990, "Black", "Автомат", 50000)
        };

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            foreach (var car in cars)
            {
                listBox1.Items.Add($"{car.brand}, {car.year_issue}, {car.color}, {car.transmission}, {car.price}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Все" && textBox2.Text != "")
            {
                listBox1.Items.Clear();
                foreach (var car in cars)
                {

                    if (car.price <= Convert.ToInt32(textBox2.Text))
                    {

                        listBox1.Items.Add($"{car.brand}, {car.year_issue}, {car.color}, {car.transmission}, {car.price}");
                    }

                }
            }
            else if (comboBox1.SelectedItem.ToString() != "Все" && textBox2.Text != "")
            {
                listBox1.Items.Clear();
                foreach (var car in cars)
                {

                    if (car.brand == comboBox1.SelectedItem.ToString() && car.price <= Convert.ToInt32(textBox2.Text))
                    {

                        listBox1.Items.Add($"{car.brand}, {car.year_issue}, {car.color}, {car.transmission}, {car.price}");
                    }

                }
            }
            else if (comboBox1.SelectedIndex == 0 && textBox2.Text == "")
            {
                listBox1.Items.Clear();
                foreach (var car in cars)
                {
                    listBox1.Items.Add($"{car.brand}, {car.year_issue}, {car.color}, {car.transmission}, {car.price}");
                }
            }
            else if (comboBox1.SelectedIndex != 0 && textBox2.Text == "")
            {
                listBox1.Items.Clear();
                foreach (var car in cars)
                {

                    if (car.brand == comboBox1.SelectedItem.ToString())
                    {

                        listBox1.Items.Add($"{car.brand}, {car.year_issue}, {car.color}, {car.transmission}, {car.price}");
                    }

                }


            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var car in cars)
            {
                listBox1.Items.Add($"{car.brand}, {car.year_issue}, {car.color}, {car.transmission}, {car.price}");
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            Car car = cars[listBox1.SelectedIndex];
            this.Hide();
            new Form4(this, car).Show();
        }
    }
}
