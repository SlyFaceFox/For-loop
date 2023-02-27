using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace For_loop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int fromX = int.Parse(txtX1.Text);
            int toX = int.Parse(txtX2.Text);
            int fromY = int.Parse(txtY1.Text);
            int toY = int.Parse(txtY2.Text);
            
            for (int x = fromX; x <= toX; x++)
            {
                if (fromX > toX)
                {
                    MessageBox.Show("Интервал должен быть от меньшего к большему");
                    txtX1.Text = "";
                    txtX2.Text = "";
                }
                for (int y = fromY; y <=toY; y++)
                {
                    lstResult.Items.Add($"z(x,y) = {x} - {y} = {x - y}");

                    if (fromY > toY)
                    {
                        MessageBox.Show("Интервал должен быть от меньшего к большему");
                        txtY1.Text = "";
                        txtY2.Text = "";
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
