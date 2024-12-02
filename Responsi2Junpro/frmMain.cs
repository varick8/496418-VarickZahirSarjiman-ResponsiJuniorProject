using Npgsql;
using System;
using System.Data;

namespace Responsi2Junpro
{
    public partial class frmMain : Form
    {
        public static NpgsqlCommand cmd;

        public DataTable dt;
        private DataGridViewRow r;

        private employee emp;
        private employeeRepository employeeRepository;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Editing Employee: {emp.Name}, Department: {emp.Departement}, position: {emp.Position}");
            employeeRepository.Edit(tbName, cbDept, tbPost, tbSalary, btnLoad);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            employeeRepository.Insert(tbName, cbDept, tbPost, tbSalary, btnLoad);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show($"Are you sure you want to delete {emp.Name}?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                employeeRepository.Delete(tbName, cbDept, tbPost, tbSalary, btnLoad);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            employeeRepository.Load();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            employeeRepository = new employeeRepository(dgvData);
            emp = new employee();
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvData.Rows[e.RowIndex];
                tbName.Text = r.Cells["name"].Value.ToString();
                cbDept.Text = r.Cells["departement"].Value.ToString();
                tbPost.Text = r.Cells["position"].Value.ToString();
                tbSalary.Text = r.Cells["salary"].Value.ToString();

                employeeRepository.Row = r;
                emp.Name = r.Cells["name"].Value.ToString();
                emp.Departement = r.Cells["departement"].Value.ToString();
                emp.Position = r.Cells["position"].Value.ToString();
                MessageBox.Show($"Selected Employee: {emp.Name}");
            }
        }
    }
}
