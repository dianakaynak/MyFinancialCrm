namespace MyFinancialCrm
{
	partial class FrmDashboard
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.button1 = new System.Windows.Forms.Button();
			this.btnBanksForm = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblBillTitle = new System.Windows.Forms.Label();
			this.lblBillAmount = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.lblTotalBalance = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.lblLastBankProcessAmount = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.panel6 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.panel7 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
			this.panel6.SuspendLayout();
			this.panel7.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.RoyalBlue;
			this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(53, 29);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(199, 48);
			this.button1.TabIndex = 0;
			this.button1.Text = "Kategoriler";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnBanksForm
			// 
			this.btnBanksForm.BackColor = System.Drawing.Color.RoyalBlue;
			this.btnBanksForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnBanksForm.ForeColor = System.Drawing.Color.White;
			this.btnBanksForm.Location = new System.Drawing.Point(53, 101);
			this.btnBanksForm.Name = "btnBanksForm";
			this.btnBanksForm.Size = new System.Drawing.Size(199, 48);
			this.btnBanksForm.TabIndex = 1;
			this.btnBanksForm.Text = "Bankalar";
			this.btnBanksForm.UseVisualStyleBackColor = false;
			this.btnBanksForm.Click += new System.EventHandler(this.btnBanksForm_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.RoyalBlue;
			this.button3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button3.ForeColor = System.Drawing.Color.White;
			this.button3.Location = new System.Drawing.Point(53, 171);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(199, 48);
			this.button3.TabIndex = 2;
			this.button3.Text = "Faturalar";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.RoyalBlue;
			this.button4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button4.ForeColor = System.Drawing.Color.White;
			this.button4.Location = new System.Drawing.Point(53, 235);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(199, 48);
			this.button4.TabIndex = 3;
			this.button4.Text = "Giderler";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.RoyalBlue;
			this.button5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button5.ForeColor = System.Drawing.Color.White;
			this.button5.Location = new System.Drawing.Point(53, 303);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(199, 48);
			this.button5.TabIndex = 4;
			this.button5.Text = "Banka Hareketleri";
			this.button5.UseVisualStyleBackColor = false;
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.RoyalBlue;
			this.button6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button6.ForeColor = System.Drawing.Color.White;
			this.button6.Location = new System.Drawing.Point(53, 375);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(199, 48);
			this.button6.TabIndex = 5;
			this.button6.Text = "Dashboard";
			this.button6.UseVisualStyleBackColor = false;
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.RoyalBlue;
			this.button7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button7.ForeColor = System.Drawing.Color.White;
			this.button7.Location = new System.Drawing.Point(53, 444);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(199, 48);
			this.button7.TabIndex = 6;
			this.button7.Text = "Ayarlar";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button8
			// 
			this.button8.BackColor = System.Drawing.Color.RoyalBlue;
			this.button8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button8.ForeColor = System.Drawing.Color.White;
			this.button8.Location = new System.Drawing.Point(53, 519);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(199, 48);
			this.button8.TabIndex = 7;
			this.button8.Text = "Çıkış Yap";
			this.button8.UseVisualStyleBackColor = false;
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
			this.panel1.Controls.Add(this.button8);
			this.panel1.Controls.Add(this.button7);
			this.panel1.Controls.Add(this.button6);
			this.panel1.Controls.Add(this.button5);
			this.panel1.Controls.Add(this.button4);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.btnBanksForm);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Location = new System.Drawing.Point(6, 87);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(309, 666);
			this.panel1.TabIndex = 10;
			// 
			// lblBillTitle
			// 
			this.lblBillTitle.AutoSize = true;
			this.lblBillTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblBillTitle.ForeColor = System.Drawing.Color.White;
			this.lblBillTitle.Location = new System.Drawing.Point(17, 15);
			this.lblBillTitle.Name = "lblBillTitle";
			this.lblBillTitle.Size = new System.Drawing.Size(127, 20);
			this.lblBillTitle.TabIndex = 5;
			this.lblBillTitle.Text = "Fatura Başlığı";
			// 
			// lblBillAmount
			// 
			this.lblBillAmount.AutoSize = true;
			this.lblBillAmount.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblBillAmount.ForeColor = System.Drawing.Color.White;
			this.lblBillAmount.Location = new System.Drawing.Point(47, 46);
			this.lblBillAmount.Name = "lblBillAmount";
			this.lblBillAmount.Size = new System.Drawing.Size(145, 58);
			this.lblBillAmount.TabIndex = 6;
			this.lblBillAmount.Text = "0.00 ₺";
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
			this.panel4.Controls.Add(this.lblBillAmount);
			this.panel4.Controls.Add(this.lblBillTitle);
			this.panel4.Location = new System.Drawing.Point(673, 116);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(267, 142);
			this.panel4.TabIndex = 13;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(28, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(278, 24);
			this.label1.TabIndex = 8;
			this.label1.Text = "Dashboard / Genel Bakış Formu";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(6, 26);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1319, 66);
			this.panel2.TabIndex = 11;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(17, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(147, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = "Toplam Bakiyem";
			// 
			// lblTotalBalance
			// 
			this.lblTotalBalance.AutoSize = true;
			this.lblTotalBalance.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblTotalBalance.ForeColor = System.Drawing.Color.White;
			this.lblTotalBalance.Location = new System.Drawing.Point(45, 58);
			this.lblTotalBalance.Name = "lblTotalBalance";
			this.lblTotalBalance.Size = new System.Drawing.Size(217, 58);
			this.lblTotalBalance.TabIndex = 6;
			this.lblTotalBalance.Text = "0000.00 ₺";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
			this.panel3.Controls.Add(this.lblTotalBalance);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Location = new System.Drawing.Point(371, 116);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(267, 142);
			this.panel3.TabIndex = 12;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(17, 15);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(160, 20);
			this.label7.TabIndex = 5;
			this.label7.Text = "Gelen Son Havale";
			// 
			// lblLastBankProcessAmount
			// 
			this.lblLastBankProcessAmount.AutoSize = true;
			this.lblLastBankProcessAmount.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblLastBankProcessAmount.ForeColor = System.Drawing.Color.White;
			this.lblLastBankProcessAmount.Location = new System.Drawing.Point(47, 46);
			this.lblLastBankProcessAmount.Name = "lblLastBankProcessAmount";
			this.lblLastBankProcessAmount.Size = new System.Drawing.Size(145, 58);
			this.lblLastBankProcessAmount.TabIndex = 6;
			this.lblLastBankProcessAmount.Text = "0.00 ₺";
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
			this.panel5.Controls.Add(this.lblLastBankProcessAmount);
			this.panel5.Controls.Add(this.label7);
			this.panel5.Location = new System.Drawing.Point(975, 116);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(267, 142);
			this.panel5.TabIndex = 14;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// chart1
			// 
			chartArea13.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea13);
			legend13.Name = "Legend1";
			this.chart1.Legends.Add(legend13);
			this.chart1.Location = new System.Drawing.Point(371, 379);
			this.chart1.Name = "chart1";
			series13.ChartArea = "ChartArea1";
			series13.Legend = "Legend1";
			series13.Name = "Series1";
			this.chart1.Series.Add(series13);
			this.chart1.Size = new System.Drawing.Size(409, 300);
			this.chart1.TabIndex = 15;
			this.chart1.Text = "chart1";
			// 
			// chart2
			// 
			chartArea14.Name = "ChartArea1";
			this.chart2.ChartAreas.Add(chartArea14);
			legend14.Name = "Legend1";
			this.chart2.Legends.Add(legend14);
			this.chart2.Location = new System.Drawing.Point(831, 379);
			this.chart2.Name = "chart2";
			series14.ChartArea = "ChartArea1";
			series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
			series14.Legend = "Legend1";
			series14.Name = "Faturalar";
			this.chart2.Series.Add(series14);
			this.chart2.Size = new System.Drawing.Size(411, 300);
			this.chart2.TabIndex = 16;
			this.chart2.Text = "chart2";
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.Silver;
			this.panel6.Controls.Add(this.label3);
			this.panel6.Location = new System.Drawing.Point(371, 278);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(409, 77);
			this.panel6.TabIndex = 17;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(17, 17);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(347, 42);
			this.label3.TabIndex = 7;
			this.label3.Text = "Banka ve banka hesaplarındaki para miktarlarına\r\naşağıdaki grafikten ulaşabilirsi" +
    "niz.";
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.Silver;
			this.panel7.Controls.Add(this.label4);
			this.panel7.Location = new System.Drawing.Point(833, 278);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(409, 77);
			this.panel7.TabIndex = 18;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(31, 17);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(338, 42);
			this.label4.TabIndex = 8;
			this.label4.Text = "Ödenen ve ödenmesi gereken fatura tutarlarına\r\naşağıdaki grafikten ulaşabilirsini" +
    "z.";
			// 
			// FrmDashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1300, 708);
			this.Controls.Add(this.panel7);
			this.Controls.Add(this.panel6);
			this.Controls.Add(this.chart2);
			this.Controls.Add(this.chart1);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel1);
			this.Name = "FrmDashboard";
			this.Text = "Dashboard Formu";
			this.Load += new System.EventHandler(this.FrmDashboard_Load);
			this.panel1.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.panel7.ResumeLayout(false);
			this.panel7.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnBanksForm;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblBillTitle;
		private System.Windows.Forms.Label lblBillAmount;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblTotalBalance;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lblLastBankProcessAmount;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}

