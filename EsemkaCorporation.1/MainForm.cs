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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome, {Variable.employee.name}";

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            new ProfileForm().Show();
        }

        private void btnMutation_Click(object sender, EventArgs e)
        {
            new MutationForm().Show();
        }

        private void btnPromotion_Click(object sender, EventArgs e)
        {
            new PromotionForm().Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
