﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PTSLibrary;

namespace AdminApplication
{
    public partial class frmAdmin : Form
    {
        private PTSAdminFacade facade;
        private int adminId;
        private Customer[] customers;
        private Project[] projects;
        private Team[] teams;
        private Project selectedProject;
        private Task[] tasks;

        public frmAdmin()
        {
            InitializeComponent();
            facade = new PTSAdminFacade();
            adminId = 0;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                adminId = facade.Authenticate(this.txtUsername.Text, this.txtPassword.Text);
                if (adminId != 0)
                {
                    this.txtUsername.Text = "";
                    this.txtPassword.Text = "";
                    MessageBox.Show("Successfully logged in");
                    tabControl1.SelectTab(1);
                    tabControl1.Enabled = true;
                }
                else
                {
                    tabControl1.SelectTab(0);
                    tabControl1.Enabled = false;
                    MessageBox.Show("Wrong login details");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                customers = facade.GetListOfCustomers();
                cbCustomer.DataSource = customers;
                cbCustomer.DisplayMember = "Name";
                cbCustomer.ValueMember = "id";
            }
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            DateTime startDate, endDate;
            if (txtProjectName.Text == "")
            {
                MessageBox.Show("You need to fill in the name field");
                return;
            }

            try
            {
                startDate = DateTime.Parse(txtProjectStart.Text);
                endDate = DateTime.Parse(txtProjectEnd.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("The date(s) are in the wrong format");
                return;
            }
            facade.CreateProject(txtProjectName.Text, startDate, endDate, (int)cbCustomer.SelectedValue, adminId);
            txtProjectName.Text = "";
            txtProjectStart.Text = "";
            txtProjectEnd.Text = "";
            cbCustomer.SelectedIndex = 0;
            MessageBox.Show("Project successfully created");
            tabControl2.SelectTab(1);
        }

        private void tabControl2_Selected(object sender, TabControlEventArgs e)
        {
            projects = facade.GetListOfProjects(adminId);
            cbProjects.DataSource = projects;
            cbProjects.DisplayMember = "Name";
            cbProjects.ValueMember = "ProjectId";
            if (projects.Length != 0)
            {
                setProjectDetails();
            }
            else
            {
                MessageBox.Show("No Projects Exist\nCreate a new project to proceed");
            }
            teams = facade.GetListOfTeams();
            cbTeams.DataSource = teams;
            cbTeams.DisplayMember = "NameAndStatus";
            cbTeams.ValueMember = "TeamId";
        }

        private void setProjectDetails()
        {
            selectedProject = projects[cbProjects.SelectedIndex];
            lblStartDate.Text = selectedProject.ExpectedStartDate.ToShortDateString();
            lblEndDate.Text = selectedProject.ExpectedEndDate.ToShortDateString();
            lblCustomer.Text = ((Customer)selectedProject.TheCustomer).Name;
            UpdateTasks();
        }

        private void UpdateTasks()
        {
            tasks = facade.GetListOfTasks(selectedProject.ProjectId);
            lbTasks.DataSource = tasks;
            lbTasks.DisplayMember = "NameAndStatus";
            lbTasks.ValueMember = "TaskId";
        }

        private void cbProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            setProjectDetails();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            DateTime startDate, endDate;
            if (txtTaskName.Text == "")
            {
                MessageBox.Show("You need to fill in the name field");
                return;
            }
            try
            {
                startDate = DateTime.Parse(txtTaskStart.Text);
                endDate = DateTime.Parse(txtTaskEnd.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("The date(s) are in the wrong format");
                return;
            }
            facade.CreateTask(txtTaskName.Text, startDate, endDate, (int)cbTeams.SelectedValue, selectedProject.ProjectId);
            txtTaskName.Text = "";
            txtTaskStart.Text = "";
            txtTaskEnd.Text = "";
            cbTeams.SelectedIndex = 0;
            MessageBox.Show("Task successfully created");
            UpdateTasks();
        }
    }
}
