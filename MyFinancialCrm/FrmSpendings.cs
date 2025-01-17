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
	public partial class FrmSpendings : Form
	{
		public FrmSpendings()
		{
			InitializeComponent();
		}
		FinancialCrmDbEntities db = new FinancialCrmDbEntities();

	
		private void btnSpandingList_Click(object sender, EventArgs e)
		{
			var values = db.Spendings.ToList();
			dataGridView1.DataSource = values;
		}

		private void btnSpandingCreate_Click(object sender, EventArgs e)
		{
			string title = txtSpendingTitle.Text;
			decimal amount = decimal.Parse(txtSpendingAmount.Text);
			DateTime period = DateTime.Parse(txtSpendingDate.Text);
			int categoryId = int.Parse(txtSpendingCategory.Text);


			Spendings spendings = new Spendings();
			spendings.SpendingDate = period;
			spendings.SpendingTitle = title;
			spendings.SpendingAmount = amount;
			spendings.CategoryId = categoryId;
			db.Spendings.Add(spendings);
			db.SaveChanges();
			MessageBox.Show("Gider Başarılı Bir Şekilde Sisteme Eklendi", "Giderler", MessageBoxButtons.OK, MessageBoxIcon.Information);

			var values = db.Spendings.ToList();
			dataGridView1.DataSource = values;
		}

		private void btnRemoveSpending_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtSpendingId.Text);
			var removeValue = db.Spendings.Find(id);
			db.Spendings.Remove(removeValue);
			db.SaveChanges();
			db.SaveChanges();
			MessageBox.Show("Gider Başarılı Bir Şekilde Sistemen Silindi", "Giderler", MessageBoxButtons.OK, MessageBoxIcon.Information);

			var values = db.Spendings.ToList();
			dataGridView1.DataSource = values;
		}

		private void btnUpdateSpending_Click(object sender, EventArgs e)
		{
			string title = txtSpendingTitle.Text;
			decimal amount = decimal.Parse(txtSpendingAmount.Text);
			DateTime period = DateTime.Parse(txtSpendingDate.Text);
			int id = int.Parse(txtSpendingId.Text);
			var values = db.Spendings.Find(id);


			values.SpendingTitle = title;
			values.SpendingAmount = amount;
			values.SpendingDate = period;
			db.SaveChanges();
			MessageBox.Show("Gider Başarılı Bir Şekilde Sistemde Güncellendi", "Giderler", MessageBoxButtons.OK, MessageBoxIcon.Information);

			var values2 = db.Spendings.ToList();
			dataGridView1.DataSource = values2;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			FrmCategories frm = new FrmCategories();
			frm.Show();
		}

		private void btnBanksForm_Click(object sender, EventArgs e)
		{
			this.Hide();
			FrmBanks frm = new FrmBanks();
			frm.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Hide();
			FrmBilling frm = new FrmBilling();
			frm.Show();
		}

		private void button5_Click(object sender, EventArgs e)
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

		private void button7_Click(object sender, EventArgs e)
		{
			this.Hide();
			FrmSettings frm = new FrmSettings();
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
