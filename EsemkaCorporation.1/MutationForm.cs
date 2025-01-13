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
    public partial class MutationForm : Form
    {
        DBEntities db = new DBEntities();
        public MutationForm()
        {
            InitializeComponent();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MutationForm_Load(object sender, EventArgs e)
        {
            var data = db.positions.First(s => s.employee_id == Variable.employee.id);
            tbName.Text = data.employee.name;
            tbDepartement.Text = data.job.department.name;
            tbPosition.Text = data.job.name;
            tbJobLevel.Text = data.job.job_level.name;

            var listMutation = db.positions.Where(s=> s.deleted_at == null && s.job.job_level_id == data.job.job_level_id && s.job.head_count > (db.positions.Count(x=>x.job_id == s.job_id)));
            foreach (var i in listMutation)
            {
                dataGridView1.Rows.Add(i.job_id, i.job.department.name, i.job.name);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Action")
            {
                int id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                var check = db.mutations.Any(s=>s.job_id==id && s.employee_id == Variable.employee.id);
                if (check)
                {
                    MessageBox.Show("You have been applied for this job");
                    return;
                }
                if (MessageBox.Show("Are you sure?", "Confimation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var newMutation = new mutation
                    {
                        job_id = id,
                        employee_id = Variable.employee.id,
                        status = "P",
                        created_at = DateTime.Now,
                    };
                    db.mutations.Add(newMutation);
                    db.SaveChanges();
                }
            }
        }
    }
}
