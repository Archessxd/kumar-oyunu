using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int bakiye = 100;
        int oynananMiktar;
        byte kumar;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bakiyeTextBox.Enabled = false;
            bakiyeTextBox.Text = bakiye.ToString();

        }

        private void oynaBTN_Click(object sender, EventArgs e)
        {
            try
            {


                Random r = new Random();
                oynananMiktar = Convert.ToInt32(oynananMiktarTextBox.Text);
                kumar = (byte)r.Next(0, 2);
                

                if (kumar == 1)
                {
                    bakiye = bakiye - oynananMiktar;
                    bakiye = bakiye + oynananMiktar * 2;
                    bakiyeTextBox.Text = bakiye.ToString();
                }
                else if (kumar == 0)
                {
                    bakiye = bakiye - oynananMiktar;
                    bakiyeTextBox.Text = bakiye.ToString();
                    if (bakiye == 0 || bakiye < 0)
                    {
                        MessageBox.Show("bakiyeniz tükendi , oyun yeniden başlatılıyor.");
                        Thread.Sleep(0500);
                        this.Controls.Clear();
                        this.InitializeComponent();
                        bakiye = 100;
                        bakiyeTextBox.Text = bakiye.ToString();
                        bakiyeTextBox.Enabled = false;

                    }
                }
            }



            catch (Exception sa)
            {
                MessageBox.Show(sa.Message);
            }
        }
    }
}
