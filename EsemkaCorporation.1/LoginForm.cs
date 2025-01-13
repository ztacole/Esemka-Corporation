using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsemkaCorporation._1
{
    public partial class LoginForm : Form
    {
        DBEntities db = new DBEntities();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var login = db.employees.First(s=>s.email == tbEmail.Text && s.deleted_at == null);
                if (login.password != tbPass.Text)
                {
                    lblError.Text = "  Wrong password!";
                    lblError.Visible = true;
                    return;
                }
                Variable.employee = login;
                lblError.Visible=false;
                new MainForm().Show();
            }
            catch
            {
                lblError.Text = "Employee not found!";
                lblError.Visible = true;
                return;
            }
        }
    }
}
