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
using MyFinancialCrm.Models;

namespace MyFinancialCrm
{
	public partial class FrmCategories : Form
	{
		public FrmCategories()
		{
			InitializeComponent();
		}
		FinancialCrmDbEntities db = new FinancialCrmDbEntities();
		private void FrmCategories_Load(object sender, EventArgs e)
		{
			var values = db.Categories.ToList();
			dataGridView1.DataSource = values;
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
