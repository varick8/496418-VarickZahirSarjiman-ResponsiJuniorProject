namespace Responsi2Junpro
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            label1 = new Label();
            label2 = new Label();
            tbName = new TextBox();
            cbDept = new ComboBox();
            tbPost = new TextBox();
            tbSalary = new TextBox();
            label3 = new Label();
            label4 = new Label();
            listBox1 = new ListBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnDelete = new Button();
            dgvData = new DataGridView();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            btnEdit = new Button();
            btnInsert = new Button();
            btnLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(96, 95);
            label1.Name = "label1";
            label1.Size = new Size(50, 17);
            label1.TabIndex = 0;
            label1.Text = "Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 136);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 1;
            label2.Text = "Departement :";
            // 
            // tbName
            // 
            tbName.Location = new Point(152, 92);
            tbName.Name = "tbName";
            tbName.Size = new Size(100, 23);
            tbName.TabIndex = 2;
            // 
            // cbDept
            // 
            cbDept.FormattingEnabled = true;
            cbDept.Items.AddRange(new object[] { "HR", "ENG", "DEV", "PM", "FIN" });
            cbDept.Location = new Point(152, 133);
            cbDept.Name = "cbDept";
            cbDept.Size = new Size(100, 23);
            cbDept.TabIndex = 3;
            // 
            // tbPost
            // 
            tbPost.Location = new Point(357, 89);
            tbPost.Name = "tbPost";
            tbPost.Size = new Size(100, 23);
            tbPost.TabIndex = 4;
            // 
            // tbSalary
            // 
            tbSalary.Location = new Point(357, 133);
            tbSalary.Name = "tbSalary";
            tbSalary.Size = new Size(100, 23);
            tbSalary.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(292, 92);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 6;
            label3.Text = "Position :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(304, 136);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 7;
            label4.Text = "Salary :";
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.Control;
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 17;
            listBox1.Items.AddRange(new object[] { "HR : Human Resources", "ENG : Engineer", "DEV : Developer", "PM : Product Manager", "FIN : Finance" });
            listBox1.Location = new Point(6, 17);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(155, 85);
            listBox1.TabIndex = 8;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(538, 200);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(167, 34);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dgvData.AllowUserToDeleteRows = false;
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.EnableHeadersVisualStyles = false;
            dgvData.Location = new Point(64, 254);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvData.RowHeadersVisible = false;
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvData.Size = new Size(641, 156);
            dgvData.TabIndex = 12;
            dgvData.CellContentClick += dgvData_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.employee;
            pictureBox1.Location = new Point(25, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(258, 25);
            label5.Name = "label5";
            label5.Size = new Size(263, 25);
            label5.TabIndex = 15;
            label5.Text = "Employee Management App";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBox1);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(538, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(167, 112);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Departement";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(304, 200);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(167, 34);
            btnEdit.TabIndex = 17;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(64, 200);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(167, 34);
            btnInsert.TabIndex = 18;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(538, 427);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(167, 34);
            btnLoad.TabIndex = 19;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 473);
            Controls.Add(btnLoad);
            Controls.Add(btnInsert);
            Controls.Add(btnEdit);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(dgvData);
            Controls.Add(btnDelete);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tbSalary);
            Controls.Add(tbPost);
            Controls.Add(cbDept);
            Controls.Add(tbName);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMain";
            Text = "Employee Management App";
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbName;
        private ComboBox cbDept;
        private TextBox tbPost;
        private TextBox tbSalary;
        private Label label3;
        private Label label4;
        private ListBox listBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnDelete;
        private DataGridView dgvData;
        private PictureBox pictureBox1;
        private Label label5;
        private GroupBox groupBox1;
        private Button btnEdit;
        private Button btnInsert;
        private Button btnLoad;
    }
}
