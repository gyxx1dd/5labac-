using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3labac_
{
    public partial class Form1 : Form
    {
        WolfCollection wolfCollection;
        private Wolf wolf;
        private Wolf wolf1;
        private Wolf wolf3;
        private Wolf wolf4;

        public Form1()
        {
            InitializeComponent();
            wolfCollection = new WolfCollection();
            wolf = new Wolf(30, 3, 50, "Grey Wolf", "Forests of North America");
            wolf1 = new Wolf(10, 2, 50, "Grey Wolf", "Forests of North America");
            wolf3 = new Wolf(1, 1, 1, "Grey Wolf", "Forests of North America");
            wolf4 = new Wolf(2, 2, 2, "Grey Wolf", "Forests of North America");
            wolfCollection.AddToArrayList(wolf);
            wolfCollection.AddToArrayList(wolf1);
            wolfCollection.AddToList(wolf3);
            wolfCollection.AddToList(wolf4);




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Wolf Information:\n\n" +
                            $"Weight: {wolf.Weight} kg\n" +
                            $"Age: {wolf.Age} years\n" +
                            $"Daily Maintenance Cost: {wolf.DailyMaintenanceCost}$\n" +
                            $"Breed: {wolf.Breed}\n" +
                            $"Natural Habitat: {wolf.NaturalHabitat}",
                            "Wolf Info",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string wolfInfo = wolfCollection.DisplayArrayList();
            MessageBox.Show(wolfInfo, "Wolf Collection", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            string wolfInfo = wolfCollection.DisplayList();
            MessageBox.Show(wolfInfo, "Wolf Collection", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
