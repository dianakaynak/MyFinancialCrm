using MyFinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFinancialCrm
{
	public partial class FrmSettings : Form
	{
		public FrmSettings()
		{
			InitializeComponent();
		}
		FinancialCrmDbEntities db = new FinancialCrmDbEntities();
		private void btnPassword_Click(object sender, EventArgs e)
		{
			string currentUsername = "admin";

			var user = db.Users.FirstOrDefault(u => u.UserName == currentUsername);
			if (user == null)
			{
				MessageBox.Show("Kullanıcı bulunamadı!");
				return;
			}


			if (txtOldPassword.Text != user.Password)
			{
				MessageBox.Show("Eski şifre hatalı!");
				return;
			}

			if (txtNewPassword.Text != txtConfirmPassword.Text)
			{
				MessageBox.Show("Yeni şifreler eşleşmiyor!");
				return;
			}


			user.Password = txtNewPassword.Text;
			db.SaveChanges();

			MessageBox.Show("Şifre başarıyla değiştirildi!");
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			FrmCategories frm = new FrmCategories();
			frm.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
			FrmBanks frm = new FrmBanks();
			frm.Show();
		}

		private void btnBillForm_Click(object sender, EventArgs e)
		{
			this.Hide();
			FrmBilling frm = new FrmBilling();
			frm.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Hide();
			FrmSpendings frm = new FrmSpendings();
			frm.Show();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.Hide();
			FrmBankProcesses frm = new FrmBankProcesses();
			frm.Show();

		}

		private void button6_Click(object sender, EventArgs e)
		{
			this.Hide();
			FrmDashboard frm = new FrmDashboard();
			frm.Show();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			this.Hide();
			FrmLogin frm = new FrmLogin();
			frm.Show();
		}
	}
}

