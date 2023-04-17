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
    public partial class Form5 : Form
    {
        Form1 form1;
        public Form5(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 6;
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].HeaderText = "Фамилия";
            dataGridView1.Columns[1].HeaderText = "Имя";
            dataGridView1.Columns[2].HeaderText = "Отчество";
            dataGridView1.Columns[3].HeaderText = "Должность";
            dataGridView1.Columns[4].HeaderText = "Телефон";
            List<Employee> employees = new List<Employee>() {
                new Employee("Родионов", "Андрей", "Эдуардович", "Директор", "+79508234509"),
                new Employee("Летова", "Александра", "Ивановна", "Менеджер по продажам", "+79501234567"),
                new Employee("Петров", "Михаил", "Сергеевич", "Водитель-перегонщик", "+79509876543"),
                new Employee("Шаповалов", "Данила", "Сергеевич", "Кассир", "+79501856356"),
                new Employee("Шишкина", "Дарья", "Константиновна", "Уборщица", "+79507897835"),
            };

            int index = 0;
            foreach (var item in employees)
            {
                dataGridView1.Rows[index].Cells[0].Value = item.surname;
                dataGridView1.Rows[index].Cells[1].Value = item.name;
                dataGridView1.Rows[index].Cells[2].Value = item.patronymic;
                dataGridView1.Rows[index].Cells[3].Value = item.post;
                dataGridView1.Rows[index].Cells[4].Value = item.phone_number;
                index++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            form1.Show();
        }
    }
}
