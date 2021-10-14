using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWindowsFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int Penambahan(int a, int b)
        {
            return a + b;
        }

        private int Pengurangan(int a, int b)
        {
            return a - b;
        }

        private int Perkalian(int a, int b)
        {
            return a * b;
        }

        private int Pembagian(int a, int b)
        {
            return a / b;
        }

        private int Pangkat(int a, int b)
        {
            return (int)Math.Pow(a, b);
        }

        private static int Modulo(int a, int b)
        {
            return a % b;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = int.Parse(txtNilaiA.Text);
            var b = Convert.ToInt32(txtNilaiB.Text);

            if (cmb.SelectedIndex == 0)
            {
                txtHasil.Text = Convert.ToString(Penambahan(a, b));
            }

            if (cmb.SelectedIndex == 1)
            {
                txtHasil.Text = Convert.ToString(Pengurangan(a, b));
            }
            if (cmb.SelectedIndex == 2)
            {
                txtHasil.Text = Convert.ToString(Perkalian(a, b));
            }

            if (cmb.SelectedIndex == 3)
            {
                txtHasil.Text = Convert.ToString(Pembagian(a, b));
            }

            if (cmb.SelectedIndex == 4)
            {
                txtHasil.Text = Convert.ToString(Pangkat(a, b));
            }

            if (cmb.SelectedIndex == 5)
            {
                txtHasil.Text = Convert.ToString(Modulo(a, b));
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNilaiA_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstHasil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
