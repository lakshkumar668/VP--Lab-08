using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIApp
{
    public partial class Form1 : Form
    {
        Form2 form2;
        Form3 form3;
        public Form1()
        {
            InitializeComponent();
            form2 = new Form2();
            form3 = new Form3();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            showForm2.Click += new EventHandler(show2);
            void show2(object sender, EventArgs e)
            {
                form2.Show();
            }
            hideForm2.Click += new EventHandler(hide2);
            void hide2(object sender, EventArgs e)
            {
                form2.Hide();
            }
            showForm3.Click += new EventHandler(show3);
            void show3(object sender, EventArgs e)
            {
                form3.Show();
            }
            hideForm3.Click += new EventHandler(hide3);
            void hide3(object sender, EventArgs e)
            {
                form3.Hide();
            }
        }
    }
}
