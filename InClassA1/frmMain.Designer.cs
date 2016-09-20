namespace InClassA1
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnBooks = new System.Windows.Forms.Button();
            this.btnMusic = new System.Windows.Forms.Button();
            this.btnPeriodicals = new System.Windows.Forms.Button();
            this.btnCoffeeBar = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPromotion = new System.Windows.Forms.Label();
            this.lblPromotionCode = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.printForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.SuspendLayout();
            // 
            // btnBooks
            // 
            this.btnBooks.Location = new System.Drawing.Point(12, 75);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(75, 23);
            this.btnBooks.TabIndex = 0;
            this.btnBooks.Text = "&Books";
            this.btnBooks.UseVisualStyleBackColor = true;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // btnMusic
            // 
            this.btnMusic.Location = new System.Drawing.Point(12, 104);
            this.btnMusic.Name = "btnMusic";
            this.btnMusic.Size = new System.Drawing.Size(75, 23);
            this.btnMusic.TabIndex = 1;
            this.btnMusic.Text = "&Music";
            this.btnMusic.UseVisualStyleBackColor = true;
            this.btnMusic.Click += new System.EventHandler(this.btnMusic_Click);
            // 
            // btnPeriodicals
            // 
            this.btnPeriodicals.Location = new System.Drawing.Point(12, 133);
            this.btnPeriodicals.Name = "btnPeriodicals";
            this.btnPeriodicals.Size = new System.Drawing.Size(75, 23);
            this.btnPeriodicals.TabIndex = 2;
            this.btnPeriodicals.Text = "P&eriodicals";
            this.btnPeriodicals.UseVisualStyleBackColor = true;
            this.btnPeriodicals.Click += new System.EventHandler(this.btnPeriodicals_Click);
            // 
            // btnCoffeeBar
            // 
            this.btnCoffeeBar.Location = new System.Drawing.Point(12, 162);
            this.btnCoffeeBar.Name = "btnCoffeeBar";
            this.btnCoffeeBar.Size = new System.Drawing.Size(75, 23);
            this.btnCoffeeBar.TabIndex = 3;
            this.btnCoffeeBar.Text = "&Coffee Bar";
            this.btnCoffeeBar.UseVisualStyleBackColor = true;
            this.btnCoffeeBar.Click += new System.EventHandler(this.btnCoffeeBar_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(12, 211);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "&Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 240);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Promotion Information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Current Promotion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Promotion Code";
            // 
            // lblPromotion
            // 
            this.lblPromotion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPromotion.Location = new System.Drawing.Point(206, 77);
            this.lblPromotion.Name = "lblPromotion";
            this.lblPromotion.Size = new System.Drawing.Size(259, 18);
            this.lblPromotion.TabIndex = 9;
            this.lblPromotion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPromotionCode
            // 
            this.lblPromotionCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPromotionCode.Location = new System.Drawing.Point(206, 108);
            this.lblPromotionCode.Name = "lblPromotionCode";
            this.lblPromotionCode.Size = new System.Drawing.Size(92, 18);
            this.lblPromotionCode.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.ForestGreen;
            this.label6.Location = new System.Drawing.Point(359, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cindy Orbegoso";
            // 
            // printForm1
            // 
            this.printForm1.DocumentName = "document";
            this.printForm1.Form = this;
            this.printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.printForm1.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm1.PrinterSettings")));
            this.printForm1.PrintFileName = null;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 273);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPromotionCode);
            this.Controls.Add(this.lblPromotion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnCoffeeBar);
            this.Controls.Add(this.btnPeriodicals);
            this.Controls.Add(this.btnMusic);
            this.Controls.Add(this.btnBooks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "R \'n R -- for Reading and Refreshment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Button btnMusic;
        private System.Windows.Forms.Button btnPeriodicals;
        private System.Windows.Forms.Button btnCoffeeBar;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPromotion;
        private System.Windows.Forms.Label lblPromotionCode;
        private System.Windows.Forms.Label label6;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm1;
    }
}

