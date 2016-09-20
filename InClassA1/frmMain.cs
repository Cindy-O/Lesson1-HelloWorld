using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
 * Name: Cindy Orbegoso
 * Date: September 20, 2016
 * In-class Assignment 1
 * Purpose: A form that will display or print promotional information for Books, 
 * music, Periodicals, and Coffee Bar.
 **/
namespace InClassA1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //Print a preview of the form
            printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            printForm1.Print();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            //Display Book Promotion info an code
            lblPromotion.Text = "Buy two. Get the second one for half price";
            lblPromotionCode.Text = "B608";
        }

        private void btnMusic_Click(object sender, EventArgs e)
        {
            //Display Music Promotion info an code
            lblPromotion.Text = "Get a free MP3 download with purchase of a CD";
            lblPromotionCode.Text = "M608";
        }

        private void btnPeriodicals_Click(object sender, EventArgs e)
        {
            //Display Periodicals Promotion info an code
            lblPromotion.Text = "Elite members receive 10% off every purchase";
            lblPromotionCode.Text = "P608";
        }

        private void btnCoffeeBar_Click(object sender, EventArgs e)
        {
            //Display Coffee Bar Promotion info an code
            lblPromotion.Text = "Celebrate the season with 20% off specialty drinks";
            lblPromotionCode.Text = "C608";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
