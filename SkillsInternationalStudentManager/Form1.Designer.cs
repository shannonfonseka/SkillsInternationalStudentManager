namespace SkillsInternationalStudentManager
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            menuMain = new MenuStrip();
            menuFile = new ToolStripMenuItem();
            menuitemExit = new ToolStripMenuItem();
            menuDatabase = new ToolStripMenuItem();
            menuitemManageAdmins = new ToolStripMenuItem();
            menuitemRefreshDatabase = new ToolStripMenuItem();
            menuitemDbSummary = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            menuitemLogOutSystem = new ToolStripMenuItem();
            menuSchool = new ToolStripMenuItem();
            menuitemNoticeBoard = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            menuitemManageSubjects = new ToolStripMenuItem();
            menuitemManageTimetables = new ToolStripMenuItem();
            menuitemManageClassrooms = new ToolStripMenuItem();
            menuStudents = new ToolStripMenuItem();
            menuitemAddStudent = new ToolStripMenuItem();
            menuitemManageStudents = new ToolStripMenuItem();
            menuitemManageParents = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            menuitemAttendanceTracking = new ToolStripMenuItem();
            menuitemStudentHealthRecords = new ToolStripMenuItem();
            menuitemFeesPayments = new ToolStripMenuItem();
            menuTeachers = new ToolStripMenuItem();
            menuAddTeacher = new ToolStripMenuItem();
            menuManageTeachers = new ToolStripMenuItem();
            menuReports = new ToolStripMenuItem();
            menuitemReportsWizard = new ToolStripMenuItem();
            menuitemStoredReports = new ToolStripMenuItem();
            menuWindow = new ToolStripMenuItem();
            menuHelp = new ToolStripMenuItem();
            menuitemAbout = new ToolStripMenuItem();
            menuAccessLevel = new ToolStripMenuItem();
            toolTip1 = new ToolTip(components);
            toolbarMain = new ToolStrip();
            toolbarbtnManageTeachers = new ToolStripButton();
            toolbarbtnManageTimetables = new ToolStripButton();
            toolbarbtnManageStudents = new ToolStripButton();
            toolbarbtnAddStudent = new ToolStripButton();
            toolbarbtnManageClassrooms = new ToolStripButton();
            toolbarbtnAttendanceTracking = new ToolStripButton();
            toolbarbtnFeesPayments = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolbarbtnNoticeBoard = new ToolStripButton();
            toolbardrpdownbtnReportsWizard = new ToolStripDropDownButton();
            toolbarbtnCreateNewReportWizard = new ToolStripMenuItem();
            toolbarbtnStoredReports = new ToolStripMenuItem();
            toolbarbtnLogOutSystem = new ToolStripButton();
            panelNoticeBoard = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblNoticeBoardTitle = new Label();
            picbxNoticeBoardImg = new PictureBox();
            lblNoticeBoardDesc = new Label();
            menuMain.SuspendLayout();
            toolbarMain.SuspendLayout();
            panelNoticeBoard.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picbxNoticeBoardImg).BeginInit();
            SuspendLayout();
            // 
            // menuMain
            // 
            menuMain.BackColor = SystemColors.Control;
            menuMain.ImageScalingSize = new Size(20, 20);
            menuMain.Items.AddRange(new ToolStripItem[] { menuFile, menuDatabase, menuSchool, menuStudents, menuTeachers, menuReports, menuWindow, menuHelp, menuAccessLevel });
            menuMain.Location = new Point(0, 0);
            menuMain.MdiWindowListItem = menuWindow;
            menuMain.Name = "menuMain";
            menuMain.RenderMode = ToolStripRenderMode.Professional;
            menuMain.Size = new Size(1104, 24);
            menuMain.TabIndex = 1;
            // 
            // menuFile
            // 
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { menuitemExit });
            menuFile.Name = "menuFile";
            menuFile.Padding = new Padding(6, 0, 6, 0);
            menuFile.Size = new Size(41, 20);
            menuFile.Text = "&File";
            // 
            // menuitemExit
            // 
            menuitemExit.Image = Properties.Resources.cancel;
            menuitemExit.Name = "menuitemExit";
            menuitemExit.ShortcutKeys = Keys.Alt | Keys.F4;
            menuitemExit.Size = new Size(135, 22);
            menuitemExit.Text = "E&xit";
            menuitemExit.Click += menuitemExit_Click;
            // 
            // menuDatabase
            // 
            menuDatabase.DropDownItems.AddRange(new ToolStripItem[] { menuitemManageAdmins, menuitemRefreshDatabase, menuitemDbSummary, toolStripSeparator4, menuitemLogOutSystem });
            menuDatabase.Name = "menuDatabase";
            menuDatabase.Padding = new Padding(6, 0, 6, 0);
            menuDatabase.Size = new Size(71, 20);
            menuDatabase.Text = "Database";
            // 
            // menuitemManageAdmins
            // 
            menuitemManageAdmins.Image = Properties.Resources.administrator;
            menuitemManageAdmins.Name = "menuitemManageAdmins";
            menuitemManageAdmins.ShortcutKeys = Keys.F2;
            menuitemManageAdmins.Size = new Size(195, 22);
            menuitemManageAdmins.Text = "Manage admins";
            menuitemManageAdmins.Click += menuitemManageAdmins_Click;
            // 
            // menuitemRefreshDatabase
            // 
            menuitemRefreshDatabase.Image = Properties.Resources.arrow_refresh;
            menuitemRefreshDatabase.Name = "menuitemRefreshDatabase";
            menuitemRefreshDatabase.ShortcutKeys = Keys.F5;
            menuitemRefreshDatabase.Size = new Size(195, 22);
            menuitemRefreshDatabase.Text = "Refresh Database";
            menuitemRefreshDatabase.Click += menuitemRefreshDatabase_Click;
            // 
            // menuitemDbSummary
            // 
            menuitemDbSummary.Image = Properties.Resources.page_white_database;
            menuitemDbSummary.Name = "menuitemDbSummary";
            menuitemDbSummary.Size = new Size(195, 22);
            menuitemDbSummary.Text = "Database summary";
            menuitemDbSummary.Click += menuitemDbSummary_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(192, 6);
            // 
            // menuitemLogOutSystem
            // 
            menuitemLogOutSystem.Image = Properties.Resources.door_out;
            menuitemLogOutSystem.Name = "menuitemLogOutSystem";
            menuitemLogOutSystem.ShortcutKeys = Keys.Control | Keys.L;
            menuitemLogOutSystem.Size = new Size(195, 22);
            menuitemLogOutSystem.Text = "Log out system";
            menuitemLogOutSystem.Click += menuitemLogOutSystem_Click;
            // 
            // menuSchool
            // 
            menuSchool.DropDownItems.AddRange(new ToolStripItem[] { menuitemNoticeBoard, toolStripSeparator3, menuitemManageSubjects, menuitemManageTimetables, menuitemManageClassrooms });
            menuSchool.Name = "menuSchool";
            menuSchool.Padding = new Padding(6, 0, 6, 0);
            menuSchool.Size = new Size(59, 20);
            menuSchool.Text = "School";
            // 
            // menuitemNoticeBoard
            // 
            menuitemNoticeBoard.Checked = true;
            menuitemNoticeBoard.CheckState = CheckState.Checked;
            menuitemNoticeBoard.Image = Properties.Resources.notes_pin;
            menuitemNoticeBoard.Name = "menuitemNoticeBoard";
            menuitemNoticeBoard.ShortcutKeys = Keys.Control | Keys.N;
            menuitemNoticeBoard.Size = new Size(186, 22);
            menuitemNoticeBoard.Text = "Notice Board";
            menuitemNoticeBoard.Click += menuitemNoticeBoard_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(183, 6);
            // 
            // menuitemManageSubjects
            // 
            menuitemManageSubjects.Image = Properties.Resources.books_stack;
            menuitemManageSubjects.Name = "menuitemManageSubjects";
            menuitemManageSubjects.Size = new Size(186, 22);
            menuitemManageSubjects.Text = "Manage s&ubjects";
            menuitemManageSubjects.Click += menuitemManageSubjects_Click;
            // 
            // menuitemManageTimetables
            // 
            menuitemManageTimetables.Image = Properties.Resources.date_time_functions;
            menuitemManageTimetables.Name = "menuitemManageTimetables";
            menuitemManageTimetables.Size = new Size(186, 22);
            menuitemManageTimetables.Text = "Manage timetables";
            menuitemManageTimetables.Click += menuitemManageTimetables_Click;
            // 
            // menuitemManageClassrooms
            // 
            menuitemManageClassrooms.Image = Properties.Resources.users_3;
            menuitemManageClassrooms.Name = "menuitemManageClassrooms";
            menuitemManageClassrooms.Size = new Size(186, 22);
            menuitemManageClassrooms.Text = "Manage classrooms";
            menuitemManageClassrooms.Click += menuitemManageClassrooms_Click;
            // 
            // menuStudents
            // 
            menuStudents.DropDownItems.AddRange(new ToolStripItem[] { menuitemAddStudent, menuitemManageStudents, menuitemManageParents, toolStripSeparator2, menuitemAttendanceTracking, menuitemStudentHealthRecords, menuitemFeesPayments });
            menuStudents.Name = "menuStudents";
            menuStudents.Padding = new Padding(6, 0, 6, 0);
            menuStudents.Size = new Size(69, 20);
            menuStudents.Text = "&Students";
            // 
            // menuitemAddStudent
            // 
            menuitemAddStudent.Image = Properties.Resources.user_add;
            menuitemAddStudent.Name = "menuitemAddStudent";
            menuitemAddStudent.Size = new Size(217, 22);
            menuitemAddStudent.Text = "&Add new student";
            menuitemAddStudent.Click += menuitemAddStudent_Click;
            // 
            // menuitemManageStudents
            // 
            menuitemManageStudents.Image = Properties.Resources.user_student;
            menuitemManageStudents.Name = "menuitemManageStudents";
            menuitemManageStudents.ShortcutKeys = Keys.F3;
            menuitemManageStudents.Size = new Size(217, 22);
            menuitemManageStudents.Text = "Manage &Students";
            menuitemManageStudents.Click += menuitemManageStudents_Click;
            // 
            // menuitemManageParents
            // 
            menuitemManageParents.Image = Properties.Resources.users_men_women;
            menuitemManageParents.Name = "menuitemManageParents";
            menuitemManageParents.Size = new Size(217, 22);
            menuitemManageParents.Text = "Manage &Parents/Guardians";
            menuitemManageParents.Click += menuitemManageParents_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(214, 6);
            // 
            // menuitemAttendanceTracking
            // 
            menuitemAttendanceTracking.Image = Properties.Resources.chart_line;
            menuitemAttendanceTracking.Name = "menuitemAttendanceTracking";
            menuitemAttendanceTracking.Size = new Size(217, 22);
            menuitemAttendanceTracking.Text = "Attendance tracking";
            menuitemAttendanceTracking.Click += menuitemAttendanceTracking_Click;
            // 
            // menuitemStudentHealthRecords
            // 
            menuitemStudentHealthRecords.Image = Properties.Resources.health;
            menuitemStudentHealthRecords.Name = "menuitemStudentHealthRecords";
            menuitemStudentHealthRecords.Size = new Size(217, 22);
            menuitemStudentHealthRecords.Text = "Student health records";
            menuitemStudentHealthRecords.Click += menuitemStudentHealthRecords_Click;
            // 
            // menuitemFeesPayments
            // 
            menuitemFeesPayments.Image = Properties.Resources.table_money;
            menuitemFeesPayments.Name = "menuitemFeesPayments";
            menuitemFeesPayments.Size = new Size(217, 22);
            menuitemFeesPayments.Text = "Fees and payments";
            menuitemFeesPayments.Click += menuitemFeesPayments_Click;
            // 
            // menuTeachers
            // 
            menuTeachers.DropDownItems.AddRange(new ToolStripItem[] { menuAddTeacher, menuManageTeachers });
            menuTeachers.Name = "menuTeachers";
            menuTeachers.Padding = new Padding(6, 0, 6, 0);
            menuTeachers.Size = new Size(68, 20);
            menuTeachers.Text = "&Teachers";
            // 
            // menuAddTeacher
            // 
            menuAddTeacher.Image = Properties.Resources.user_add;
            menuAddTeacher.Name = "menuAddTeacher";
            menuAddTeacher.Size = new Size(184, 22);
            menuAddTeacher.Text = "&Add new teacher";
            menuAddTeacher.Click += menuAddTeacher_Click;
            // 
            // menuManageTeachers
            // 
            menuManageTeachers.Image = Properties.Resources.users_5;
            menuManageTeachers.Name = "menuManageTeachers";
            menuManageTeachers.ShortcutKeys = Keys.F4;
            menuManageTeachers.Size = new Size(184, 22);
            menuManageTeachers.Text = "Manage &Teachers";
            menuManageTeachers.Click += menuManageTeachers_Click;
            // 
            // menuReports
            // 
            menuReports.DropDownItems.AddRange(new ToolStripItem[] { menuitemReportsWizard, menuitemStoredReports });
            menuReports.Name = "menuReports";
            menuReports.Padding = new Padding(6, 0, 6, 0);
            menuReports.Size = new Size(63, 20);
            menuReports.Text = "&Reports";
            // 
            // menuitemReportsWizard
            // 
            menuitemReportsWizard.Image = Properties.Resources.report_wizard;
            menuitemReportsWizard.Name = "menuitemReportsWizard";
            menuitemReportsWizard.Size = new Size(151, 22);
            menuitemReportsWizard.Text = "Reports &wizard";
            menuitemReportsWizard.Click += menuitemReportsWizard_Click;
            // 
            // menuitemStoredReports
            // 
            menuitemStoredReports.Image = Properties.Resources.saved_imports;
            menuitemStoredReports.Name = "menuitemStoredReports";
            menuitemStoredReports.Size = new Size(151, 22);
            menuitemStoredReports.Text = "Stored reports";
            menuitemStoredReports.Click += menuitemStoredReports_Click;
            // 
            // menuWindow
            // 
            menuWindow.Name = "menuWindow";
            menuWindow.Padding = new Padding(6, 0, 6, 0);
            menuWindow.Size = new Size(67, 20);
            menuWindow.Text = "&Window";
            // 
            // menuHelp
            // 
            menuHelp.DropDownItems.AddRange(new ToolStripItem[] { menuitemAbout });
            menuHelp.Name = "menuHelp";
            menuHelp.Padding = new Padding(6, 0, 6, 0);
            menuHelp.Size = new Size(48, 20);
            menuHelp.Text = "&Help";
            // 
            // menuitemAbout
            // 
            menuitemAbout.Image = Properties.Resources.information;
            menuitemAbout.Name = "menuitemAbout";
            menuitemAbout.ShortcutKeys = Keys.F1;
            menuitemAbout.Size = new Size(220, 22);
            menuitemAbout.Text = "About Student Manager";
            menuitemAbout.Click += menuitemAbout_Click;
            // 
            // menuAccessLevel
            // 
            menuAccessLevel.Alignment = ToolStripItemAlignment.Right;
            menuAccessLevel.BackColor = Color.MistyRose;
            menuAccessLevel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuAccessLevel.ForeColor = Color.DarkRed;
            menuAccessLevel.Name = "menuAccessLevel";
            menuAccessLevel.Size = new Size(113, 20);
            menuAccessLevel.Text = "Access Level Type";
            // 
            // toolbarMain
            // 
            toolbarMain.GripStyle = ToolStripGripStyle.Hidden;
            toolbarMain.ImageScalingSize = new Size(32, 32);
            toolbarMain.Items.AddRange(new ToolStripItem[] { toolbarbtnManageTeachers, toolbarbtnManageTimetables, toolbarbtnManageStudents, toolbarbtnAddStudent, toolbarbtnManageClassrooms, toolbarbtnAttendanceTracking, toolbarbtnFeesPayments, toolStripSeparator1, toolbarbtnNoticeBoard, toolbardrpdownbtnReportsWizard, toolbarbtnLogOutSystem });
            toolbarMain.Location = new Point(0, 24);
            toolbarMain.Name = "toolbarMain";
            toolbarMain.RenderMode = ToolStripRenderMode.System;
            toolbarMain.Size = new Size(1104, 54);
            toolbarMain.TabIndex = 4;
            // 
            // toolbarbtnManageTeachers
            // 
            toolbarbtnManageTeachers.Image = Properties.Resources.users_51;
            toolbarbtnManageTeachers.ImageTransparentColor = Color.Magenta;
            toolbarbtnManageTeachers.Name = "toolbarbtnManageTeachers";
            toolbarbtnManageTeachers.Padding = new Padding(10, 0, 10, 0);
            toolbarbtnManageTeachers.Size = new Size(122, 51);
            toolbarbtnManageTeachers.Text = "Manage|Teachers";
            toolbarbtnManageTeachers.TextImageRelation = TextImageRelation.ImageAboveText;
            toolbarbtnManageTeachers.ToolTipText = "Edit and manage teachers.";
            toolbarbtnManageTeachers.Click += toolbarbtnManageTeachers_Click;
            // 
            // toolbarbtnManageTimetables
            // 
            toolbarbtnManageTimetables.Image = Properties.Resources.date_time_functions1;
            toolbarbtnManageTimetables.ImageTransparentColor = Color.Magenta;
            toolbarbtnManageTimetables.Name = "toolbarbtnManageTimetables";
            toolbarbtnManageTimetables.Size = new Size(112, 51);
            toolbarbtnManageTimetables.Text = "Manage|timetables";
            toolbarbtnManageTimetables.TextImageRelation = TextImageRelation.ImageAboveText;
            toolbarbtnManageTimetables.ToolTipText = "Edit and manage timetables.";
            toolbarbtnManageTimetables.Click += toolbarbtnManageTimetables_Click;
            // 
            // toolbarbtnManageStudents
            // 
            toolbarbtnManageStudents.Image = Properties.Resources.user_student1;
            toolbarbtnManageStudents.ImageTransparentColor = Color.Magenta;
            toolbarbtnManageStudents.Name = "toolbarbtnManageStudents";
            toolbarbtnManageStudents.Padding = new Padding(10, 0, 10, 0);
            toolbarbtnManageStudents.Size = new Size(123, 51);
            toolbarbtnManageStudents.Text = "Manage|Students";
            toolbarbtnManageStudents.TextImageRelation = TextImageRelation.ImageAboveText;
            toolbarbtnManageStudents.ToolTipText = "Edit and manage timetables.";
            toolbarbtnManageStudents.Click += toolbarbtnManageStudents_Click;
            // 
            // toolbarbtnAddStudent
            // 
            toolbarbtnAddStudent.Image = Properties.Resources.user_add1;
            toolbarbtnAddStudent.ImageTransparentColor = Color.Magenta;
            toolbarbtnAddStudent.Name = "toolbarbtnAddStudent";
            toolbarbtnAddStudent.Padding = new Padding(10, 0, 10, 0);
            toolbarbtnAddStudent.Size = new Size(122, 51);
            toolbarbtnAddStudent.Text = "Add new|Student";
            toolbarbtnAddStudent.TextImageRelation = TextImageRelation.ImageAboveText;
            toolbarbtnAddStudent.ToolTipText = "Adds a new Student to the system.";
            toolbarbtnAddStudent.Click += toolbarbtnAddStudent_Click;
            // 
            // toolbarbtnManageClassrooms
            // 
            toolbarbtnManageClassrooms.Image = Properties.Resources.users_31;
            toolbarbtnManageClassrooms.ImageTransparentColor = Color.Magenta;
            toolbarbtnManageClassrooms.Name = "toolbarbtnManageClassrooms";
            toolbarbtnManageClassrooms.Size = new Size(116, 51);
            toolbarbtnManageClassrooms.Text = "Manage|classrooms";
            toolbarbtnManageClassrooms.TextImageRelation = TextImageRelation.ImageAboveText;
            toolbarbtnManageClassrooms.ToolTipText = "Allocate and manage classroom students.";
            toolbarbtnManageClassrooms.Click += toolbarbtnManageClassrooms_Click;
            // 
            // toolbarbtnAttendanceTracking
            // 
            toolbarbtnAttendanceTracking.Image = Properties.Resources.chart_line1;
            toolbarbtnAttendanceTracking.ImageTransparentColor = Color.Magenta;
            toolbarbtnAttendanceTracking.Name = "toolbarbtnAttendanceTracking";
            toolbarbtnAttendanceTracking.Size = new Size(118, 51);
            toolbarbtnAttendanceTracking.Text = "Attendance|tracking";
            toolbarbtnAttendanceTracking.TextImageRelation = TextImageRelation.ImageAboveText;
            toolbarbtnAttendanceTracking.ToolTipText = "Enter and track each students' attendances.";
            toolbarbtnAttendanceTracking.Click += toolbarbtnAttendanceTracking_Click;
            // 
            // toolbarbtnFeesPayments
            // 
            toolbarbtnFeesPayments.Image = Properties.Resources.table_money1;
            toolbarbtnFeesPayments.ImageTransparentColor = Color.Magenta;
            toolbarbtnFeesPayments.Name = "toolbarbtnFeesPayments";
            toolbarbtnFeesPayments.Size = new Size(112, 51);
            toolbarbtnFeesPayments.Text = "Fees and|payments";
            toolbarbtnFeesPayments.TextImageRelation = TextImageRelation.ImageAboveText;
            toolbarbtnFeesPayments.ToolTipText = "Check dues and monitor transactions for subjects and courses.";
            toolbarbtnFeesPayments.Click += toolbarbtnFeesPayments_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 54);
            // 
            // toolbarbtnNoticeBoard
            // 
            toolbarbtnNoticeBoard.Image = Properties.Resources.notes_pin1;
            toolbarbtnNoticeBoard.ImageTransparentColor = Color.Magenta;
            toolbarbtnNoticeBoard.Name = "toolbarbtnNoticeBoard";
            toolbarbtnNoticeBoard.Size = new Size(80, 51);
            toolbarbtnNoticeBoard.Text = "Notice Board";
            toolbarbtnNoticeBoard.TextImageRelation = TextImageRelation.ImageAboveText;
            toolbarbtnNoticeBoard.ToolTipText = " Events and important messages about the school, will be listed here. Check for automated messages or create a new messages.";
            toolbarbtnNoticeBoard.Click += toolbarbtnNoticeBoard_Click;
            // 
            // toolbardrpdownbtnReportsWizard
            // 
            toolbardrpdownbtnReportsWizard.DropDownItems.AddRange(new ToolStripItem[] { toolbarbtnCreateNewReportWizard, toolbarbtnStoredReports });
            toolbardrpdownbtnReportsWizard.Image = Properties.Resources.report_wizard1;
            toolbardrpdownbtnReportsWizard.ImageTransparentColor = Color.Magenta;
            toolbardrpdownbtnReportsWizard.Name = "toolbardrpdownbtnReportsWizard";
            toolbardrpdownbtnReportsWizard.Size = new Size(99, 51);
            toolbardrpdownbtnReportsWizard.Text = "Reports|Wizard";
            toolbardrpdownbtnReportsWizard.TextImageRelation = TextImageRelation.ImageAboveText;
            toolbardrpdownbtnReportsWizard.ToolTipText = "Create and analyse student information or performances.";
            // 
            // toolbarbtnCreateNewReportWizard
            // 
            toolbarbtnCreateNewReportWizard.Image = Properties.Resources.wizard;
            toolbarbtnCreateNewReportWizard.ImageScaling = ToolStripItemImageScaling.None;
            toolbarbtnCreateNewReportWizard.Name = "toolbarbtnCreateNewReportWizard";
            toolbarbtnCreateNewReportWizard.Size = new Size(233, 22);
            toolbarbtnCreateNewReportWizard.Text = "Create new report with Wizard";
            toolbarbtnCreateNewReportWizard.Click += toolbarbtnCreateNewReportWizard_Click;
            // 
            // toolbarbtnStoredReports
            // 
            toolbarbtnStoredReports.Image = Properties.Resources.saved_imports;
            toolbarbtnStoredReports.ImageScaling = ToolStripItemImageScaling.None;
            toolbarbtnStoredReports.Name = "toolbarbtnStoredReports";
            toolbarbtnStoredReports.Size = new Size(233, 22);
            toolbarbtnStoredReports.Text = "Stored reports";
            toolbarbtnStoredReports.Click += toolbarbtnStoredReports_Click;
            // 
            // toolbarbtnLogOutSystem
            // 
            toolbarbtnLogOutSystem.Alignment = ToolStripItemAlignment.Right;
            toolbarbtnLogOutSystem.Image = Properties.Resources.door_out1;
            toolbarbtnLogOutSystem.ImageTransparentColor = Color.Magenta;
            toolbarbtnLogOutSystem.Name = "toolbarbtnLogOutSystem";
            toolbarbtnLogOutSystem.Padding = new Padding(10, 0, 10, 0);
            toolbarbtnLogOutSystem.Size = new Size(72, 51);
            toolbarbtnLogOutSystem.Text = "Log out";
            toolbarbtnLogOutSystem.TextImageRelation = TextImageRelation.ImageAboveText;
            toolbarbtnLogOutSystem.ToolTipText = "Log out from the system safely and return to the login screen.";
            toolbarbtnLogOutSystem.Click += toolbarbtnLogOutSystem_Click;
            // 
            // panelNoticeBoard
            // 
            panelNoticeBoard.BorderStyle = BorderStyle.Fixed3D;
            panelNoticeBoard.Controls.Add(flowLayoutPanel1);
            panelNoticeBoard.Dock = DockStyle.Right;
            panelNoticeBoard.Location = new Point(783, 78);
            panelNoticeBoard.Margin = new Padding(2);
            panelNoticeBoard.Name = "panelNoticeBoard";
            panelNoticeBoard.Size = new Size(321, 383);
            panelNoticeBoard.TabIndex = 6;
            panelNoticeBoard.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(lblNoticeBoardTitle);
            flowLayoutPanel1.Controls.Add(picbxNoticeBoardImg);
            flowLayoutPanel1.Controls.Add(lblNoticeBoardDesc);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(317, 379);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            // 
            // lblNoticeBoardTitle
            // 
            lblNoticeBoardTitle.AutoSize = true;
            lblNoticeBoardTitle.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNoticeBoardTitle.Location = new Point(2, 8);
            lblNoticeBoardTitle.Margin = new Padding(2, 8, 2, 8);
            lblNoticeBoardTitle.Name = "lblNoticeBoardTitle";
            lblNoticeBoardTitle.Size = new Size(124, 25);
            lblNoticeBoardTitle.TabIndex = 0;
            lblNoticeBoardTitle.Text = "Notice Board";
            // 
            // picbxNoticeBoardImg
            // 
            picbxNoticeBoardImg.Image = Properties.Resources.notes_bg;
            picbxNoticeBoardImg.Location = new Point(2, 43);
            picbxNoticeBoardImg.Margin = new Padding(2);
            picbxNoticeBoardImg.MaximumSize = new Size(310, 170);
            picbxNoticeBoardImg.MinimumSize = new Size(310, 170);
            picbxNoticeBoardImg.Name = "picbxNoticeBoardImg";
            picbxNoticeBoardImg.Size = new Size(310, 170);
            picbxNoticeBoardImg.SizeMode = PictureBoxSizeMode.Zoom;
            picbxNoticeBoardImg.TabIndex = 1;
            picbxNoticeBoardImg.TabStop = false;
            // 
            // lblNoticeBoardDesc
            // 
            lblNoticeBoardDesc.BorderStyle = BorderStyle.Fixed3D;
            lblNoticeBoardDesc.Location = new Point(0, 215);
            lblNoticeBoardDesc.Margin = new Padding(0);
            lblNoticeBoardDesc.MaximumSize = new Size(300, 50);
            lblNoticeBoardDesc.MinimumSize = new Size(300, 50);
            lblNoticeBoardDesc.Name = "lblNoticeBoardDesc";
            lblNoticeBoardDesc.Size = new Size(300, 50);
            lblNoticeBoardDesc.TabIndex = 2;
            lblNoticeBoardDesc.Text = "Events and important messages about the school, will be listed here.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1104, 461);
            Controls.Add(panelNoticeBoard);
            Controls.Add(toolbarMain);
            Controls.Add(menuMain);
            IsMdiContainer = true;
            MainMenuStrip = menuMain;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Skills International Student Manager";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            menuMain.ResumeLayout(false);
            menuMain.PerformLayout();
            toolbarMain.ResumeLayout(false);
            toolbarMain.PerformLayout();
            panelNoticeBoard.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picbxNoticeBoardImg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStripMenuItem menuFile;
        private ToolStripMenuItem menuitemExit;
        private ToolStripMenuItem menuitemLogOutSystem;
        private ToolTip toolTip1;
        private ToolStripButton toolbarbtnLogOutSystem;
        public MenuStrip menuMain;
        public ToolStrip toolbarMain;
        private ToolStripSeparator toolStripSeparator1;
        public ToolStripButton toolbarbtnManageStudents;
        public ToolStripButton toolbarbtnManageTeachers;
        public ToolStripButton toolbarbtnAddStudent;
        public Panel panelNoticeBoard;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblNoticeBoardTitle;
        private PictureBox picbxNoticeBoardImg;
        private Label lblNoticeBoardDesc;
        public ToolStripMenuItem menuitemNoticeBoard;
        public ToolStripButton toolbarbtnNoticeBoard;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem toolbarbtnCreateNewReportWizard;
        private ToolStripMenuItem toolbarbtnStoredReports;
        public ToolStripMenuItem menuAccessLevel;
        public ToolStripMenuItem menuStudents;
        public ToolStripMenuItem menuitemAddStudent;
        public ToolStripMenuItem menuitemManageStudents;
        public ToolStripMenuItem menuAddTeacher;
        public ToolStripMenuItem menuManageTeachers;
        public ToolStripMenuItem menuitemManageAdmins;
        public ToolStripMenuItem menuitemManageParents;
        public ToolStripMenuItem menuitemAbout;
        public ToolStripMenuItem menuitemManageSubjects;
        public ToolStripMenuItem menuitemReportsWizard;
        public ToolStripMenuItem menuitemRefreshDatabase;
        public ToolStripButton toolbarbtnFeesPayments;
        public ToolStripMenuItem menuitemManageTimetables;
        public ToolStripMenuItem menuitemManageClassrooms;
        public ToolStripMenuItem menuitemAttendanceTracking;
        public ToolStripMenuItem menuitemStudentHealthRecords;
        public ToolStripMenuItem menuitemFeesPayments;
        public ToolStripMenuItem menuitemDbSummary;
        public ToolStripButton toolbarbtnAttendanceTracking;
        public ToolStripButton toolbarbtnManageClassrooms;
        public ToolStripButton toolbarbtnManageTimetables;
        public ToolStripMenuItem menuitemStoredReports;
        public ToolStripDropDownButton toolbardrpdownbtnReportsWizard;
        public ToolStripMenuItem menuTeachers;
        public ToolStripMenuItem menuDatabase;
        public ToolStripMenuItem menuHelp;
        public ToolStripMenuItem menuWindow;
        public ToolStripMenuItem menuSchool;
        public ToolStripMenuItem menuReports;
    }
}
