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
    public partial class TypeOfPub : Form
    {
        public TypeOfPub()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddTypeOfPub newForm = new AddTypeOfPub();
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateTypeOfPub newForm = new UpdateTypeOfPub();
            newForm.Show();
        }
    }
}
