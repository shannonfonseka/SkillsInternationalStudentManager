namespace SkillsInternationalStudentManager
{
    partial class frmLoginSystem
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
            components = new System.ComponentModel.Container();
            btnExitSystem = new LinkLabel();
            btnClearFields = new LinkLabel();
            chkbxShowPassword = new CheckBox();
            btnLogin = new Button();
            txtbxPassword = new TextBox();
            txtbxUsername = new TextBox();
            lblPassword = new Label();
            lblUsername = new Label();
            lblLoginTip = new Label();
            lblTitle = new Label();
            toolTip1 = new ToolTip(components);
            flowpanelLoginLayout = new FlowLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblAccessType = new Label();
            radiobtnTeacher = new RadioButton();
            radiobtnAdmin = new RadioButton();
            btnAboutProgram = new LinkLabel();
            flowpanelLoginLayout.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnExitSystem
            // 
            btnExitSystem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExitSystem.Image = Properties.Resources.cancel;
            btnExitSystem.ImageAlign = ContentAlignment.MiddleLeft;
            btnExitSystem.LinkColor = Color.Blue;
            btnExitSystem.Location = new Point(333, 457);
            btnExitSystem.Margin = new Padding(0, 0, 0, 10);
            btnExitSystem.Name = "btnExitSystem";
            btnExitSystem.Size = new Size(131, 19);
            btnExitSystem.TabIndex = 7;
            btnExitSystem.TabStop = true;
            btnExitSystem.Text = "Exit system (Alt+F4)";
            btnExitSystem.TextAlign = ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(btnExitSystem, "Closes the program.");
            btnExitSystem.VisitedLinkColor = Color.Blue;
            btnExitSystem.LinkClicked += btnExitSystem_LinkClicked;
            // 
            // btnClearFields
            // 
            btnClearFields.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClearFields.Image = Properties.Resources.textfield_clear;
            btnClearFields.ImageAlign = ContentAlignment.MiddleLeft;
            btnClearFields.LinkColor = Color.Blue;
            btnClearFields.Location = new Point(358, 399);
            btnClearFields.Margin = new Padding(0, 0, 0, 10);
            btnClearFields.Name = "btnClearFields";
            btnClearFields.Size = new Size(106, 19);
            btnClearFields.TabIndex = 5;
            btnClearFields.TabStop = true;
            btnClearFields.Text = "Clear all fields";
            btnClearFields.TextAlign = ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(btnClearFields, "Clears all the data you've entered.");
            btnClearFields.VisitedLinkColor = Color.Blue;
            btnClearFields.LinkClicked += btnClearFields_LinkClicked;
            // 
            // chkbxShowPassword
            // 
            chkbxShowPassword.AutoSize = true;
            chkbxShowPassword.Location = new Point(34, 298);
            chkbxShowPassword.Margin = new Padding(0);
            chkbxShowPassword.Name = "chkbxShowPassword";
            chkbxShowPassword.Size = new Size(148, 19);
            chkbxShowPassword.TabIndex = 3;
            chkbxShowPassword.Text = "Show above password?";
            chkbxShowPassword.TextImageRelation = TextImageRelation.ImageBeforeText;
            chkbxShowPassword.UseVisualStyleBackColor = true;
            chkbxShowPassword.CheckedChanged += chkbxShowPassword_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.Cursor = Cursors.Hand;
            flowpanelLoginLayout.SetFlowBreak(btnLogin, true);
            btnLogin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Image = Properties.Resources.door_in1;
            btnLogin.Location = new Point(34, 337);
            btnLogin.Margin = new Padding(0, 20, 0, 20);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(118, 42);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtbxPassword
            // 
            txtbxPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtbxPassword.Font = new Font("Segoe UI", 9F);
            txtbxPassword.Location = new Point(34, 270);
            txtbxPassword.Margin = new Padding(0, 0, 0, 5);
            txtbxPassword.Name = "txtbxPassword";
            txtbxPassword.PlaceholderText = "required field*";
            txtbxPassword.Size = new Size(430, 23);
            txtbxPassword.TabIndex = 2;
            txtbxPassword.UseSystemPasswordChar = true;
            // 
            // txtbxUsername
            // 
            txtbxUsername.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtbxUsername.Font = new Font("Segoe UI", 9F);
            txtbxUsername.Location = new Point(34, 207);
            txtbxUsername.Margin = new Padding(0, 0, 0, 20);
            txtbxUsername.Name = "txtbxUsername";
            txtbxUsername.PlaceholderText = "required field*";
            txtbxUsername.Size = new Size(430, 23);
            txtbxUsername.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblPassword.Location = new Point(34, 250);
            lblPassword.Margin = new Padding(0, 0, 0, 5);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(122, 15);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Enter password below";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblUsername.Location = new Point(34, 187);
            lblUsername.Margin = new Padding(0, 0, 0, 5);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(124, 15);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Enter username below";
            // 
            // lblLoginTip
            // 
            lblLoginTip.BorderStyle = BorderStyle.Fixed3D;
            lblLoginTip.Location = new Point(34, 84);
            lblLoginTip.Margin = new Padding(0, 20, 0, 5);
            lblLoginTip.Name = "lblLoginTip";
            lblLoginTip.Padding = new Padding(5);
            lblLoginTip.Size = new Size(430, 60);
            lblLoginTip.TabIndex = 0;
            lblLoginTip.Text = "Teachers and other staff members can login but gets limited access to this system. A administrator is required to get full access, please contact your IT administrator.";
            lblLoginTip.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Image = Properties.Resources.user_student1;
            lblTitle.ImageAlign = ContentAlignment.MiddleLeft;
            lblTitle.Location = new Point(34, 20);
            lblTitle.Margin = new Padding(0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(318, 44);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Log in to Student Manager";
            lblTitle.TextAlign = ContentAlignment.MiddleRight;
            // 
            // flowpanelLoginLayout
            // 
            flowpanelLoginLayout.BackColor = Color.Transparent;
            flowpanelLoginLayout.Controls.Add(lblTitle);
            flowpanelLoginLayout.Controls.Add(lblLoginTip);
            flowpanelLoginLayout.Controls.Add(flowLayoutPanel1);
            flowpanelLoginLayout.Controls.Add(lblUsername);
            flowpanelLoginLayout.Controls.Add(txtbxUsername);
            flowpanelLoginLayout.Controls.Add(lblPassword);
            flowpanelLoginLayout.Controls.Add(txtbxPassword);
            flowpanelLoginLayout.Controls.Add(chkbxShowPassword);
            flowpanelLoginLayout.Controls.Add(btnLogin);
            flowpanelLoginLayout.Controls.Add(btnClearFields);
            flowpanelLoginLayout.Controls.Add(btnAboutProgram);
            flowpanelLoginLayout.Controls.Add(btnExitSystem);
            flowpanelLoginLayout.Dock = DockStyle.Fill;
            flowpanelLoginLayout.FlowDirection = FlowDirection.TopDown;
            flowpanelLoginLayout.Location = new Point(0, 0);
            flowpanelLoginLayout.Margin = new Padding(0);
            flowpanelLoginLayout.Name = "flowpanelLoginLayout";
            flowpanelLoginLayout.Padding = new Padding(34, 20, 34, 0);
            flowpanelLoginLayout.Size = new Size(490, 490);
            flowpanelLoginLayout.TabIndex = 7;
            flowpanelLoginLayout.WrapContents = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(lblAccessType);
            flowLayoutPanel1.Controls.Add(radiobtnTeacher);
            flowLayoutPanel1.Controls.Add(radiobtnAdmin);
            flowLayoutPanel1.Location = new Point(34, 152);
            flowLayoutPanel1.Margin = new Padding(0, 3, 3, 10);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(300, 25);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // lblAccessType
            // 
            lblAccessType.AutoSize = true;
            lblAccessType.Dock = DockStyle.Fill;
            lblAccessType.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblAccessType.Location = new Point(0, 0);
            lblAccessType.Margin = new Padding(0, 0, 0, 5);
            lblAccessType.Name = "lblAccessType";
            lblAccessType.Size = new Size(111, 20);
            lblAccessType.TabIndex = 2;
            lblAccessType.Text = "Login to system as: ";
            lblAccessType.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // radiobtnTeacher
            // 
            radiobtnTeacher.AutoSize = true;
            radiobtnTeacher.Cursor = Cursors.Hand;
            radiobtnTeacher.Location = new Point(121, 3);
            radiobtnTeacher.Margin = new Padding(10, 3, 3, 3);
            radiobtnTeacher.Name = "radiobtnTeacher";
            radiobtnTeacher.Size = new Size(65, 19);
            radiobtnTeacher.TabIndex = 1;
            radiobtnTeacher.Text = "Teacher";
            radiobtnTeacher.UseVisualStyleBackColor = true;
            radiobtnTeacher.CheckedChanged += radiobtnTeacher_CheckedChanged;
            // 
            // radiobtnAdmin
            // 
            radiobtnAdmin.AutoSize = true;
            radiobtnAdmin.Cursor = Cursors.Hand;
            radiobtnAdmin.Location = new Point(199, 3);
            radiobtnAdmin.Margin = new Padding(10, 3, 3, 3);
            radiobtnAdmin.Name = "radiobtnAdmin";
            radiobtnAdmin.Size = new Size(98, 19);
            radiobtnAdmin.TabIndex = 0;
            radiobtnAdmin.Text = "Administrator";
            radiobtnAdmin.UseVisualStyleBackColor = true;
            radiobtnAdmin.CheckedChanged += radiobtnAdmin_CheckedChanged;
            // 
            // btnAboutProgram
            // 
            btnAboutProgram.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAboutProgram.Image = Properties.Resources.information;
            btnAboutProgram.ImageAlign = ContentAlignment.MiddleLeft;
            btnAboutProgram.LinkColor = Color.Blue;
            btnAboutProgram.Location = new Point(307, 428);
            btnAboutProgram.Margin = new Padding(0, 0, 0, 10);
            btnAboutProgram.Name = "btnAboutProgram";
            btnAboutProgram.Size = new Size(157, 19);
            btnAboutProgram.TabIndex = 6;
            btnAboutProgram.TabStop = true;
            btnAboutProgram.Text = "About Student Manager";
            btnAboutProgram.TextAlign = ContentAlignment.MiddleRight;
            btnAboutProgram.VisitedLinkColor = Color.Blue;
            btnAboutProgram.LinkClicked += btnAboutProgram_LinkClicked;
            // 
            // frmLoginSystem
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            CancelButton = btnExitSystem;
            ClientSize = new Size(490, 490);
            ControlBox = false;
            Controls.Add(flowpanelLoginLayout);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MaximumSize = new Size(500, 500);
            MinimizeBox = false;
            MinimumSize = new Size(500, 500);
            Name = "frmLoginSystem";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += frmLoginSystem_FormClosing;
            flowpanelLoginLayout.ResumeLayout(false);
            flowpanelLoginLayout.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblTitle;
        private Label lblLoginTip;
        private Button btnLogin;
        private TextBox txtbxPassword;
        private TextBox txtbxUsername;
        private Label lblPassword;
        private Label lblUsername;
        private LinkLabel btnClearFields;
        private CheckBox chkbxShowPassword;
        private LinkLabel btnExitSystem;
        private ToolTip toolTip1;
        private FlowLayoutPanel flowpanelLoginLayout;
        private LinkLabel btnAboutProgram;
        private FlowLayoutPanel flowLayoutPanel1;
        private RadioButton radiobtnAdmin;
        private RadioButton radiobtnTeacher;
        private Label lblAccessType;
    }
}