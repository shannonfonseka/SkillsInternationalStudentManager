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
            btnAboutProgram = new LinkLabel();
            flowpanelLoginLayout.SuspendLayout();
            SuspendLayout();
            // 
            // btnExitSystem
            // 
            btnExitSystem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExitSystem.Image = Properties.Resources.cancel;
            btnExitSystem.ImageAlign = ContentAlignment.MiddleLeft;
            btnExitSystem.LinkColor = Color.Blue;
            btnExitSystem.Location = new Point(424, 500);
            btnExitSystem.Name = "btnExitSystem";
            btnExitSystem.Size = new Size(165, 25);
            btnExitSystem.TabIndex = 6;
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
            btnClearFields.Location = new Point(456, 430);
            btnClearFields.Margin = new Padding(3, 0, 3, 10);
            btnClearFields.Name = "btnClearFields";
            btnClearFields.Size = new Size(133, 25);
            btnClearFields.TabIndex = 5;
            btnClearFields.TabStop = true;
            btnClearFields.Text = "Clear all fields";
            btnClearFields.TextAlign = ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(btnClearFields, "Clears all the data you've entered.");
            btnClearFields.VisitedLinkColor = Color.Blue;
            // 
            // chkbxShowPassword
            // 
            chkbxShowPassword.AutoSize = true;
            chkbxShowPassword.Location = new Point(30, 291);
            chkbxShowPassword.Margin = new Padding(0);
            chkbxShowPassword.Name = "chkbxShowPassword";
            chkbxShowPassword.Size = new Size(186, 24);
            chkbxShowPassword.TabIndex = 3;
            chkbxShowPassword.Text = "Show above password?";
            chkbxShowPassword.TextImageRelation = TextImageRelation.ImageBeforeText;
            chkbxShowPassword.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Cursor = Cursors.Hand;
            flowpanelLoginLayout.SetFlowBreak(btnLogin, true);
            btnLogin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Image = Properties.Resources.door_in1;
            btnLogin.Location = new Point(30, 345);
            btnLogin.Margin = new Padding(0, 30, 0, 30);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(170, 55);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtbxPassword
            // 
            txtbxPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtbxPassword.Font = new Font("Courier New", 10.8F);
            txtbxPassword.Location = new Point(30, 258);
            txtbxPassword.Margin = new Padding(0, 0, 0, 5);
            txtbxPassword.Name = "txtbxPassword";
            txtbxPassword.PasswordChar = '●';
            txtbxPassword.Size = new Size(562, 28);
            txtbxPassword.TabIndex = 2;
            // 
            // txtbxUsername
            // 
            txtbxUsername.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtbxUsername.Font = new Font("Courier New", 10.8F);
            txtbxUsername.Location = new Point(30, 185);
            txtbxUsername.Margin = new Padding(0, 0, 0, 20);
            txtbxUsername.Name = "txtbxUsername";
            txtbxUsername.Size = new Size(562, 28);
            txtbxUsername.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblPassword.Location = new Point(30, 233);
            lblPassword.Margin = new Padding(0, 0, 0, 5);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(158, 20);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Enter password below";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblUsername.Location = new Point(30, 160);
            lblUsername.Margin = new Padding(0, 0, 0, 5);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(161, 20);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Enter username below";
            // 
            // lblLoginTip
            // 
            lblLoginTip.AutoSize = true;
            lblLoginTip.BorderStyle = BorderStyle.Fixed3D;
            lblLoginTip.Dock = DockStyle.Right;
            lblLoginTip.Location = new Point(30, 78);
            lblLoginTip.Margin = new Padding(0, 20, 0, 30);
            lblLoginTip.Name = "lblLoginTip";
            lblLoginTip.Padding = new Padding(5);
            lblLoginTip.Size = new Size(562, 52);
            lblLoginTip.TabIndex = 0;
            lblLoginTip.Text = "Teachers and other staff members can login but gets limited access to this system.\r\nA administrator is required to get full access, please contact your IT administrator.";
            lblLoginTip.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Image = Properties.Resources.user_student1;
            lblTitle.ImageAlign = ContentAlignment.MiddleLeft;
            lblTitle.Location = new Point(30, 20);
            lblTitle.Margin = new Padding(0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(402, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Log in to Student Manager";
            lblTitle.TextAlign = ContentAlignment.MiddleRight;
            // 
            // flowpanelLoginLayout
            // 
            flowpanelLoginLayout.BackColor = Color.Transparent;
            flowpanelLoginLayout.Controls.Add(lblTitle);
            flowpanelLoginLayout.Controls.Add(lblLoginTip);
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
            flowpanelLoginLayout.Padding = new Padding(30, 20, 30, 0);
            flowpanelLoginLayout.Size = new Size(630, 540);
            flowpanelLoginLayout.TabIndex = 7;
            flowpanelLoginLayout.WrapContents = false;
            // 
            // btnAboutProgram
            // 
            btnAboutProgram.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAboutProgram.Image = Properties.Resources.information;
            btnAboutProgram.ImageAlign = ContentAlignment.MiddleLeft;
            btnAboutProgram.LinkColor = Color.Blue;
            btnAboutProgram.Location = new Point(392, 465);
            btnAboutProgram.Margin = new Padding(3, 0, 3, 10);
            btnAboutProgram.Name = "btnAboutProgram";
            btnAboutProgram.Size = new Size(197, 25);
            btnAboutProgram.TabIndex = 7;
            btnAboutProgram.TabStop = true;
            btnAboutProgram.Text = "About Student Manager";
            btnAboutProgram.TextAlign = ContentAlignment.MiddleRight;
            btnAboutProgram.VisitedLinkColor = Color.Blue;
            // 
            // frmLoginSystem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 540);
            ControlBox = false;
            Controls.Add(flowpanelLoginLayout);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MaximumSize = new Size(640, 550);
            MinimizeBox = false;
            MinimumSize = new Size(640, 550);
            Name = "frmLoginSystem";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += frmLoginSystem_FormClosing;
            flowpanelLoginLayout.ResumeLayout(false);
            flowpanelLoginLayout.PerformLayout();
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
    }
}