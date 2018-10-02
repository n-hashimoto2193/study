using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        static void Main()
        {
            Application.Run(new Form1());
        }

        

        private void clear_button_Click(object sender, EventArgs e)
        {
            Clear();
            
        }


        private void end_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clear()
        {
            batsText.Text = "0";
            hitsText.Text = "0";
            averageText.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (batsText.Text == "" || hitsText.Text == "")
            {
                MessageBox.Show("打数・安打数を両方を入力してください");
            }
        }

        
    }
}
