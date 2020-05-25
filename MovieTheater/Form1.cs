using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTheater
{
    public partial class Form1 : Form
    {
        int quota = 50;
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 50; i++)
            {
                Button buton = new Button()
                {
                    Name = "Buton" + i,
                    Text = (i + 1).ToString(),
                    Height = 75,
                    Width = 75,
                    BackColor = Color.Yellow,
                    

                };
                buton.Click += Armchair_Click;
                flowArmchair.Controls.Add(buton);
            }
            
         
        }

        private void Armchair_Click(object sender, EventArgs e)
        {
            Button buton = (Button)sender;
            if (buton.BackColor==Color.Yellow)
            {
                buton.BackColor = Color.Green;
                listBoxRezarvation.Items.Add(buton.Text);
            }
            else if (buton.BackColor == Color.Red)
            {
                MessageBox.Show("Sold !");
            }
            else
            {
                buton.BackColor = Color.Yellow;
                listBoxRezarvation.Items.Remove(buton.Text);
            }
            quotacalcuate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnClean_Click(object sender, EventArgs e)
        {
            listBoxRezarvation.Items.Clear();
            calcEditRezerve.ResetText();
            foreach (Button armchair in flowArmchair.Controls)
            {
                if (armchair.BackColor==Color.Green)
                {
                    armchair.BackColor = Color.Yellow;
                }
            }
            
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            listBoxRezarvation.Items.Clear();
            foreach (Button armchair in flowArmchair.Controls)
            {
                if (armchair.BackColor == Color.Green)
                {
                    armchair.BackColor = Color.Red;
                    quota--;
                }
            }
            quotacalcuate();
        }
        void quotacalcuate()
        {
            calcEditBuy.Value = 50 - quota;
            calcEditPurchasable.Value = quota;
            calcEditRezerve.Value = listBoxRezarvation.ItemCount;
        }
    }
}
