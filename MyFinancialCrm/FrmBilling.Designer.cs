namespace MyFinancialCrm
{
	partial class FrmBilling
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.button8 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.btnBanksForm = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnUpdateBill = new System.Windows.Forms.Button();
			this.btnRemoveBill = new System.Windows.Forms.Button();
			this.btnCreateBill = new System.Windows.Forms.Button();
			this.btnBillList = new System.Windows.Forms.Button();
			this.txtBillPeriod = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtBillAmount = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtBillTitle = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtBillId = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
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
			this.panel1.Location = new System.Drawing.Point(3, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(309, 663);
			this.panel1.TabIndex = 1;
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
			this.button6.Click += new System.EventHandler(this.button6_Click);
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
			this.button5.Click += new System.EventHandler(this.button5_Click);
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
			// panel2
			// 
			this.panel2.Controls.Add(this.btnUpdateBill);
			this.panel2.Controls.Add(this.btnRemoveBill);
			this.panel2.Controls.Add(this.btnCreateBill);
			this.panel2.Controls.Add(this.btnBillList);
			this.panel2.Controls.Add(this.txtBillPeriod);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.txtBillAmount);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.txtBillTitle);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.txtBillId);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(318, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(970, 270);
			this.panel2.TabIndex = 2;
			// 
			// btnUpdateBill
			// 
			this.btnUpdateBill.BackColor = System.Drawing.Color.DarkGray;
			this.btnUpdateBill.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnUpdateBill.ForeColor = System.Drawing.Color.Black;
			this.btnUpdateBill.Location = new System.Drawing.Point(657, 206);
			this.btnUpdateBill.Name = "btnUpdateBill";
			this.btnUpdateBill.Size = new System.Drawing.Size(166, 61);
			this.btnUpdateBill.TabIndex = 11;
			this.btnUpdateBill.Text = "Güncelle";
			this.btnUpdateBill.UseVisualStyleBackColor = false;
			this.btnUpdateBill.Click += new System.EventHandler(this.btnUpdateBill_Click);
			// 
			// btnRemoveBill
			// 
			this.btnRemoveBill.BackColor = System.Drawing.Color.DarkGray;
			this.btnRemoveBill.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnRemoveBill.ForeColor = System.Drawing.Color.Black;
			this.btnRemoveBill.Location = new System.Drawing.Point(483, 206);
			this.btnRemoveBill.Name = "btnRemoveBill";
			this.btnRemoveBill.Size = new System.Drawing.Size(166, 61);
			this.btnRemoveBill.TabIndex = 10;
			this.btnRemoveBill.Text = "Ödeme Sil";
			this.btnRemoveBill.UseVisualStyleBackColor = false;
			this.btnRemoveBill.Click += new System.EventHandler(this.btnRemoveBill_Click);
			// 
			// btnCreateBill
			// 
			this.btnCreateBill.BackColor = System.Drawing.Color.DarkGray;
			this.btnCreateBill.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnCreateBill.ForeColor = System.Drawing.Color.Black;
			this.btnCreateBill.Location = new System.Drawing.Point(303, 206);
			this.btnCreateBill.Name = "btnCreateBill";
			this.btnCreateBill.Size = new System.Drawing.Size(166, 61);
			this.btnCreateBill.TabIndex = 9;
			this.btnCreateBill.Text = "Yeni Ödeme";
			this.btnCreateBill.UseVisualStyleBackColor = false;
			this.btnCreateBill.Click += new System.EventHandler(this.btnCreateBill_Click);
			// 
			// btnBillList
			// 
			this.btnBillList.BackColor = System.Drawing.Color.DarkGray;
			this.btnBillList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnBillList.ForeColor = System.Drawing.Color.Black;
			this.btnBillList.Location = new System.Drawing.Point(121, 206);
			this.btnBillList.Name = "btnBillList";
			this.btnBillList.Size = new System.Drawing.Size(166, 61);
			this.btnBillList.TabIndex = 8;
			this.btnBillList.Text = "Ödeme Listesi";
			this.btnBillList.UseVisualStyleBackColor = false;
			this.btnBillList.Click += new System.EventHandler(this.btnBillList_Click);
			// 
			// txtBillPeriod
			// 
			this.txtBillPeriod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(215)))), ((int)(((byte)(148)))));
			this.txtBillPeriod.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtBillPeriod.Location = new System.Drawing.Point(121, 168);
			this.txtBillPeriod.Name = "txtBillPeriod";
			this.txtBillPeriod.Size = new System.Drawing.Size(802, 32);
			this.txtBillPeriod.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(38, 171);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(74, 24);
			this.label4.TabIndex = 6;
			this.label4.Text = "Periyot:";
			// 
			// txtBillAmount
			// 
			this.txtBillAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(215)))), ((int)(((byte)(148)))));
			this.txtBillAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtBillAmount.Location = new System.Drawing.Point(121, 115);
			this.txtBillAmount.Name = "txtBillAmount";
			this.txtBillAmount.Size = new System.Drawing.Size(802, 32);
			this.txtBillAmount.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(42, 118);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 24);
			this.label3.TabIndex = 4;
			this.label3.Text = "Miktar:";
			// 
			// txtBillTitle
			// 
			this.txtBillTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(215)))), ((int)(((byte)(148)))));
			this.txtBillTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtBillTitle.Location = new System.Drawing.Point(121, 65);
			this.txtBillTitle.Name = "txtBillTitle";
			this.txtBillTitle.Size = new System.Drawing.Size(802, 32);
			this.txtBillTitle.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(49, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 24);
			this.label2.TabIndex = 2;
			this.label2.Text = "Başlık:";
			// 
			// txtBillId
			// 
			this.txtBillId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(215)))), ((int)(((byte)(148)))));
			this.txtBillId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtBillId.Location = new System.Drawing.Point(121, 14);
			this.txtBillId.Name = "txtBillId";
			this.txtBillId.Size = new System.Drawing.Size(802, 32);
			this.txtBillId.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(16, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ödeme Id:";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.dataGridView1);
			this.panel3.Location = new System.Drawing.Point(319, 288);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(981, 355);
			this.panel3.TabIndex = 3;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(981, 355);
			this.dataGridView1.TabIndex = 0;
			// 
			// FrmBilling
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(1300, 670);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "FrmBilling";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ödeme & Fatura Formu";
			this.Load += new System.EventHandler(this.FrmBilling_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button btnBanksForm;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox txtBillId;
		private System.Windows.Forms.Button btnBillList;
		private System.Windows.Forms.TextBox txtBillPeriod;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtBillAmount;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtBillTitle;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnUpdateBill;
		private System.Windows.Forms.Button btnRemoveBill;
		private System.Windows.Forms.Button btnCreateBill;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}