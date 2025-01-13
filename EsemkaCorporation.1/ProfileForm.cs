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
    public partial class ProfileForm : Form
    {
        DBEntities db  = new DBEntities();
        position profile = null;
        position supervisor;
        public ProfileForm(position profile = null)
        {
            InitializeComponent();
            if (profile != null)
            {
                this.profile = profile;
            }
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            position data;
            if (profile == null) data = db.positions.First(s => s.employee.id == Variable.employee.id);
            else data = db.positions.First(s => s.employee.id == profile.employee.id);
            supervisor = db.positions.FirstOrDefault(s => s.job.id == data.job.supervisor_job_id && s.employee.id != data.employee.id && s.deleted_at == null);
            
            if (supervisor != null) linkLabel1.Text = supervisor.employee.name; 
            else linkLabel1.Visible = false;

            tbName.Text = data.employee.name;
            tbEmail.Text = data.employee.email;
            tbPhoneNumber.Text = data.employee.phone_number;
            tbHireDate.Text = data.employee.hire_date.ToString("MM/dd/yyyy");
            tbPosition.Text = data.job.name;
            tbJobLevel.Text = data.job.job_level.name;
            tbDepartement.Text = data.job.department.name;

            var jobHistory = db.positions.Where(s => s.employee_id == data.employee_id && s.deleted_at != null);
            foreach (var i in jobHistory)
            {
                dgvHistory.Rows.Add(i.job.department.name, i.job.name);
            }

            var subordinate = db.positions.Where(s => s.job.supervisor_job_id == data.job_id && s.deleted_at == null && s.job.id != data.job_id);
            foreach (var i in subordinate)
            {
                dgvSubordinate.Rows.Add(i.employee.name, i.job.name);
            }

            var workWith = db.positions.Where(s => s.job.supervisor_job_id == data.job.supervisor_job_id && s.deleted_at == null && s.job.id != data.job_id);
            foreach (var i in workWith)
            {
                dgvWorkWith.Rows.Add(i.employee.name, i.job.name);
            }
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
            new ProfileForm(supervisor).Show();
        }
    }
}
