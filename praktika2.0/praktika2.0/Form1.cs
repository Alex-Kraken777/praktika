using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace praktika2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Создание объектов типа Car
            Car car1 = new Car(1, "Toyota", "Camry", 2015, "БАН202", 9, "Sedan");
            Car car2 = new Car(2, "Ford", "Mustang", 2018, "ГДР157", 6, "Coupe");
            Car car3 = new Car(3, "Lada", "Niva", 2013, "АДВ177", 2, "Universal");
            Car car4 = new Car(4, "BMW", "M3", 1994, "БОК214", 30, "Sedan" );
            Car car5 = new Car(5, "Tesla", "Cybertruck", 2023, "БДВ226", 1, "Pickup");
            // Добавление автомобилей в DataGridView
            dataGridView1.DataSource = new List<Vehicle> { car1, car2, car3, car4, car5 };
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "", DataPropertyName = "" });
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.RemoveAt(dataGridView1.Columns.Count - 1);
        }
    }
}
