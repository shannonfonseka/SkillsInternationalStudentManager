namespace SkillsInternationalStudentManager
{
    partial class frmStudentsManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            btnRefreshDB = new LinkLabel();
            btnManageTeachers = new LinkLabel();
            btnManageParents = new LinkLabel();
            pictureBox1 = new PictureBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnAddStudent = new Button();
            btnEditStudent = new Button();
            btnPrintList = new Button();
            btnRemoveStudent = new Button();
            lstbxStudentName = new ListBox();
            lstbxStudentRegNo = new ListBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.Fixed3D;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(2);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(flowLayoutPanel1);
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            splitContainer1.Panel1MinSize = 100;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(flowLayoutPanel2);
            splitContainer1.Size = new Size(786, 442);
            splitContainer1.SplitterDistance = 160;
            splitContainer1.SplitterWidth = 3;
            splitContainer1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(btnRefreshDB);
            flowLayoutPanel1.Controls.Add(btnManageTeachers);
            flowLayoutPanel1.Controls.Add(btnManageParents);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(156, 124);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(2, 8);
            label1.Margin = new Padding(2, 8, 2, 16);
            label1.Name = "label1";
            label1.Size = new Size(107, 19);
            label1.TabIndex = 3;
            label1.Text = "Common tasks";
            // 
            // btnRefreshDB
            // 
            btnRefreshDB.AutoSize = true;
            btnRefreshDB.Location = new Point(2, 43);
            btnRefreshDB.Margin = new Padding(2, 0, 2, 12);
            btnRefreshDB.Name = "btnRefreshDB";
            btnRefreshDB.Size = new Size(96, 15);
            btnRefreshDB.TabIndex = 0;
            btnRefreshDB.TabStop = true;
            btnRefreshDB.Text = "Refresh database";
            // 
            // btnManageTeachers
            // 
            btnManageTeachers.AutoSize = true;
            btnManageTeachers.Location = new Point(2, 70);
            btnManageTeachers.Margin = new Padding(2, 0, 2, 12);
            btnManageTeachers.Name = "btnManageTeachers";
            btnManageTeachers.Size = new Size(97, 15);
            btnManageTeachers.TabIndex = 2;
            btnManageTeachers.TabStop = true;
            btnManageTeachers.Text = "Manage teachers";
            // 
            // btnManageParents
            // 
            btnManageParents.AutoSize = true;
            btnManageParents.Location = new Point(2, 97);
            btnManageParents.Margin = new Padding(2, 0, 2, 12);
            btnManageParents.Name = "btnManageParents";
            btnManageParents.Size = new Size(149, 15);
            btnManageParents.TabIndex = 4;
            btnManageParents.TabStop = true;
            btnManageParents.Text = "Manage parents/guardians";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Dock = DockStyle.Bottom;
            pictureBox1.Image = Properties.Resources._90sstudent_bg;
            pictureBox1.Location = new Point(0, 306);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 132);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.Controls.Add(label2);
            flowLayoutPanel2.Controls.Add(label3);
            flowLayoutPanel2.Controls.Add(tableLayoutPanel1);
            flowLayoutPanel2.Controls.Add(lstbxStudentName);
            flowLayoutPanel2.Controls.Add(lstbxStudentRegNo);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Margin = new Padding(2);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(619, 438);
            flowLayoutPanel2.TabIndex = 0;
            flowLayoutPanel2.WrapContents = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 10);
            label2.Margin = new Padding(10, 10, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(129, 21);
            label2.TabIndex = 4;
            label2.Text = "Manage students";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 36);
            label3.Margin = new Padding(10, 5, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(453, 15);
            label3.TabIndex = 5;
            label3.Text = "Add, edit or manage students on this page. Administrators can access these features.";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ActiveCaption;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(btnAddStudent, 0, 0);
            tableLayoutPanel1.Controls.Add(btnEditStudent, 1, 0);
            tableLayoutPanel1.Controls.Add(btnPrintList, 3, 0);
            tableLayoutPanel1.Controls.Add(btnRemoveStudent, 2, 0);
            tableLayoutPanel1.Location = new Point(8, 59);
            tableLayoutPanel1.Margin = new Padding(8, 8, 8, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(584, 28);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Image = Properties.Resources.plus;
            btnAddStudent.Location = new Point(2, 2);
            btnAddStudent.Margin = new Padding(2);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(106, 23);
            btnAddStudent.TabIndex = 1;
            btnAddStudent.Text = "Add student";
            btnAddStudent.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnEditStudent
            // 
            btnEditStudent.Enabled = false;
            btnEditStudent.Image = Properties.Resources.pencil;
            btnEditStudent.Location = new Point(112, 2);
            btnEditStudent.Margin = new Padding(2);
            btnEditStudent.Name = "btnEditStudent";
            btnEditStudent.Size = new Size(110, 23);
            btnEditStudent.TabIndex = 2;
            btnEditStudent.Text = "Edit student";
            btnEditStudent.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnEditStudent.UseVisualStyleBackColor = true;
            // 
            // btnPrintList
            // 
            btnPrintList.Enabled = false;
            btnPrintList.Image = Properties.Resources.printer;
            btnPrintList.Location = new Point(360, 2);
            btnPrintList.Margin = new Padding(2);
            btnPrintList.Name = "btnPrintList";
            btnPrintList.Size = new Size(85, 23);
            btnPrintList.TabIndex = 4;
            btnPrintList.Text = "Print list";
            btnPrintList.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnPrintList.UseVisualStyleBackColor = true;
            // 
            // btnRemoveStudent
            // 
            btnRemoveStudent.Enabled = false;
            btnRemoveStudent.Image = Properties.Resources.cross;
            btnRemoveStudent.Location = new Point(226, 2);
            btnRemoveStudent.Margin = new Padding(2);
            btnRemoveStudent.Name = "btnRemoveStudent";
            btnRemoveStudent.Size = new Size(130, 23);
            btnRemoveStudent.TabIndex = 3;
            btnRemoveStudent.Text = "Remove student";
            btnRemoveStudent.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnRemoveStudent.UseVisualStyleBackColor = true;
            // 
            // lstbxStudentName
            // 
            lstbxStudentName.FormattingEnabled = true;
            lstbxStudentName.ItemHeight = 15;
            lstbxStudentName.Location = new Point(10, 97);
            lstbxStudentName.Margin = new Padding(10, 10, 3, 3);
            lstbxStudentName.Name = "lstbxStudentName";
            lstbxStudentName.ScrollAlwaysVisible = true;
            lstbxStudentName.Size = new Size(582, 379);
            lstbxStudentName.TabIndex = 5;
            lstbxStudentName.SelectedIndexChanged += lstbxStudentName_SelectedIndexChanged;
            // 
            // lstbxStudentRegNo
            // 
            lstbxStudentRegNo.FormattingEnabled = true;
            lstbxStudentRegNo.ItemHeight = 15;
            lstbxStudentRegNo.Location = new Point(10, 489);
            lstbxStudentRegNo.Margin = new Padding(10, 10, 3, 3);
            lstbxStudentRegNo.Name = "lstbxStudentRegNo";
            lstbxStudentRegNo.ScrollAlwaysVisible = true;
            lstbxStudentRegNo.Size = new Size(582, 379);
            lstbxStudentRegNo.TabIndex = 6;
            // 
            // frmStudentsManager
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(786, 442);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Location = new Point(10, 10);
            MaximizeBox = false;
            Name = "frmStudentsManager";
            ShowIcon = false;
            StartPosition = FormStartPosition.Manual;
            Text = "Students Manager window";
            FormClosing += frmStudentsManager_FormClosing;
            Load += frmStudentsManager_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private LinkLabel btnRefreshDB;
        private LinkLabel btnManageTeachers;
        private PictureBox pictureBox1;
        private LinkLabel btnManageParents;
        private FlowLayoutPanel flowLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnEditStudent;
        private Button btnRemoveStudent;
        private Button btnPrintList;
        private Button btnAddStudent;
        private Label label2;
        private Label label3;
        private ListBox lstbxStudentName;
        private ListBox lstbxStudentRegNo;
    }
}