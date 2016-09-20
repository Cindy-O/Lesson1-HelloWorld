using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson1_HelloWorld
{
    public partial class frmHelloWorld : Form
    {
        public frmHelloWorld()
        {
            InitializeComponent();
        }

        private void frmHelloWorld_Load(object sender, EventArgs e)
        {

        }

        private void btnEnglish_Click(object sender, EventArgs e)
        {
            //dsplay message in the label
            lblMessage.Text = "Hello, World";
            //lblMessage.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void btnSpanish_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Hola, Mundo";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblMessage.Text = String.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //previews form
            printForm1.Print();
        }
    }
}
