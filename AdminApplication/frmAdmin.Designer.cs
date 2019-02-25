namespace AdminApplication
{
    partial class frmAdmin
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.newProjectGroupBox = new System.Windows.Forms.GroupBox();
            this.btnAddProject = new System.Windows.Forms.Button();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.txtProjectEnd = new System.Windows.Forms.TextBox();
            this.txtProjectStart = new System.Windows.Forms.TextBox();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.npLbl4 = new System.Windows.Forms.Label();
            this.npLbl3 = new System.Windows.Forms.Label();
            this.npLbl2 = new System.Windows.Forms.Label();
            this.npLbl1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.npTasksGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbTasks = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.cbTeams = new System.Windows.Forms.ComboBox();
            this.txtTaskEnd = new System.Windows.Forms.TextBox();
            this.txtTaskStart = new System.Windows.Forms.TextBox();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbProjects = new System.Windows.Forms.ComboBox();
            this.tasksLbl1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.newProjectGroupBox.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.npTasksGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(171, 26);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(155, 22);
            this.txtUsername.TabIndex = 0;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(85, 30);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(77, 17);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(460, 26);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(155, 22);
            this.txtPassword.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(377, 30);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 17);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(720, 22);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 28);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(16, 75);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(920, 514);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lblWelcome);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(912, 485);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Welcome";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(552, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "In order to start using the tool, you must log in using the fields above";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(284, 97);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(318, 22);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to the Administrator Tool";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(912, 485);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Projects";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(8, 7);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(893, 468);
            this.tabControl2.TabIndex = 0;
            this.tabControl2.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl2_Selected);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.newProjectGroupBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Size = new System.Drawing.Size(885, 439);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "New";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // newProjectGroupBox
            // 
            this.newProjectGroupBox.Controls.Add(this.btnAddProject);
            this.newProjectGroupBox.Controls.Add(this.cbCustomer);
            this.newProjectGroupBox.Controls.Add(this.txtProjectEnd);
            this.newProjectGroupBox.Controls.Add(this.txtProjectStart);
            this.newProjectGroupBox.Controls.Add(this.txtProjectName);
            this.newProjectGroupBox.Controls.Add(this.npLbl4);
            this.newProjectGroupBox.Controls.Add(this.npLbl3);
            this.newProjectGroupBox.Controls.Add(this.npLbl2);
            this.newProjectGroupBox.Controls.Add(this.npLbl1);
            this.newProjectGroupBox.Location = new System.Drawing.Point(45, 37);
            this.newProjectGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newProjectGroupBox.Name = "newProjectGroupBox";
            this.newProjectGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newProjectGroupBox.Size = new System.Drawing.Size(404, 263);
            this.newProjectGroupBox.TabIndex = 1;
            this.newProjectGroupBox.TabStop = false;
            this.newProjectGroupBox.Text = "Add New Project";
            // 
            // btnAddProject
            // 
            this.btnAddProject.Location = new System.Drawing.Point(180, 196);
            this.btnAddProject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(100, 28);
            this.btnAddProject.TabIndex = 8;
            this.btnAddProject.Text = "Add";
            this.btnAddProject.UseVisualStyleBackColor = true;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // cbCustomer
            // 
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(180, 143);
            this.cbCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(160, 24);
            this.cbCustomer.TabIndex = 7;
            // 
            // txtProjectEnd
            // 
            this.txtProjectEnd.Location = new System.Drawing.Point(181, 111);
            this.txtProjectEnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProjectEnd.Name = "txtProjectEnd";
            this.txtProjectEnd.Size = new System.Drawing.Size(132, 22);
            this.txtProjectEnd.TabIndex = 6;
            // 
            // txtProjectStart
            // 
            this.txtProjectStart.Location = new System.Drawing.Point(181, 79);
            this.txtProjectStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProjectStart.Name = "txtProjectStart";
            this.txtProjectStart.Size = new System.Drawing.Size(132, 22);
            this.txtProjectStart.TabIndex = 5;
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(181, 47);
            this.txtProjectName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(132, 22);
            this.txtProjectName.TabIndex = 4;
            // 
            // npLbl4
            // 
            this.npLbl4.AutoSize = true;
            this.npLbl4.Location = new System.Drawing.Point(84, 146);
            this.npLbl4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.npLbl4.Name = "npLbl4";
            this.npLbl4.Size = new System.Drawing.Size(72, 17);
            this.npLbl4.TabIndex = 3;
            this.npLbl4.Text = "Customer:";
            // 
            // npLbl3
            // 
            this.npLbl3.AutoSize = true;
            this.npLbl3.Location = new System.Drawing.Point(53, 114);
            this.npLbl3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.npLbl3.Name = "npLbl3";
            this.npLbl3.Size = new System.Drawing.Size(99, 17);
            this.npLbl3.TabIndex = 2;
            this.npLbl3.Text = "Expected End:";
            // 
            // npLbl2
            // 
            this.npLbl2.AutoSize = true;
            this.npLbl2.Location = new System.Drawing.Point(49, 82);
            this.npLbl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.npLbl2.Name = "npLbl2";
            this.npLbl2.Size = new System.Drawing.Size(104, 17);
            this.npLbl2.TabIndex = 1;
            this.npLbl2.Text = "Expected Start:";
            // 
            // npLbl1
            // 
            this.npLbl1.AutoSize = true;
            this.npLbl1.Location = new System.Drawing.Point(105, 50);
            this.npLbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.npLbl1.Name = "npLbl1";
            this.npLbl1.Size = new System.Drawing.Size(49, 17);
            this.npLbl1.TabIndex = 0;
            this.npLbl1.Text = "Name:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.npTasksGroupBox);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage4.Size = new System.Drawing.Size(885, 439);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Tasks";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // npTasksGroupBox
            // 
            this.npTasksGroupBox.Controls.Add(this.groupBox2);
            this.npTasksGroupBox.Controls.Add(this.groupBox1);
            this.npTasksGroupBox.Controls.Add(this.lblEndDate);
            this.npTasksGroupBox.Controls.Add(this.lblCustomer);
            this.npTasksGroupBox.Controls.Add(this.lblStartDate);
            this.npTasksGroupBox.Controls.Add(this.label4);
            this.npTasksGroupBox.Controls.Add(this.label3);
            this.npTasksGroupBox.Controls.Add(this.label1);
            this.npTasksGroupBox.Controls.Add(this.cbProjects);
            this.npTasksGroupBox.Controls.Add(this.tasksLbl1);
            this.npTasksGroupBox.Location = new System.Drawing.Point(20, 31);
            this.npTasksGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.npTasksGroupBox.Name = "npTasksGroupBox";
            this.npTasksGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.npTasksGroupBox.Size = new System.Drawing.Size(835, 374);
            this.npTasksGroupBox.TabIndex = 0;
            this.npTasksGroupBox.TabStop = false;
            this.npTasksGroupBox.Text = "Existing Projects";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbTasks);
            this.groupBox2.Location = new System.Drawing.Point(448, 133);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(336, 215);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tasks";
            // 
            // lbTasks
            // 
            this.lbTasks.FormattingEnabled = true;
            this.lbTasks.ItemHeight = 16;
            this.lbTasks.Location = new System.Drawing.Point(8, 23);
            this.lbTasks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbTasks.Name = "lbTasks";
            this.lbTasks.Size = new System.Drawing.Size(319, 180);
            this.lbTasks.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddTask);
            this.groupBox1.Controls.Add(this.cbTeams);
            this.groupBox1.Controls.Add(this.txtTaskEnd);
            this.groupBox1.Controls.Add(this.txtTaskStart);
            this.groupBox1.Controls.Add(this.txtTaskName);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(31, 133);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(367, 215);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Task";
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(131, 176);
            this.btnAddTask.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(100, 28);
            this.btnAddTask.TabIndex = 8;
            this.btnAddTask.Text = "Add";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // cbTeams
            // 
            this.cbTeams.FormattingEnabled = true;
            this.cbTeams.Location = new System.Drawing.Point(131, 130);
            this.cbTeams.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTeams.Name = "cbTeams";
            this.cbTeams.Size = new System.Drawing.Size(160, 24);
            this.cbTeams.TabIndex = 7;
            // 
            // txtTaskEnd
            // 
            this.txtTaskEnd.Location = new System.Drawing.Point(131, 98);
            this.txtTaskEnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTaskEnd.Name = "txtTaskEnd";
            this.txtTaskEnd.Size = new System.Drawing.Size(132, 22);
            this.txtTaskEnd.TabIndex = 6;
            // 
            // txtTaskStart
            // 
            this.txtTaskStart.Location = new System.Drawing.Point(131, 66);
            this.txtTaskStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTaskStart.Name = "txtTaskStart";
            this.txtTaskStart.Size = new System.Drawing.Size(132, 22);
            this.txtTaskStart.TabIndex = 5;
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(131, 34);
            this.txtTaskName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(132, 22);
            this.txtTaskName.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(65, 134);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "Team:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 102);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Expected End:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 70);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Expected Start:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 38);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Name:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(729, 50);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(87, 17);
            this.lblEndDate.TabIndex = 7;
            this.lblEndDate.Text = "lblEndDate";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(477, 87);
            this.lblCustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(93, 17);
            this.lblCustomer.TabIndex = 6;
            this.lblCustomer.Text = "lblCustomer";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(477, 50);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(94, 17);
            this.lblStartDate.TabIndex = 5;
            this.lblStartDate.Text = "lblStartDate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(619, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Expected End:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Customer:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Expected Start:";
            // 
            // cbProjects
            // 
            this.cbProjects.FormattingEnabled = true;
            this.cbProjects.Location = new System.Drawing.Point(156, 41);
            this.cbProjects.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbProjects.Name = "cbProjects";
            this.cbProjects.Size = new System.Drawing.Size(160, 24);
            this.cbProjects.TabIndex = 1;
            this.cbProjects.SelectedIndexChanged += new System.EventHandler(this.cbProjects_SelectedIndexChanged);
            // 
            // tasksLbl1
            // 
            this.tasksLbl1.AutoSize = true;
            this.tasksLbl1.Location = new System.Drawing.Point(55, 44);
            this.tasksLbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tasksLbl1.Name = "tasksLbl1";
            this.tasksLbl1.Size = new System.Drawing.Size(95, 17);
            this.tasksLbl1.TabIndex = 0;
            this.tasksLbl1.Text = "SelectProject:";
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 525);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAdmin";
            this.Text = "Administrator Tool";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.newProjectGroupBox.ResumeLayout(false);
            this.newProjectGroupBox.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.npTasksGroupBox.ResumeLayout(false);
            this.npTasksGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox newProjectGroupBox;
        private System.Windows.Forms.Button btnAddProject;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.TextBox txtProjectEnd;
        private System.Windows.Forms.TextBox txtProjectStart;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Label npLbl4;
        private System.Windows.Forms.Label npLbl3;
        private System.Windows.Forms.Label npLbl2;
        private System.Windows.Forms.Label npLbl1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox npTasksGroupBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbTasks;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.ComboBox cbTeams;
        private System.Windows.Forms.TextBox txtTaskEnd;
        private System.Windows.Forms.TextBox txtTaskStart;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbProjects;
        private System.Windows.Forms.Label tasksLbl1;
    }
}

