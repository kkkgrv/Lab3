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
    public partial class Author : Form
    {
        public Author()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddAuthor newForm = new AddAuthor();
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateAuthor newForm = new UpdateAuthor();
            newForm.Show();
        }

        private void Author_Load(object sender, EventArgs e)
        {

        }
    }
}
