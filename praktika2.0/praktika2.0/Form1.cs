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
            List<Car> cars = new List<Car>()
            {
                new Car(1, "Toyota", "Camry", 2015, "БАН202", 3, "Sedan", 1),
                new Car(2, "Ford", "Mustang", 2018, "ГДР157", 3, "Coupe", 1),
                new Car(3, "Lada", "Niva", 2013, "АДВ177", 3, "Universal", 1),
                new Car(4, "BMW", "M3", 1994, "БОК214", 3, "Sedan", 1),
                new Car(5, "Tesla", "Cybertruck", 2023, "БДВ226", 3, "Pickup", 1)
            };

            cars[0].SetMileage(25464);
            double mileage = cars[0].GetMileage();
            cars[1].SetMileage(46256);
            _ = cars[1].GetMileage();
            cars[2].SetMileage(210658);
            _ = cars[2].GetMileage();
            cars[3].SetMileage(268465);
            _ = cars[3].GetMileage();
            cars[4].SetMileage(56754);
            _ = cars[4].GetMileage();

            dataGridView1.DataSource = cars;
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
