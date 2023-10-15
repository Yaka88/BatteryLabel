using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
namespace BatterySerieNo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class MainFrame : System.Windows.Forms.Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
        private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboModel;
		private System.Windows.Forms.ComboBox comboCompany;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboPhone;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboEmail;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboWebsite;
		private System.Windows.Forms.Label label5;
		private System.Drawing.Printing.PrintDocument printDoc;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioBG;
		private System.Windows.Forms.RadioButton radioBL;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton radioSeriesNo;
		private System.Windows.Forms.RadioButton radiolabel;
		private System.Windows.Forms.ComboBox comboAddress;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox comboAddress2;
		private System.Windows.Forms.Button btnPrint;
		private System.Windows.Forms.Label lblProduct;
		private System.Windows.Forms.RadioButton radioKN;
		private System.Windows.Forms.TextBox textStart;
		BLBARCODELib.BarcodeClass barcode;
        private string strpre = "BL";
        private CheckBox chkbarcode;
        private Label label8;
        private Label label9;
        private TextBox textCount;
        private PictureBox picLabel;
        private string strProduct = "Universal External Power System";

		public MainFrame()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.label1 = new System.Windows.Forms.Label();
            this.comboModel = new System.Windows.Forms.ComboBox();
            this.comboCompany = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboPhone = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboEmail = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboWebsite = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.printDoc = new System.Drawing.Printing.PrintDocument();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioKN = new System.Windows.Forms.RadioButton();
            this.radioBG = new System.Windows.Forms.RadioButton();
            this.radioBL = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioSeriesNo = new System.Windows.Forms.RadioButton();
            this.radiolabel = new System.Windows.Forms.RadioButton();
            this.comboAddress = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboAddress2 = new System.Windows.Forms.ComboBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.textStart = new System.Windows.Forms.TextBox();
            this.chkbarcode = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textCount = new System.Windows.Forms.TextBox();
            this.picLabel = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLabel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Model:";
            // 
            // comboModel
            // 
            this.comboModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboModel.FormattingEnabled = true;
            this.comboModel.Items.AddRange(new object[] {
            "-MP-142",
            "-MP-130",
            "5/12-133",
            "5/16-142",
            "12-133",
            "16-142",
            "16-130",
            "9/12-133",
            "9/12-80",
            "16/19-142",
            "16/19-130",
            "16/19-70",
            "12/24-142",
            "12/24-133"});
            this.comboModel.Location = new System.Drawing.Point(72, 48);
            this.comboModel.Name = "comboModel";
            this.comboModel.Size = new System.Drawing.Size(160, 21);
            this.comboModel.TabIndex = 1;
            // 
            // comboCompany
            // 
            this.comboCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCompany.Enabled = false;
            this.comboCompany.FormattingEnabled = true;
            this.comboCompany.Items.AddRange(new object[] {
            "BLUELASER",
            "BATTERYGEEK",
            "KALNA"});
            this.comboCompany.Location = new System.Drawing.Point(72, 80);
            this.comboCompany.Name = "comboCompany";
            this.comboCompany.Size = new System.Drawing.Size(160, 21);
            this.comboCompany.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Company:";
            // 
            // comboPhone
            // 
            this.comboPhone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPhone.Enabled = false;
            this.comboPhone.FormattingEnabled = true;
            this.comboPhone.Items.AddRange(new object[] {
            "+86-571-22867833",
            "+1-800-287-1663",
            "+1-626-246-8433"});
            this.comboPhone.Location = new System.Drawing.Point(72, 144);
            this.comboPhone.Name = "comboPhone";
            this.comboPhone.Size = new System.Drawing.Size(160, 21);
            this.comboPhone.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Phone:";
            // 
            // comboEmail
            // 
            this.comboEmail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEmail.Enabled = false;
            this.comboEmail.FormattingEnabled = true;
            this.comboEmail.Items.AddRange(new object[] {
            "Yaka88@gmail.com",
            "sales@batterygeek.net",
            "oelnak@yahoo.com"});
            this.comboEmail.Location = new System.Drawing.Point(72, 176);
            this.comboEmail.Name = "comboEmail";
            this.comboEmail.Size = new System.Drawing.Size(160, 21);
            this.comboEmail.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email:";
            // 
            // comboWebsite
            // 
            this.comboWebsite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboWebsite.Enabled = false;
            this.comboWebsite.FormattingEnabled = true;
            this.comboWebsite.Items.AddRange(new object[] {
            "http://www.bluelaser.cn",
            "http://www.batterygeek.net",
            "http://www.gokalna.com"});
            this.comboWebsite.Location = new System.Drawing.Point(72, 208);
            this.comboWebsite.Name = "comboWebsite";
            this.comboWebsite.Size = new System.Drawing.Size(160, 21);
            this.comboWebsite.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(8, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Website:";
            // 
            // printDoc
            // 
            this.printDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDoc_PrintPage);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(8, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Product:";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(149, 248);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(96, 32);
            this.btnPrint.TabIndex = 14;
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioKN);
            this.groupBox1.Controls.Add(this.radioBG);
            this.groupBox1.Controls.Add(this.radioBL);
            this.groupBox1.Location = new System.Drawing.Point(264, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 48);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Company";
            // 
            // radioKN
            // 
            this.radioKN.Location = new System.Drawing.Point(184, 16);
            this.radioKN.Name = "radioKN";
            this.radioKN.Size = new System.Drawing.Size(66, 24);
            this.radioKN.TabIndex = 19;
            this.radioKN.Text = "KALNA";
            this.radioKN.Visible = false;
            this.radioKN.CheckedChanged += new System.EventHandler(this.radioKN_CheckedChanged);
            // 
            // radioBG
            // 
            this.radioBG.Location = new System.Drawing.Point(86, 16);
            this.radioBG.Name = "radioBG";
            this.radioBG.Size = new System.Drawing.Size(98, 24);
            this.radioBG.TabIndex = 18;
            this.radioBG.Text = "Batterygeek";
            this.radioBG.Visible = false;
            this.radioBG.CheckedChanged += new System.EventHandler(this.radioBG_CheckedChanged);
            // 
            // radioBL
            // 
            this.radioBL.Checked = true;
            this.radioBL.Location = new System.Drawing.Point(8, 16);
            this.radioBL.Name = "radioBL";
            this.radioBL.Size = new System.Drawing.Size(80, 24);
            this.radioBL.TabIndex = 17;
            this.radioBL.TabStop = true;
            this.radioBL.Text = "Bluelaser";
            this.radioBL.CheckedChanged += new System.EventHandler(this.radioBL_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioSeriesNo);
            this.groupBox2.Controls.Add(this.radiolabel);
            this.groupBox2.Location = new System.Drawing.Point(264, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 48);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Label";
            // 
            // radioSeriesNo
            // 
            this.radioSeriesNo.Checked = true;
            this.radioSeriesNo.Location = new System.Drawing.Point(104, 16);
            this.radioSeriesNo.Name = "radioSeriesNo";
            this.radioSeriesNo.Size = new System.Drawing.Size(80, 24);
            this.radioSeriesNo.TabIndex = 20;
            this.radioSeriesNo.TabStop = true;
            this.radioSeriesNo.Text = "Serial No.";
            this.radioSeriesNo.CheckedChanged += new System.EventHandler(this.radioSeriesNo_CheckedChanged);
            // 
            // radiolabel
            // 
            this.radiolabel.Location = new System.Drawing.Point(24, 16);
            this.radiolabel.Name = "radiolabel";
            this.radiolabel.Size = new System.Drawing.Size(80, 24);
            this.radiolabel.TabIndex = 19;
            this.radiolabel.Text = "Box Label";
            this.radiolabel.CheckedChanged += new System.EventHandler(this.radiolabel_CheckedChanged);
            // 
            // comboAddress
            // 
            this.comboAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAddress.Enabled = false;
            this.comboAddress.FormattingEnabled = true;
            this.comboAddress.Items.AddRange(new object[] {
            "503,Chuangye Center",
            "17533 SW Mardee Avenue",
            "1388 Edmore Ave."});
            this.comboAddress.Location = new System.Drawing.Point(72, 112);
            this.comboAddress.Name = "comboAddress";
            this.comboAddress.Size = new System.Drawing.Size(160, 21);
            this.comboAddress.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(8, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Address:";
            // 
            // comboAddress2
            // 
            this.comboAddress2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAddress2.Enabled = false;
            this.comboAddress2.FormattingEnabled = true;
            this.comboAddress2.Items.AddRange(new object[] {
            "Xiaoshan, ZJ 311215 China",
            "Lake Oswego, OR 97035 USA",
            "Rowland Heights, CA 91748 USA"});
            this.comboAddress2.Location = new System.Drawing.Point(72, 112);
            this.comboAddress2.Name = "comboAddress2";
            this.comboAddress2.Size = new System.Drawing.Size(160, 21);
            this.comboAddress2.TabIndex = 21;
            // 
            // lblProduct
            // 
            this.lblProduct.BackColor = System.Drawing.SystemColors.Control;
            this.lblProduct.Location = new System.Drawing.Point(72, 16);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(186, 16);
            this.lblProduct.TabIndex = 22;
            this.lblProduct.Text = "Universal External Power Pack";
            // 
            // textStart
            // 
            this.textStart.Location = new System.Drawing.Point(72, 235);
            this.textStart.Name = "textStart";
            this.textStart.Size = new System.Drawing.Size(48, 20);
            this.textStart.TabIndex = 23;
            this.textStart.Text = "0";
            // 
            // chkbarcode
            // 
            this.chkbarcode.AutoSize = true;
            this.chkbarcode.Enabled = false;
            this.chkbarcode.Location = new System.Drawing.Point(265, 257);
            this.chkbarcode.Name = "chkbarcode";
            this.chkbarcode.Size = new System.Drawing.Size(87, 17);
            this.chkbarcode.TabIndex = 24;
            this.chkbarcode.Text = "BarcodeOnly";
            this.chkbarcode.UseVisualStyleBackColor = true;
            this.chkbarcode.Visible = false;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(27, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "Start";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(27, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "Count";
            // 
            // textCount
            // 
            this.textCount.Location = new System.Drawing.Point(72, 261);
            this.textCount.Name = "textCount";
            this.textCount.Size = new System.Drawing.Size(48, 20);
            this.textCount.TabIndex = 27;
            this.textCount.Text = "0";
            // 
            // picLabel
            // 
            this.picLabel.BackColor = System.Drawing.Color.White;
            this.picLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLabel.Location = new System.Drawing.Point(256, 112);
            this.picLabel.Name = "picLabel";
            this.picLabel.Size = new System.Drawing.Size(250, 125);
            this.picLabel.TabIndex = 0;
            this.picLabel.TabStop = false;
            this.picLabel.Paint += new System.Windows.Forms.PaintEventHandler(this.picLabel_Paint);
            // 
            // MainFrame
            // 
            this.ClientSize = new System.Drawing.Size(528, 294);
            this.Controls.Add(this.textCount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chkbarcode);
            this.Controls.Add(this.textStart);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.comboAddress);
            this.Controls.Add(this.comboAddress2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboWebsite);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboCompany);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboModel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picLabel);
            this.MaximizeBox = false;
            this.Name = "MainFrame";
            this.Text = "BLUELASER UPS Label ";
            this.Load += new System.EventHandler(this.MainFrame_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLabel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
             Application.Run(new MainFrame());
		}

		private void MainFrame_Load(object sender, System.EventArgs e)
		{
			comboModel.SelectedIndex = 0;
			comboCompany.SelectedIndex = 0;
			comboAddress.SelectedIndex = 0;
			comboAddress2.SelectedIndex = 0;
			comboPhone.SelectedIndex = 0;
			comboEmail.SelectedIndex = 0;
			comboWebsite.SelectedIndex = 0;            
			barcode = new BLBARCODELib.BarcodeClass();            
            barcode.strBarcode = strpre + DateTime.Today.ToString("yyMM") + "0001";
			barcode.SizeX = 250;
			barcode.SizeY = 25;
			barcode.Write();
		}

		private void picLabel_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			Font font = new Font("Arial",9);
            Font Boldfont = new Font("Arial", 10, FontStyle.Bold);
            Font smallfont = new Font("Arial", 8, FontStyle.Bold);
			SolidBrush brush = new SolidBrush(Color.Black);
			int i = 0;
			if (radiolabel.Checked)
			{
                e.Graphics.DrawString("                   " + comboCompany.Text, Boldfont, brush, 0, 20 * i++);
                e.Graphics.DrawString("         " + strProduct, font, brush, 0, 20 * i++);
                e.Graphics.DrawString("Model        : " + strpre + comboModel.Text, font, brush, 0, 20 * i++);
				e.Graphics.DrawString("Address   : " + comboAddress.Text,font,brush,0,20*i++);	
				e.Graphics.DrawString("              " + comboAddress2.Text,font,brush,0,20*i++);	
				e.Graphics.DrawString("Phone       : " + comboPhone.Text,font,brush,0,20*i++);
				e.Graphics.DrawString("Email        : " + comboEmail.Text,font,brush,0,20*i++);
                e.Graphics.DrawString("Website    : " + comboWebsite.Text, font, brush, 0, 20 * i++);
			}
			
			if (radioSeriesNo.Checked)
			{
                e.Graphics.DrawString("        " + lblProduct.Text, font, brush, 0, 20 * i++);
                e.Graphics.DrawString("             Model : " + strpre + comboModel.Text, font, brush, 0, 20 * i++);
                e.Graphics.DrawString("         Li-ion    CE    RoHS", Boldfont, brush, 0, 20 * i++);
                e.Graphics.DrawString("PS", smallfont, brush, 174, 20 * i - 24);
                e.Graphics.DrawString("E", smallfont, brush, 178, 20 * i - 15);
                e.Graphics.DrawEllipse(new Pen(brush,2), 172, 20 * i - 25, 23, 23);
                

				IntPtr hdc = e.Graphics.GetHdc();
                barcode.Draw(hdc.ToInt32(), 0, 20 * i++);
				e.Graphics.ReleaseHdc(hdc);
                e.Graphics.DrawString("                                       MADE IN CHINA", smallfont, brush, 0, 20 * i +8);
			}
		}

		private void printDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			Font font = new Font("Arial",9);
            Font Boldfont = new Font("Arial", 10, FontStyle.Bold);
            Font smallfont = new Font("Arial", 8, FontStyle.Bold);
			SolidBrush brush = new SolidBrush(Color.Black);
			Pen pen = new Pen(Color.DarkGray);
			if (radiolabel.Checked)
			{
				int intWidth = 250;
				int intHeight = 156;
				for (int y=0;y<7;y++)
				{
					for(int x=0;x<3;x++)
					{
                        e.Graphics.DrawString("                 " + comboCompany.Text, Boldfont, brush, x * intWidth, y * intHeight + 0);						
						e.Graphics.DrawString( "     " + strProduct,font,brush,x * intWidth ,y * intHeight + 20);
                        e.Graphics.DrawString("Model       : " + strpre + comboModel.Text, font, brush, x * intWidth, y * intHeight + 40);
						e.Graphics.DrawString("Address   : " + comboAddress.Text,font,brush,x * intWidth,y * intHeight + 60);	
						e.Graphics.DrawString("             " + comboAddress2.Text,font,brush,x * intWidth,y * intHeight + 77);	
						e.Graphics.DrawString("Phone      : " + comboPhone.Text,font,brush,x * intWidth,y * intHeight + 97);
						e.Graphics.DrawString("Email       : " + comboEmail.Text,font,brush,x * intWidth,y * intHeight + 117);
						e.Graphics.DrawString("Website   : " + comboWebsite.Text,font,brush,x * intWidth,y * intHeight + 136);
						e.Graphics.DrawLine(pen,(x+1) * intWidth -10 ,y * intHeight,(x+1) * intWidth - 10,(y+1) * intHeight);
					}
					e.Graphics.DrawLine(pen,0 ,(y+1) * intHeight - 2,740 ,(y+1) * intHeight -2);
				}
			}
			else
			{
                bool bcodeonly = chkbarcode.Checked; ;    
				int intSeriesNo = int.Parse(textStart.Text);
                int intCount = int.Parse(textCount.Text);
                int intline = 9;
                if (intCount > 0 || intCount < 27)
                    intline = (intCount + 2 )/ 3;
				barcode.SizeX = 1500;
				barcode.SizeY = 150;
				int intWidth = 250;
                int intHeight = 124;
                
                if (bcodeonly)
                {
                    intHeight = 25;
                    intline = (intCount + 2 )/ 3;
                }

                string strmodel = "BL" + comboModel.Text;
				for (int y=0;y<intline;y++)
				{
					for(int x=0;x<3;x++)
					{
                        if (!bcodeonly)
                        {
                            e.Graphics.DrawString("        " + lblProduct.Text, font, brush, x * intWidth, y * intHeight + 0);
                            e.Graphics.DrawString("             Model : " + strmodel, font, brush, x * intWidth, y * intHeight + 20);
                            e.Graphics.DrawLine(pen, (x + 1) * intWidth - 10, y * intHeight, (x + 1) * intWidth - 10, (y + 1) * intHeight);
                            e.Graphics.DrawString("         Li-ion    CE    RoHS", Boldfont, brush, x * intWidth, y * intHeight + 40);
                            e.Graphics.DrawString("PS", smallfont, brush, x * intWidth + 174, y * intHeight + 36);
                            e.Graphics.DrawString("E", smallfont, brush, x * intWidth + 178, y * intHeight +45);
                            e.Graphics.DrawEllipse(new Pen(brush, 2),x * intWidth+ 172,y * intHeight+ 35, 23, 23);
                        }
                            barcode.strBarcode = strpre +DateTime.Today.ToString("yyMM") + intSeriesNo.ToString("0000");
						intSeriesNo++;                       
						barcode.Write();
						IntPtr hdc = e.Graphics.GetHdc();
                        
						barcode.Draw(hdc.ToInt32(),x * intWidth * 6,(y * intHeight +59) * 6 );
						e.Graphics.ReleaseHdc(hdc);
                        if (!bcodeonly)
                            e.Graphics.DrawString("                                       MADE IN CHINA", smallfont, brush, x * intWidth, y * intHeight + 88);
					}
                    if (!bcodeonly) 
                        e.Graphics.DrawLine(pen, 0, (y + 1) * intHeight - 10, 740, (y + 1) * intHeight - 10);
				}
				textStart.Text = intSeriesNo.ToString();
				barcode.SizeX = 250;
				barcode.SizeY = 25;
				barcode.Write();
			}
		} 

		private void btnPrint_Click(object sender, System.EventArgs e)
		{
			printDoc.Print();
		}

		private void radioBL_CheckedChanged(object sender, System.EventArgs e)
		{
			if (radioBL.Checked)
			{
				comboCompany.SelectedIndex = 0;
				comboAddress.SelectedIndex = 0;
				comboAddress2.SelectedIndex = 0;
				comboPhone.SelectedIndex = 0;
				comboEmail.SelectedIndex = 0;
				comboWebsite.SelectedIndex = 0;
                strpre = "BL";
			}
			picLabel.Refresh();

		}

		private void radioBG_CheckedChanged(object sender, System.EventArgs e)
		{
			if (radioBG.Checked)
			{
				comboCompany.SelectedIndex = 1;
				comboAddress.SelectedIndex = 1;
				comboAddress2.SelectedIndex = 1;
				comboPhone.SelectedIndex = 1;
				comboEmail.SelectedIndex = 1;
				comboWebsite.SelectedIndex = 1;
                strpre = "BG";
			}
			picLabel.Refresh();
		}
		private void radioKN_CheckedChanged(object sender, System.EventArgs e)
		{
			if (radioKN.Checked)
			{
				comboCompany.SelectedIndex = 2;
				comboAddress.SelectedIndex = 2;
				comboAddress2.SelectedIndex = 2;
				comboPhone.SelectedIndex = 2;
				comboEmail.SelectedIndex = 2;
				comboWebsite.SelectedIndex = 2;
                strpre = "KN";
			}
			picLabel.Refresh();
		}
		private void radiolabel_CheckedChanged(object sender, System.EventArgs e)
		{
			if (radiolabel.Checked)
			{
				picLabel.Height = 160;
				picLabel.Refresh();
                chkbarcode.Visible = false;
			}
		}

		private void radioSeriesNo_CheckedChanged(object sender, System.EventArgs e)
		{
			if(radioSeriesNo.Checked)
			{
				picLabel.Height = 125;
				picLabel.Refresh();
                chkbarcode.Visible = true;
			}
		}

		
			
	}
}
