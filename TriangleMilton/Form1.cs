using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriangleMilton
{
    public partial class Form1 : Form
    {

        Triangle trianlge;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(tbA) + Convert.ToDouble(tbB) > Convert.ToDouble(tbC) &&
                Convert.ToDouble(tbA) + Convert.ToDouble(tbC) > Convert.ToDouble(tbB) &&
                Convert.ToDouble(tbB) + Convert.ToDouble(tbC) > Convert.ToDouble(tbA))
            {
                trianlge = new Triangle(Convert.ToDouble(tbA.Text), Convert.ToDouble(tbB.Text), Convert.ToDouble(tbC));

            }
        }
    }
}
