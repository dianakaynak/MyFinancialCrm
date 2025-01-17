using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyFinancialCrm.Models;

namespace MyFinancialCrm
{
	public partial class FrmBilling : Form
	{
		public FrmBilling()
		{
			InitializeComponent();
		}
		FinancialCrmDbEntities db = new FinancialCrmDbEntities();
		private void FrmBilling_Load(object sender, EventArgs e)
		{
			var values = db.Bills.ToList();
			dataGridView1.DataSource = values;
		}

		private void btnBillList_Click(object sender, EventArgs e)
		{
			var values = db.Bills.ToList();
			dataGridView1.DataSource = values;
		}

		private void btnCreateBill_Click(object sender, EventArgs e)
		{
			string title = txtBillTitle.Text;
			decimal amount = decimal.Parse(txtBillAmount.Text);
			string period = txtBillPeriod.Text;

			Bills bills = new Bills();
			bills.BillTitle = title;
			bills.BillAmount = amount;
			bills.BillPeriod = period;
			db.Bills.Add(bills);
			db.SaveChanges();
			MessageBox.Show("Ödeme Başarılı Bir Şekilde Sisteme Eklendi", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

			var values = db.Bills.ToList();
			dataGridView1.DataSource = values;
		}

		private void btnRemoveBill_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtBillId.Text);
			var removeValue = db.Bills.Find(id);
			db.Bills.Remove(removeValue);
			db.SaveChanges();
			db.SaveChanges();
			MessageBox.Show("Ödeme Başarılı Bir Şekilde Sistemen Silindi", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

			var values = db.Bills.ToList();
			dataGridView1.DataSource = values;

		}

		private void btnUpdateBill_Click(object sender, EventArgs e)
		{
			string title = txtBillTitle.Text;
			decimal amount = decimal.Parse(txtBillAmount.Text);
			string period = txtBillPeriod.Text;
			int id = int.Parse(txtBillId.Text);
			var values = db.Bills.Find(id);


			values.BillTitle = title;
			values.BillAmount = amount;
			values.BillPeriod = period;
			db.SaveChanges();
			MessageBox.Show("Ödeme Başarılı Bir Şekilde Sistemde Güncellendi", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

			var values2 = db.Bills.ToList();
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

		private void button4_Click(object sender, EventArgs e)
		{

			this.Hide();
			FrmSpendings frm = new FrmSpendings();
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
