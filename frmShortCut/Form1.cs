using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmShortCut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button notepad = new Button();
            Button paint = new Button();
            Button powerPoint = new Button();

            // Set Button properties
            notepad.Location = new Point(15, 100);
            notepad.Height = 40;
            notepad.Width = 220;

            paint.Location = new Point(15, 150);
            paint.Height = 40;
            paint.Width = 220;

            powerPoint.Location = new Point(15, 200);
            powerPoint.Height = 40;
            powerPoint.Width = 220;


            notepad.Text = "Notepad";
            notepad.Name = "notepad";
            notepad.Font = new Font("Georgia", 16);

            paint.Text = "Paint";
            paint.Name = "paint";
            paint.Font = new Font("Georgia", 16);

            powerPoint.Text = "Power Point";
            powerPoint.Name = "powerpoint";
            powerPoint.Font = new Font("Georgia", 16);



            Controls.Add(notepad);
            Controls.Add(paint);
            Controls.Add(powerPoint);

            notepad.Click += new EventHandler(notepad_click);
            paint.Click += new EventHandler(paint_click);
            powerPoint.Click += new EventHandler(powerpoint_click);
            void notepad_click (object sender, EventArgs e)
            {
                System.Diagnostics.Process.Start("notepad.exe");
            }
            void paint_click(object sender, EventArgs e)
            {
                System.Diagnostics.Process.Start("mspaint.exe");
            }
            void powerpoint_click(object sender, EventArgs e)
            {
                System.Diagnostics.Process.Start("powerpnt.exe");
            }
        }
    }
}
