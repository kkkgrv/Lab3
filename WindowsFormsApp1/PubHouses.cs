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
    public partial class PubHouses : Form
    {
        public PubHouses()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPubHouse newForm = new AddPubHouse();
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdatePubHouse newForm = new UpdatePubHouse();
            newForm.Show();
        }
    }
}
