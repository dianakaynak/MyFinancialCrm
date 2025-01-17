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
	public partial class FrmBankProcesses : Form
	{
		public FrmBankProcesses()
		{
			InitializeComponent();
		}
		FinancialCrmDbEntities db = new FinancialCrmDbEntities();
		private void FrmBankProcesses_Load(object sender, EventArgs e)
		{
			var values = db.BankProcesses.ToList();
			dataGridView1.DataSource = values;
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
