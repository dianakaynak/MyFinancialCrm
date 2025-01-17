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
	public partial class FrmLogin : Form
	{
		public FrmLogin()
		{
			InitializeComponent();
		}


		private void btnLogin_Click(object sender, EventArgs e)
		{
			string username = txtUserName.Text;
			string password = txtPassword.Text;

			using (var context = new FinancialCrmDbEntities())
			{
				var user = context.Users
								  .FirstOrDefault(u => u.UserName == username && u.Password == password);

				if (user != null)
				{
					
					MessageBox.Show("Giriş Başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

					
					FrmDashboard dashboardForm = new FrmDashboard();
					dashboardForm.Show();

					this.Hide();
				}
				else
				{
					
					MessageBox.Show("Geçersiz kullanıcı adı veya şifre!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

	}
}

