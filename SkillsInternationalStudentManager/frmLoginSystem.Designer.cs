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
            btnExitSystem.Location = new Point(416, 566);
            btnExitSystem.Margin = new Padding(0, 0, 0, 12);
            btnExitSystem.Name = "btnExitSystem";
            btnExitSystem.Size = new Size(164, 24);
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
            btnClearFields.Location = new Point(448, 494);
            btnClearFields.Margin = new Padding(0, 0, 0, 12);
            btnClearFields.Name = "btnClearFields";
            btnClearFields.Size = new Size(132, 24);
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
            chkbxShowPassword.Location = new Point(42, 355);
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
            btnLogin.Location = new Point(42, 404);
            btnLogin.Margin = new Padding(0, 25, 0, 38);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(148, 52);
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
            txtbxPassword.Location = new Point(42, 321);
            txtbxPassword.Margin = new Padding(0, 0, 0, 6);
            txtbxPassword.Name = "txtbxPassword";
            txtbxPassword.PasswordChar = '●';
            txtbxPassword.Size = new Size(538, 28);
            txtbxPassword.TabIndex = 2;
            // 
            // txtbxUsername
            // 
            txtbxUsername.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtbxUsername.Font = new Font("Courier New", 10.8F);
            txtbxUsername.Location = new Point(42, 242);
            txtbxUsername.Margin = new Padding(0, 0, 0, 25);
            txtbxUsername.Name = "txtbxUsername";
            txtbxUsername.Size = new Size(538, 28);
            txtbxUsername.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblPassword.Location = new Point(42, 295);
            lblPassword.Margin = new Padding(0, 0, 0, 6);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(158, 20);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Enter password below";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblUsername.Location = new Point(42, 216);
            lblUsername.Margin = new Padding(0, 0, 0, 6);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(161, 20);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Enter username below";
            // 
            // lblLoginTip
            // 
            lblLoginTip.BorderStyle = BorderStyle.Fixed3D;
            lblLoginTip.Location = new Point(42, 105);
            lblLoginTip.Margin = new Padding(0, 25, 0, 36);
            lblLoginTip.Name = "lblLoginTip";
            lblLoginTip.Padding = new Padding(6);
            lblLoginTip.Size = new Size(538, 75);
            lblLoginTip.TabIndex = 0;
            lblLoginTip.Text = "Teachers and other staff members can login but gets limited access to this system. A administrator is required to get full access, please contact your IT administrator.";
            lblLoginTip.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Image = Properties.Resources.user_student1;
            lblTitle.ImageAlign = ContentAlignment.MiddleLeft;
            lblTitle.Location = new Point(42, 25);
            lblTitle.Margin = new Padding(0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(398, 55);
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
            flowpanelLoginLayout.Padding = new Padding(42, 25, 42, 0);
            flowpanelLoginLayout.Size = new Size(612, 612);
            flowpanelLoginLayout.TabIndex = 7;
            flowpanelLoginLayout.WrapContents = false;
            // 
            // btnAboutProgram
            // 
            btnAboutProgram.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAboutProgram.Image = Properties.Resources.information;
            btnAboutProgram.ImageAlign = ContentAlignment.MiddleLeft;
            btnAboutProgram.LinkColor = Color.Blue;
            btnAboutProgram.Location = new Point(384, 530);
            btnAboutProgram.Margin = new Padding(0, 0, 0, 12);
            btnAboutProgram.Name = "btnAboutProgram";
            btnAboutProgram.Size = new Size(196, 24);
            btnAboutProgram.TabIndex = 7;
            btnAboutProgram.TabStop = true;
            btnAboutProgram.Text = "About Student Manager";
            btnAboutProgram.TextAlign = ContentAlignment.MiddleRight;
            btnAboutProgram.VisitedLinkColor = Color.Blue;
            // 
            // frmLoginSystem
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            ClientSize = new Size(612, 612);
            ControlBox = false;
            Controls.Add(flowpanelLoginLayout);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4);
            MaximizeBox = false;
            MaximumSize = new Size(622, 622);
            MinimizeBox = false;
            MinimumSize = new Size(622, 622);
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