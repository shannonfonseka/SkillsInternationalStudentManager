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
            menuitemLogOutSystem = new ToolStripMenuItem();
            menuStudents = new ToolStripMenuItem();
            menuitemAddStudent = new ToolStripMenuItem();
            menuitemManageStudents = new ToolStripMenuItem();
            menuitemManageParents = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            menuitemSubjects = new ToolStripMenuItem();
            menuTeachers = new ToolStripMenuItem();
            menuAddTeacher = new ToolStripMenuItem();
            menuManageTeacher = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            menuTeacherNoticeBoard = new ToolStripMenuItem();
            menuWindow = new ToolStripMenuItem();
            menuitemResetLayout = new ToolStripMenuItem();
            menuitemCascadeWindows = new ToolStripMenuItem();
            menuitemHideAll = new ToolStripMenuItem();
            menuHelp = new ToolStripMenuItem();
            menuitemsAbout = new ToolStripMenuItem();
            toolTip1 = new ToolTip(components);
            toolbarMain = new ToolStrip();
            toolbarbtnManageStudents = new ToolStripButton();
            toolbarbtnManageParents = new ToolStripButton();
            toolbarbtnManageSubjects = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            toolbarManageTeachers = new ToolStripButton();
            toolbarbtnNoticeBoard = new ToolStripButton();
            toolbarbtnLogOutSystem = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            menuMain.SuspendLayout();
            toolbarMain.SuspendLayout();
            SuspendLayout();
            // 
            // menuMain
            // 
            menuMain.BackColor = SystemColors.Control;
            menuMain.ImageScalingSize = new Size(20, 20);
            menuMain.Items.AddRange(new ToolStripItem[] { menuFile, menuDatabase, menuStudents, menuTeachers, menuWindow, menuHelp });
            menuMain.Location = new Point(0, 0);
            menuMain.MdiWindowListItem = menuWindow;
            menuMain.Name = "menuMain";
            menuMain.RenderMode = ToolStripRenderMode.Professional;
            menuMain.Size = new Size(882, 28);
            menuMain.TabIndex = 1;
            // 
            // menuFile
            // 
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { menuitemExit });
            menuFile.Name = "menuFile";
            menuFile.Size = new Size(46, 24);
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
            menuDatabase.DropDownItems.AddRange(new ToolStripItem[] { menuitemManageAdmins, menuitemLogOutSystem });
            menuDatabase.Name = "menuDatabase";
            menuDatabase.Size = new Size(86, 24);
            menuDatabase.Text = "Database";
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
            // menuStudents
            // 
            menuStudents.DropDownItems.AddRange(new ToolStripItem[] { menuitemAddStudent, menuitemManageStudents, menuitemManageParents, toolStripSeparator1, menuitemSubjects });
            menuStudents.Name = "menuStudents";
            menuStudents.Size = new Size(80, 24);
            menuStudents.Text = "&Students";
            // 
            // menuitemAddStudent
            // 
            menuitemAddStudent.Image = Properties.Resources.user_add;
            menuitemAddStudent.Name = "menuitemAddStudent";
            menuitemAddStudent.ShortcutKeys = Keys.Control | Keys.F3;
            menuitemAddStudent.Size = new Size(333, 26);
            menuitemAddStudent.Text = "&Add new student";
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
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(330, 6);
            // 
            // menuitemSubjects
            // 
            menuitemSubjects.Image = Properties.Resources.books_stack;
            menuitemSubjects.Name = "menuitemSubjects";
            menuitemSubjects.Size = new Size(333, 26);
            menuitemSubjects.Text = "Manage S&ubjects/Courses";
            // 
            // menuTeachers
            // 
            menuTeachers.DropDownItems.AddRange(new ToolStripItem[] { menuAddTeacher, menuManageTeacher, toolStripSeparator2, menuTeacherNoticeBoard });
            menuTeachers.Name = "menuTeachers";
            menuTeachers.Size = new Size(80, 24);
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
            menuTeacherNoticeBoard.Image = Properties.Resources.notes_pin;
            menuTeacherNoticeBoard.Name = "menuTeacherNoticeBoard";
            menuTeacherNoticeBoard.Size = new Size(261, 26);
            menuTeacherNoticeBoard.Text = "Teacher's notice board";
            // 
            // menuWindow
            // 
            menuWindow.DropDownItems.AddRange(new ToolStripItem[] { menuitemResetLayout, menuitemCascadeWindows, menuitemHideAll });
            menuWindow.Name = "menuWindow";
            menuWindow.Size = new Size(78, 24);
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
            menuHelp.Size = new Size(55, 24);
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
            toolbarMain.Items.AddRange(new ToolStripItem[] { toolbarbtnManageStudents, toolbarbtnManageParents, toolbarbtnManageSubjects, toolStripSeparator3, toolbarManageTeachers, toolbarbtnNoticeBoard, toolbarbtnLogOutSystem, toolStripSeparator4 });
            toolbarMain.Location = new Point(0, 28);
            toolbarMain.Name = "toolbarMain";
            toolbarMain.RenderMode = ToolStripRenderMode.System;
            toolbarMain.Size = new Size(882, 62);
            toolbarMain.TabIndex = 4;
            // 
            // toolbarbtnManageStudents
            // 
            toolbarbtnManageStudents.Image = Properties.Resources.user_student1;
            toolbarbtnManageStudents.ImageTransparentColor = Color.Magenta;
            toolbarbtnManageStudents.Name = "toolbarbtnManageStudents";
            toolbarbtnManageStudents.Padding = new Padding(5, 2, 5, 1);
            toolbarbtnManageStudents.Size = new Size(80, 59);
            toolbarbtnManageStudents.Text = "Students";
            toolbarbtnManageStudents.TextImageRelation = TextImageRelation.ImageAboveText;
            toolbarbtnManageStudents.ToolTipText = "Opens the \"Students\" window, where you can edit\r\nor remove students. (F3)";
            toolbarbtnManageStudents.Click += toolbarbtnManageStudents_Click;
            // 
            // toolbarbtnManageParents
            // 
            toolbarbtnManageParents.Image = Properties.Resources.users_men_women1;
            toolbarbtnManageParents.ImageTransparentColor = Color.Magenta;
            toolbarbtnManageParents.Name = "toolbarbtnManageParents";
            toolbarbtnManageParents.Padding = new Padding(5, 2, 5, 1);
            toolbarbtnManageParents.Size = new Size(142, 59);
            toolbarbtnManageParents.Text = "Parents/Guardians";
            toolbarbtnManageParents.TextImageRelation = TextImageRelation.ImageAboveText;
            toolbarbtnManageParents.ToolTipText = "Opens the \"Parents/Guardian\" window, where you can edit\r\nor remove parents. (Shift+F3)";
            // 
            // toolbarbtnManageSubjects
            // 
            toolbarbtnManageSubjects.Image = Properties.Resources.books_stack1;
            toolbarbtnManageSubjects.ImageTransparentColor = Color.Magenta;
            toolbarbtnManageSubjects.Name = "toolbarbtnManageSubjects";
            toolbarbtnManageSubjects.Padding = new Padding(5, 2, 5, 1);
            toolbarbtnManageSubjects.Size = new Size(135, 59);
            toolbarbtnManageSubjects.Text = "Subjects/Courses";
            toolbarbtnManageSubjects.TextImageRelation = TextImageRelation.ImageAboveText;
            toolbarbtnManageSubjects.ToolTipText = "Opens the \"Subjects/Courses\" window, where you can edit\r\nor remove subjects or courses. ";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 62);
            // 
            // toolbarManageTeachers
            // 
            toolbarManageTeachers.Image = Properties.Resources.users_51;
            toolbarManageTeachers.ImageTransparentColor = Color.Magenta;
            toolbarManageTeachers.Name = "toolbarManageTeachers";
            toolbarManageTeachers.Padding = new Padding(5, 2, 5, 1);
            toolbarManageTeachers.Size = new Size(80, 59);
            toolbarManageTeachers.Text = "Teachers";
            toolbarManageTeachers.TextImageRelation = TextImageRelation.ImageAboveText;
            toolbarManageTeachers.ToolTipText = "Opens the \"Teachers\" window, where you can edit\r\nor remove teachers. (F4)";
            // 
            // toolbarbtnNoticeBoard
            // 
            toolbarbtnNoticeBoard.Image = Properties.Resources.notes_pin1;
            toolbarbtnNoticeBoard.ImageTransparentColor = Color.Magenta;
            toolbarbtnNoticeBoard.Name = "toolbarbtnNoticeBoard";
            toolbarbtnNoticeBoard.Padding = new Padding(5, 2, 5, 1);
            toolbarbtnNoticeBoard.Size = new Size(111, 59);
            toolbarbtnNoticeBoard.Text = "Notice Board";
            toolbarbtnNoticeBoard.TextImageRelation = TextImageRelation.ImageAboveText;
            toolbarbtnNoticeBoard.ToolTipText = "Opens the \"Notice Board\" window, where teachers can check for\r\nmessages about school activites or events.";
            // 
            // toolbarbtnLogOutSystem
            // 
            toolbarbtnLogOutSystem.Alignment = ToolStripItemAlignment.Right;
            toolbarbtnLogOutSystem.Image = Properties.Resources.door_out1;
            toolbarbtnLogOutSystem.ImageTransparentColor = Color.Magenta;
            toolbarbtnLogOutSystem.Name = "toolbarbtnLogOutSystem";
            toolbarbtnLogOutSystem.Padding = new Padding(5, 2, 5, 1);
            toolbarbtnLogOutSystem.Size = new Size(74, 59);
            toolbarbtnLogOutSystem.Text = "Log out";
            toolbarbtnLogOutSystem.TextImageRelation = TextImageRelation.ImageAboveText;
            toolbarbtnLogOutSystem.ToolTipText = "Log out from the system safely and return to the login screen.";
            toolbarbtnLogOutSystem.Click += toolbarbtnLogOutSystem_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Alignment = ToolStripItemAlignment.Right;
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 62);
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(882, 553);
            Controls.Add(toolbarMain);
            Controls.Add(menuMain);
            IsMdiContainer = true;
            MainMenuStrip = menuMain;
            MinimumSize = new Size(900, 600);
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
        private ToolStripMenuItem menuitemSubjects;
        private ToolStripMenuItem menuitemManageParents;
        private ToolStripMenuItem menuTeacherNoticeBoard;
        private ToolStripMenuItem menuHelp;
        private ToolStripMenuItem menuitemsAbout;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem menuWindow;
        private ToolTip toolTip1;
        private ToolStripButton toolbarbtnManageStudents;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton toolbarManageTeachers;
        private ToolStripButton toolbarbtnManageSubjects;
        private ToolStripButton toolbarbtnManageParents;
        private ToolStripMenuItem menuitemResetLayout;
        private ToolStripMenuItem menuitemCascadeWindows;
        private ToolStripMenuItem menuitemHideAll;
        private ToolStripButton toolbarbtnNoticeBoard;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton toolbarbtnLogOutSystem;
        public MenuStrip menuMain;
        public ToolStrip toolbarMain;
    }
}
