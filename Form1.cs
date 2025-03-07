using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bangcuuchuong1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbkq_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblkq.Text = " ";
            lbkq.Items.Clear();
            int so = Int32.Parse(nbukq.Value.ToString());
            for (int i = 1; i <= 10; i++)
            {
                lblkq.Text += so + " x " + i + "=" + so * i + "\n";
                lbkq.Items.Add(so + " x " + i + "=" + so * i + "\n");

            }
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            lblkq.Text = " ";
            lbkq.Items.Clear();
            int so = Int32.Parse(nbukq.Value.ToString());
            for (int i = 1; i <= 10; i++)
            {
                lblkq.Text += so + " x " + i + "=" + so * i + "\n";
                lbkq.Items.Add(so + " x " + i + "=" + so * i + "\n");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         

            
        }
    }
}
