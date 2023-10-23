using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for_örnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAyikla_Click(object sender, EventArgs e)
        {


            for (int i = 0; i < lstKarisik.Items.Count; i++)
            {
                if (lstKarisik.Items[i].ToString()== "Çilek" ||
                    lstKarisik.Items[i].ToString() == "Muz" ||
                    lstKarisik.Items[i].ToString() == "Karpuz" ||
                    lstKarisik.Items[i].ToString() == "Mandalina" ||
                    lstKarisik.Items[i].ToString() == "Kavun")
                {
                    lstMeyve.Items.Add(lstKarisik.Items[i]);
                }
                else
                {
                    lstSebze.Items.Add(lstKarisik.Items[i]);
                }
            }
        }
    }
    
}
