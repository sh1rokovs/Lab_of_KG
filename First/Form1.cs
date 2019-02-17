using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First
{
    public partial class Form1 : Form
    {
        Bitmap img;
        
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void открытьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files|*.png; *.jpg; *.bmp| All Files (*.*)|*.*";
            if (dialog.ShowDialog()==DialogResult.OK)
            {
            }
            img = new Bitmap(dialog.FileName);
            pictureBox1.Image = img;
            pictureBox1.Refresh();

        }
    }
}
