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
            refreshToolStripMenuItem = new ToolStripMenuItem();
            menuitemManageAdmins = new ToolStripMenuItem();
            menuitemLogOutSystem = new ToolStripMenuItem();
            menuSchool = new ToolStripMenuItem();
            menuitemSubjects = new ToolStripMenuItem();
            manageTeachersAttendanceToolStripMenuItem = new ToolStripMenuItem();
            manageStudentAttendanceToolStripMenuItem = new ToolStripMenuItem();
            manageExamsToolStripMenuItem = new ToolStripMenuItem();
            menuStudents = new ToolStripMenuItem();
            menuitemAddStudent = new ToolStripMenuItem();
            menuitemManageStudents = new ToolStripMenuItem();
            menuitemManageParents = new ToolStripMenuItem();
            menuTeachers = new ToolStripMenuItem();
            menuAddTeacher = new ToolStripMenuItem();
            menuManageTeacher = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            menuTeacherNoticeBoard = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            reportingWizardToolStripMenuItem = new ToolStripMenuItem();
            getStudentPerfomanceReportToolStripMenuItem = new ToolStripMenuItem();
            menuWindow = new ToolStripMenuItem();
            menuitemResetLayout = new ToolStripMenuItem();
            menuitemCascadeWindows = new ToolStripMenuItem();
            menuitemHideAll = new ToolStripMenuItem();
            menuHelp = new ToolStripMenuItem();
            menuitemsAbout = new ToolStripMenuItem();
            toolTip1 = new ToolTip(components);
            toolbarMain = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            toolbarbtnAddTeacher = new ToolStripButton();
            toolbarbtnManageTeachers = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            toolbarbtnAddStudent = new ToolStripButton();
            toolbarbtnManageStudents = new ToolStripButton();
            toolbarbtnManageParents = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolbarbtnManageSubjects = new ToolStripButton();
            toolbarbtnLogOutSystem = new ToolStripButton();
            panelNoticeBoard = new Panel();
            menuMain.SuspendLayout();
            toolbarMain.SuspendLayout();
            SuspendLayout();
            // 
            // menuMain
            // 
            menuMain.BackColor = SystemColors.Control;
            menuMain.ImageScalingSize = new Size(20, 20);
            menuMain.Items.AddRange(new ToolStripItem[] { menuFile, menuDatabase, menuSchool, menuStudents, menuTeachers, reportsToolStripMenuItem, menuWindow, menuHelp });
            menuMain.Location = new Point(0, 0);
            menuMain.MdiWindowListItem = menuWindow;
            menuMain.Name = "menuMain";
            menuMain.Padding = new Padding(8, 2, 0, 2);
            menuMain.RenderMode = ToolStripRenderMode.Professional;
            menuMain.Size = new Size(1182, 28);
            menuMain.TabIndex = 1;
            // 
            // menuFile
            // 
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { menuitemExit });
            menuFile.Name = "menuFile";
            menuFile.Padding = new Padding(6, 0, 6, 0);
            menuFile.Size = new Size(48, 24);
            menuFile.Text = "&File";
            // 
            // menuitemExit
            // 
            menuitemExit.Image = Properties.Resources.cancel;
            menuitemExit.Name = "menuitemExit";
            menuitemExit.ShortcutKeys = Keys.Alt | Keys.F4;
            menuitemExit.Size = new Size(169, 26);
            menuitemExit.Text = "E&xit";
            menuitemExit.Click += menuitemExit_Click;
            // 
            // menuDatabase
            // 
            menuDatabase.DropDownItems.AddRange(new ToolStripItem[] { refreshToolStripMenuItem, menuitemManageAdmins, menuitemLogOutSystem });
            menuDatabase.Name = "menuDatabase";
            menuDatabase.Padding = new Padding(6, 0, 6, 0);
            menuDatabase.Size = new Size(88, 24);
            menuDatabase.Text = "Database";
            // 
            // refreshToolStripMenuItem
            // 
            refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            refreshToolStripMenuItem.ShortcutKeys = Keys.F5;
            refreshToolStripMenuItem.Size = new Size(243, 26);
            refreshToolStripMenuItem.Text = "Refresh";
            // 
            // menuitemManageAdmins
            // 
            menuitemManageAdmins.Image = Properties.Resources.administrator;
            menuitemManageAdmins.Name = "menuitemManageAdmins";
            menuitemManageAdmins.ShortcutKeys = Keys.F2;
            menuitemManageAdmins.Size = new Size(243, 26);
            menuitemManageAdmins.Text = "Manage admins";
            // 
            // menuitemLogOutSystem
            // 
            menuitemLogOutSystem.Image = Properties.Resources.door_out;
            menuitemLogOutSystem.Name = "menuitemLogOutSystem";
            menuitemLogOutSystem.ShortcutKeys = Keys.Control | Keys.X;
            menuitemLogOutSystem.Size = new Size(243, 26);
            menuitemLogOutSystem.Text = "Log out system";
            menuitemLogOutSystem.Click += menuitemLogOutSystem_Click;
            // 
            // menuSchool
            // 
            menuSchool.DropDownItems.AddRange(new ToolStripItem[] { menuitemSubjects, manageTeachersAttendanceToolStripMenuItem, manageStudentAttendanceToolStripMenuItem, manageExamsToolStripMenuItem });
            menuSchool.Name = "menuSchool";
            menuSchool.Padding = new Padding(6, 0, 6, 0);
            menuSchool.Size = new Size(70, 24);
            menuSchool.Text = "School";
            // 
            // menuitemSubjects
            // 
            menuitemSubjects.Image = Properties.Resources.books_stack;
            menuitemSubjects.Name = "menuitemSubjects";
            menuitemSubjects.Size = new Size(285, 26);
            menuitemSubjects.Text = "Manage S&ubjects/Courses";
            // 
            // manageTeachersAttendanceToolStripMenuItem
            // 
            manageTeachersAttendanceToolStripMenuItem.Name = "manageTeachersAttendanceToolStripMenuItem";
            manageTeachersAttendanceToolStripMenuItem.Size = new Size(285, 26);
            manageTeachersAttendanceToolStripMenuItem.Text = "Manage Teachers attendance";
            // 
            // manageStudentAttendanceToolStripMenuItem
            // 
            manageStudentAttendanceToolStripMenuItem.Name = "manageStudentAttendanceToolStripMenuItem";
            manageStudentAttendanceToolStripMenuItem.Size = new Size(285, 26);
            manageStudentAttendanceToolStripMenuItem.Text = "Manage Student attendance";
            // 
            // manageExamsToolStripMenuItem
            // 
            manageExamsToolStripMenuItem.Name = "manageExamsToolStripMenuItem";
            manageExamsToolStripMenuItem.Size = new Size(285, 26);
            manageExamsToolStripMenuItem.Text = "Manage exams";
            // 
            // menuStudents
            // 
            menuStudents.DropDownItems.AddRange(new ToolStripItem[] { menuitemAddStudent, menuitemManageStudents, menuitemManageParents });
            menuStudents.Name = "menuStudents";
            menuStudents.Padding = new Padding(6, 0, 6, 0);
            menuStudents.Size = new Size(82, 24);
            menuStudents.Text = "&Students";
            // 
            // menuitemAddStudent
            // 
            menuitemAddStudent.Image = Properties.Resources.user_add;
            menuitemAddStudent.Name = "menuitemAddStudent";
            menuitemAddStudent.ShortcutKeys = Keys.Control | Keys.F3;
            menuitemAddStudent.Size = new Size(333, 26);
            menuitemAddStudent.Text = "&Add new student";
            menuitemAddStudent.Click += menuitemAddStudent_Click;
            // 
            // menuitemManageStudents
            // 
            menuitemManageStudents.Image = Properties.Resources.user_student;
            menuitemManageStudents.Name = "menuitemManageStudents";
            menuitemManageStudents.ShortcutKeys = Keys.F3;
            menuitemManageStudents.Size = new Size(333, 26);
            menuitemManageStudents.Text = "Manage &Students";
            menuitemManageStudents.Click += menuitemManageStudents_Click;
            // 
            // menuitemManageParents
            // 
            menuitemManageParents.Image = Properties.Resources.users_men_women;
            menuitemManageParents.Name = "menuitemManageParents";
            menuitemManageParents.ShortcutKeys = Keys.Shift | Keys.F3;
            menuitemManageParents.Size = new Size(333, 26);
            menuitemManageParents.Text = "Manage &Parents/Guardians";
            // 
            // menuTeachers
            // 
            menuTeachers.DropDownItems.AddRange(new ToolStripItem[] { menuAddTeacher, menuManageTeacher, toolStripSeparator2, menuTeacherNoticeBoard });
            menuTeachers.Name = "menuTeachers";
            menuTeachers.Padding = new Padding(6, 0, 6, 0);
            menuTeachers.Size = new Size(82, 24);
            menuTeachers.Text = "&Teachers";
            // 
            // menuAddTeacher
            // 
            menuAddTeacher.Image = Properties.Resources.user_add;
            menuAddTeacher.Name = "menuAddTeacher";
            menuAddTeacher.ShortcutKeys = Keys.Control | Keys.F4;
            menuAddTeacher.Size = new Size(261, 26);
            menuAddTeacher.Text = "&Add new teacher";
            // 
            // menuManageTeacher
            // 
            menuManageTeacher.Image = Properties.Resources.users_5;
            menuManageTeacher.Name = "menuManageTeacher";
            menuManageTeacher.ShortcutKeys = Keys.F4;
            menuManageTeacher.Size = new Size(261, 26);
            menuManageTeacher.Text = "Manage &Teachers";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(258, 6);
            // 
            // menuTeacherNoticeBoard
            // 
            menuTeacherNoticeBoard.Checked = true;
            menuTeacherNoticeBoard.CheckOnClick = true;
            menuTeacherNoticeBoard.CheckState = CheckState.Checked;
            menuTeacherNoticeBoard.Image = Properties.Resources.notes_pin;
            menuTeacherNoticeBoard.Name = "menuTeacherNoticeBoard";
            menuTeacherNoticeBoard.Size = new Size(261, 26);
            menuTeacherNoticeBoard.Text = "Teacher's notice board";
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { reportingWizardToolStripMenuItem, getStudentPerfomanceReportToolStripMenuItem });
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Padding = new Padding(6, 0, 6, 0);
            reportsToolStripMenuItem.Size = new Size(76, 24);
            reportsToolStripMenuItem.Text = "&Reports";
            // 
            // reportingWizardToolStripMenuItem
            // 
            reportingWizardToolStripMenuItem.Image = Properties.Resources.report_wizard;
            reportingWizardToolStripMenuItem.Name = "reportingWizardToolStripMenuItem";
            reportingWizardToolStripMenuItem.Size = new Size(297, 26);
            reportingWizardToolStripMenuItem.Text = "Reports &wizard";
            // 
            // getStudentPerfomanceReportToolStripMenuItem
            // 
            getStudentPerfomanceReportToolStripMenuItem.Image = Properties.Resources.chart_line;
            getStudentPerfomanceReportToolStripMenuItem.Name = "getStudentPerfomanceReportToolStripMenuItem";
            getStudentPerfomanceReportToolStripMenuItem.Size = new Size(297, 26);
            getStudentPerfomanceReportToolStripMenuItem.Text = "Get student perfomance report";
            // 
            // menuWindow
            // 
            menuWindow.DropDownItems.AddRange(new ToolStripItem[] { menuitemResetLayout, menuitemCascadeWindows, menuitemHideAll });
            menuWindow.Name = "menuWindow";
            menuWindow.Padding = new Padding(6, 0, 6, 0);
            menuWindow.Size = new Size(80, 24);
            menuWindow.Text = "&Window";
            // 
            // menuitemResetLayout
            // 
            menuitemResetLayout.Name = "menuitemResetLayout";
            menuitemResetLayout.Size = new Size(229, 26);
            menuitemResetLayout.Text = "Reset window layout";
            // 
            // menuitemCascadeWindows
            // 
            menuitemCascadeWindows.Name = "menuitemCascadeWindows";
            menuitemCascadeWindows.Size = new Size(229, 26);
            menuitemCascadeWindows.Text = "Cascade windows";
            // 
            // menuitemHideAll
            // 
            menuitemHideAll.Name = "menuitemHideAll";
            menuitemHideAll.Size = new Size(229, 26);
            menuitemHideAll.Text = "Hide all";
            // 
            // menuHelp
            // 
            menuHelp.DropDownItems.AddRange(new ToolStripItem[] { menuitemsAbout });
            menuHelp.Name = "menuHelp";
            menuHelp.Padding = new Padding(6, 0, 6, 0);
            menuHelp.Size = new Size(57, 24);
            menuHelp.Text = "&Help";
            // 
            // menuitemsAbout
            // 
            menuitemsAbout.Image = Properties.Resources.information;
            menuitemsAbout.Name = "menuitemsAbout";
            menuitemsAbout.ShortcutKeys = Keys.F1;
            menuitemsAbout.Size = new Size(275, 26);
            menuitemsAbout.Text = "About Student Manager";
            // 
            // toolbarMain
            // 
            toolbarMain.GripStyle = ToolStripGripStyle.Hidden;
            toolbarMain.ImageScalingSize = new Size(32, 32);
            toolbarMain.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripSeparator4, toolbarbtnAddTeacher, toolbarbtnManageTeachers, toolStripSeparator3, toolbarbtnAddStudent, toolbarbtnManageStudents, toolbarbtnManageParents, toolStripSeparator1, toolbarbtnManageSubjects, toolbarbtnLogOutSystem });
            toolbarMain.Location = new Point(0, 28);
            toolbarMain.Name = "toolbarMain";
            toolbarMain.RenderMode = ToolStripRenderMode.System;
            toolbarMain.Size = new Size(1182, 59);
            toolbarMain.TabIndex = 4;
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = Properties.Resources.report_wizard1;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Padding = new Padding(10, 0, 10, 0);
            toolStripButton1.Size = new Size(129, 56);
            toolStripButton1.Text = "Report|Wizard";
            toolStripButton1.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 59);
            // 
            // toolbarbtnAddTeacher
            // 
            toolbarbtnAddTeacher.Image = Properties.Resources.user_add1;
            toolbarbtnAddTeacher.ImageTransparentColor = Color.Magenta;
            toolbarbtnAddTeacher.Name = "toolbarbtnAddTeacher";
            toolbarbtnAddTeacher.Padding = new Padding(10, 0, 10, 0);
            toolbarbtnAddTeacher.Size = new Size(147, 56);
            toolbarbtnAddTeacher.Text = "Add new|Teacher";
            toolbarbtnAddTeacher.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolbarbtnManageTeachers
            // 
            toolbarbtnManageTeachers.Image = Properties.Resources.users_51;
            toolbarbtnManageTeachers.ImageTransparentColor = Color.Magenta;
            toolbarbtnManageTeachers.Name = "toolbarbtnManageTeachers";
            toolbarbtnManageTeachers.Padding = new Padding(10, 0, 10, 0);
            toolbarbtnManageTeachers.Size = new Size(148, 56);
            toolbarbtnManageTeachers.Text = "Manage|Teachers";
            toolbarbtnManageTeachers.TextImageRelation = TextImageRelation.ImageAboveText;
            toolbarbtnManageTeachers.ToolTipText = "Opens the \"Teachers\" window, where you can edit\r\nor remove teachers. (F4)";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 59);
            // 
            // toolbarbtnAddStudent
            // 
            toolbarbtnAddStudent.Image = Properties.Resources.user_add1;
            toolbarbtnAddStudent.ImageTransparentColor = Color.Magenta;
            toolbarbtnAddStudent.Name = "toolbarbtnAddStudent";
            toolbarbtnAddStudent.Padding = new Padding(10, 0, 10, 0);
            toolbarbtnAddStudent.Size = new Size(147, 56);
            toolbarbtnAddStudent.Text = "Add new|Student";
            toolbarbtnAddStudent.TextImageRelation = TextImageRelation.ImageAboveText;
            toolbarbtnAddStudent.Click += toolbarbtnAddStudent_Click;
            // 
            // toolbarbtnManageStudents
            // 
            toolbarbtnManageStudents.Image = Properties.Resources.user_student1;
            toolbarbtnManageStudents.ImageTransparentColor = Color.Magenta;
            toolbarbtnManageStudents.Name = "toolbarbtnManageStudents";
            toolbarbtnManageStudents.Padding = new Padding(10, 0, 10, 0);
            toolbarbtnManageStudents.Size = new Size(148, 56);
            toolbarbtnManageStudents.Text = "Manage|Students";
            toolbarbtnManageStudents.TextImageRelation = TextImageRelation.ImageAboveText;
            toolbarbtnManageStudents.ToolTipText = "Opens the \"Students\" window, where you can edit\r\nor remove students. (F3)";
            toolbarbtnManageStudents.Click += toolbarbtnManageStudents_Click;
            // 
            // toolbarbtnManageParents
            // 
            toolbarbtnManageParents.Image = Properties.Resources.users_men_women1;
            toolbarbtnManageParents.ImageTransparentColor = Color.Magenta;
            toolbarbtnManageParents.Name = "toolbarbtnManageParents";
            toolbarbtnManageParents.Padding = new Padding(10, 0, 10, 0);
            toolbarbtnManageParents.Size = new Size(210, 56);
            toolbarbtnManageParents.Text = "Manage|Parents/Guardians";
            toolbarbtnManageParents.TextImageRelation = TextImageRelation.ImageAboveText;
            toolbarbtnManageParents.ToolTipText = "Opens the \"Parents/Guardian\" window, where you can edit\r\nor remove parents. (Shift+F3)";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 59);
            // 
            // toolbarbtnManageSubjects
            // 
            toolbarbtnManageSubjects.Image = Properties.Resources.books_stack1;
            toolbarbtnManageSubjects.ImageTransparentColor = Color.Magenta;
            toolbarbtnManageSubjects.Name = "toolbarbtnManageSubjects";
            toolbarbtnManageSubjects.Padding = new Padding(10, 0, 10, 0);
            toolbarbtnManageSubjects.Size = new Size(146, 56);
            toolbarbtnManageSubjects.Text = "Manage|Subjects";
            toolbarbtnManageSubjects.TextImageRelation = TextImageRelation.ImageAboveText;
            toolbarbtnManageSubjects.ToolTipText = "Opens the \"Subjects/Courses\" window, where you can edit\r\nor remove subjects or courses. ";
            // 
            // toolbarbtnLogOutSystem
            // 
            toolbarbtnLogOutSystem.Alignment = ToolStripItemAlignment.Right;
            toolbarbtnLogOutSystem.Image = Properties.Resources.door_out1;
            toolbarbtnLogOutSystem.ImageTransparentColor = Color.Magenta;
            toolbarbtnLogOutSystem.Name = "toolbarbtnLogOutSystem";
            toolbarbtnLogOutSystem.Padding = new Padding(10, 0, 10, 0);
            toolbarbtnLogOutSystem.Size = new Size(84, 56);
            toolbarbtnLogOutSystem.Text = "Log out";
            toolbarbtnLogOutSystem.TextImageRelation = TextImageRelation.ImageAboveText;
            toolbarbtnLogOutSystem.ToolTipText = "Log out from the system safely and return to the login screen.";
            toolbarbtnLogOutSystem.Click += toolbarbtnLogOutSystem_Click;
            // 
            // panelNoticeBoard
            // 
            panelNoticeBoard.BorderStyle = BorderStyle.Fixed3D;
            panelNoticeBoard.Dock = DockStyle.Right;
            panelNoticeBoard.Location = new Point(797, 87);
            panelNoticeBoard.Name = "panelNoticeBoard";
            panelNoticeBoard.Size = new Size(385, 666);
            panelNoticeBoard.TabIndex = 6;
            panelNoticeBoard.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1182, 753);
            Controls.Add(panelNoticeBoard);
            Controls.Add(toolbarMain);
            Controls.Add(menuMain);
            IsMdiContainer = true;
            MainMenuStrip = menuMain;
            Margin = new Padding(4);
            MinimumSize = new Size(1200, 800);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Skills International Student Manager";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            menuMain.ResumeLayout(false);
            menuMain.PerformLayout();
            toolbarMain.ResumeLayout(false);
            toolbarMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStripMenuItem menuFile;
        private ToolStripMenuItem menuitemExit;
        private ToolStripMenuItem menuStudents;
        private ToolStripMenuItem menuitemAddStudent;
        private ToolStripMenuItem menuitemManageStudents;
        private ToolStripMenuItem menuTeachers;
        private ToolStripMenuItem menuAddTeacher;
        private ToolStripMenuItem menuManageTeacher;
        private ToolStripMenuItem menuDatabase;
        private ToolStripMenuItem menuitemManageAdmins;
        private ToolStripMenuItem menuitemLogOutSystem;
        private ToolStripMenuItem menuitemManageParents;
        private ToolStripMenuItem menuTeacherNoticeBoard;
        private ToolStripMenuItem menuHelp;
        private ToolStripMenuItem menuitemsAbout;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem menuWindow;
        private ToolTip toolTip1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem menuitemResetLayout;
        private ToolStripMenuItem menuitemCascadeWindows;
        private ToolStripMenuItem menuitemHideAll;
        private ToolStripButton toolbarbtnNoticeBoard;
        private ToolStripButton toolbarbtnLogOutSystem;
        public MenuStrip menuMain;
        public ToolStrip toolbarMain;
        private ToolStripMenuItem menuSchool;
        private ToolStripMenuItem menuitemSubjects;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private ToolStripMenuItem getStudentPerfomanceReportToolStripMenuItem;
        private ToolStripMenuItem reportingWizardToolStripMenuItem;
        private ToolStripMenuItem refreshToolStripMenuItem;
        private ToolStripMenuItem manageTeachersAttendanceToolStripMenuItem;
        private ToolStripMenuItem manageStudentAttendanceToolStripMenuItem;
        private ToolStripMenuItem manageExamsToolStripMenuItem;
        public ToolStripButton toolbarbtnManageStudents;
        public ToolStripButton toolbarbtnManageTeachers;
        public ToolStripButton toolbarbtnManageSubjects;
        public ToolStripButton toolbarbtnManageParents;
        public ToolStripButton toolbarbtnAddTeacher;
        public ToolStripButton toolbarbtnAddStudent;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator4;
        public Panel panelNoticeBoard;
    }
}
