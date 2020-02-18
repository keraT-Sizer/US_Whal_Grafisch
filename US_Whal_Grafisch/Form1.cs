using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using US_Whal_Grafisch.model;

namespace US_Whal_Grafisch
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

        private void button1_Click(object sender, EventArgs e)
        {
            List<Wähler> wl = new List<Wähler>();
            Model.ZeigeWahlvolk(wl);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
