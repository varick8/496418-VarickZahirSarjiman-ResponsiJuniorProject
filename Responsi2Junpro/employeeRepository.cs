using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Npgsql;

namespace Responsi2Junpro
{
    // emplyoyeeRepository inheritance dari employee
    internal class employeeRepository : employee
    {
        private const string conn = "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=Responsi2Junpro"; 
        private static NpgsqlConnection connection;
        private static NpgsqlCommand cmd;
        private static DataTable dt;

        private DataGridView dgvData;
        private DataGridViewRow row;

        public DataGridViewRow Row { set { row = value; } }

        public employeeRepository(DataGridView _dgvData)
        {
            dgvData = _dgvData;
        }

        private Dictionary<string, string> departmentMapping =
        new Dictionary<string, string>()
        {
        { "HR", "Human Resources" },
        { "ENG", "Engineer" },
        { "DEV", "Sales Department" },
        { "FIN", "Finance" },
        { "PM", "Product Manager" },
        };

        //Load 
        public void Load()
        {
            connection = new NpgsqlConnection(conn);
            try
            {
                connection.Open();
                dgvData.DataSource = null;
                dt = new DataTable();
                string sql = "SELECT * FROM emp_select() ORDER BY id"; 
                cmd = new NpgsqlCommand(sql, connection);

                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgvData.DataSource = dt;
                dgvData.ClearSelection();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
            finally { connection.Close(); }
        }

        //Insert 
        public void Insert(TextBox tbName, ComboBox cbDept, TextBox tbPost, TextBox tbSalary, Button btnLoad)
        {
            using (var connection = new NpgsqlConnection(conn))
            {
                try
                {
                    connection.Open();

                    string fullDeptName = departmentMapping.ContainsKey(cbDept.Text) ? departmentMapping[cbDept.Text] : cbDept.Text;

                    if (string.IsNullOrWhiteSpace(tbName.Text))
                    {
                        MessageBox.Show("Employee name cannot be empty."); 
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(cbDept.Text))
                    {
                        MessageBox.Show("Department cannot be empty."); 
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(tbPost.Text))
                    {
                        MessageBox.Show("Position cannot be empty.");
                        return;
                    }

                    if (!decimal.TryParse(tbSalary.Text, out decimal salary))
                    {
                        MessageBox.Show("Invalid salary value.");
                        return;
                    }

                    string sql = @"SELECT emp_insert(:_name_emp, :_name_dept, :_name_post, :_salary)";

                    using (var cmd = new NpgsqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("_name_emp", tbName.Text);
                        cmd.Parameters.AddWithValue("_name_dept", fullDeptName);
                        cmd.Parameters.AddWithValue("_name_post", tbPost.Text);
                        cmd.Parameters.AddWithValue("_salary", salary);

                        int result = Convert.ToInt32(cmd.ExecuteScalar());

                        if (result > 0)
                        {
                            MessageBox.Show("Data successfully added");

                            tbName.Text = string.Empty;
                            cbDept.Text = string.Empty;
                            tbPost.Text = string.Empty;
                            tbSalary.Text = string.Empty;

                            btnLoad.PerformClick();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add data");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: { ex.Message} "); 
                }
            }
        }

        //Edit 
        public void Edit(TextBox tbName, ComboBox cbDept, TextBox tbPost, TextBox tbSalary, Button btnLoad)
        {
            if (row == null)
            {
                MessageBox.Show("Please select a row to edit", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                MessageBox.Show("Employee name cannot be empty", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(cbDept.Text))
            {
                MessageBox.Show("Department cannot be empty", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbPost.Text))
            {
                MessageBox.Show("Position cannot be empty", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(tbSalary.Text, out decimal salary))
            {
                MessageBox.Show("Invalid salary value", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return;
            }

            string fullDeptName = departmentMapping.ContainsKey(cbDept.Text) ? departmentMapping[cbDept.Text] : cbDept.Text;

            using (var connection = new NpgsqlConnection(conn))
            {
                try
                {
                    connection.Open();

                    string sql = @"SELECT * FROM emp_update(:_id_emp, :_name_emp, :_name_dept, :_name_post, :_salary)";

                    using (var cmd = new NpgsqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("_id_emp", Convert.ToInt32(row.Cells["id"].Value));
                        cmd.Parameters.AddWithValue("_name_emp", tbName.Text);
                        cmd.Parameters.AddWithValue("_name_dept", fullDeptName);
                        cmd.Parameters.AddWithValue("_name_post", tbPost.Text);
                        cmd.Parameters.AddWithValue("_salary", salary);

                        int result = Convert.ToInt32(cmd.ExecuteScalar());

                        if (result == 1)
                        {
                            MessageBox.Show("Data successfully updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            tbName.Text = string.Empty;
                            cbDept.Text = string.Empty;
                            tbPost.Text = string.Empty;
                            tbSalary.Text = string.Empty;

                            row = null;

                            btnLoad.PerformClick();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update employee. Employee not found.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Delete 
        public void Delete(TextBox tbName, ComboBox cbDept, TextBox tbPost, TextBox tbSalary, Button btnLoad)
        {
            if (row == null)
            {
                MessageBox.Show("Please select a row to delete");
                return;
            }

            using (var connection = new NpgsqlConnection(conn))
            {
                try
                {
                    connection.Open();

                    string sql = "SELECT * FROM emp_delete(:id_emp)"; 
                    using (var cmd = new NpgsqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("id_emp", Convert.ToInt32(row.Cells["id"].Value));

                        int result = Convert.ToInt32(cmd.ExecuteScalar());

                        if (result == 1)
                        {
                            MessageBox.Show("Data successfully deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            tbName.Text = string.Empty;
                            cbDept.Text = string.Empty;
                            tbPost.Text = string.Empty;
                            tbSalary.Text = string.Empty;
                            row = null;

                            btnLoad.PerformClick();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete. Employee ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
