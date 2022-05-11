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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPub newForm = new AddPub();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdatePub newForm = new UpdatePub();
            newForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void авторыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Author newForm = new Author();
            newForm.Show();
        }

        private void местаРаботыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlaceOfWork newForm = new PlaceOfWork();
            newForm.Show();
        }
        

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void издательстваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PubHouses newForm = new PubHouses();
            newForm.Show();
        }

        private void типыПубликацийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypeOfPub newForm = new TypeOfPub();
            newForm.Show();
        }

        private void учёныеСтепениToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Degree newForm = new Degree();
            newForm.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
