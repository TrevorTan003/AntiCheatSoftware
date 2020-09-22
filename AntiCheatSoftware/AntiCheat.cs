﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;

namespace AntiCheatSoftware
{
    public partial class AntiCheat : Form
    {
        private Button btnScan;
        private Label lblHead;
        private ProgressBar progressBar1;
        private Label label1;
        private Label lblStatus;
        private CheckBox chkStealth;
        private ToolTip toolTip;
        private IContainer components;
        private MenuStrip menuStrip;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStrip;
        private ToolStripMenuItem timelineToolStripMenuItem;
        private NotifyIcon NotifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem showToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private Timer timer1;
        private ListView listProcess;
        private TextBox txtProcess;
        private Label lblSearch;
        private Label label2;
        private ColumnHeader columnHeader1;
        private Button btnRefresh;
        public TextBox txtInput;


        public AntiCheat()
        {
            InitializeComponent();
            loadProcessList();
        }

        //All this is automatically generated, it is the code for the Design
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AntiCheat));
            this.btnScan = new System.Windows.Forms.Button();
            this.lblHead = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.chkStealth = new System.Windows.Forms.CheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.timelineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NotifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listProcess = new System.Windows.Forms.ListView();
            this.txtProcess = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(317, 114);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(75, 23);
            this.btnScan.TabIndex = 0;
            this.btnScan.Text = "Terminate";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead.Location = new System.Drawing.Point(54, 76);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(65, 24);
            this.lblHead.TabIndex = 1;
            this.lblHead.Text = "Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Green;
            this.lblStatus.Location = new System.Drawing.Point(125, 76);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(140, 24);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Ready To Scan";
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.HotPink;
            this.progressBar1.Location = new System.Drawing.Point(58, 140);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(334, 23);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Anti Cheat Software";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(58, 114);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(253, 20);
            this.txtInput.TabIndex = 5;
            // 
            // chkStealth
            // 
            this.chkStealth.AutoSize = true;
            this.chkStealth.Location = new System.Drawing.Point(303, 169);
            this.chkStealth.Name = "chkStealth";
            this.chkStealth.Size = new System.Drawing.Size(89, 17);
            this.chkStealth.TabIndex = 7;
            this.chkStealth.Text = "Stealth Mode";
            this.chkStealth.UseVisualStyleBackColor = true;
            this.chkStealth.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.chkStealth.MouseHover += new System.EventHandler(this.checkBox1_MouseHover);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timelineToolStripMenuItem,
            this.helpToolStrip,
            this.exitToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(454, 24);
            this.menuStrip.TabIndex = 8;
            this.menuStrip.Text = "menuStrip1";
            // 
            // timelineToolStripMenuItem
            // 
            this.timelineToolStripMenuItem.Name = "timelineToolStripMenuItem";
            this.timelineToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.timelineToolStripMenuItem.Text = "Timeline";
            this.timelineToolStripMenuItem.Click += new System.EventHandler(this.timelineToolStripMenuItem_Click);
            // 
            // helpToolStrip
            // 
            this.helpToolStrip.Name = "helpToolStrip";
            this.helpToolStrip.Size = new System.Drawing.Size(44, 20);
            this.helpToolStrip.Text = "Help";
            this.helpToolStrip.Click += new System.EventHandler(this.helpToolStrip_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // NotifyIcon1
            // 
            this.NotifyIcon1.BalloonTipText = "The software will now run until you stop it or until the specified process is fou" +
    "nd";
            this.NotifyIcon1.BalloonTipTitle = "Automatic Mode";
            this.NotifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.NotifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon1.Icon")));
            this.NotifyIcon1.Text = "Anti Cheat Software";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 48);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listProcess
            // 
            this.listProcess.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listProcess.GridLines = true;
            this.listProcess.HideSelection = false;
            this.listProcess.Location = new System.Drawing.Point(55, 221);
            this.listProcess.Name = "listProcess";
            this.listProcess.Size = new System.Drawing.Size(334, 366);
            this.listProcess.TabIndex = 9;
            this.listProcess.UseCompatibleStateImageBehavior = false;
            this.listProcess.View = System.Windows.Forms.View.Details;
            this.listProcess.SelectedIndexChanged += new System.EventHandler(this.listProcess_SelectedIndexChanged);
            // 
            // txtProcess
            // 
            this.txtProcess.Location = new System.Drawing.Point(140, 600);
            this.txtProcess.Name = "txtProcess";
            this.txtProcess.Size = new System.Drawing.Size(207, 20);
            this.txtProcess.TabIndex = 10;
            this.txtProcess.TextChanged += new System.EventHandler(this.txtProcess_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(52, 603);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(79, 13);
            this.lblSearch.TabIndex = 11;
            this.lblSearch.Text = "Process Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "List of active processes:";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Process Name";
            this.columnHeader1.Width = 330;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::AntiCheatSoftware.Properties.Resources.Refresh;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.Location = new System.Drawing.Point(353, 597);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(25, 25);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // AntiCheat
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(454, 640);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtProcess);
            this.Controls.Add(this.listProcess);
            this.Controls.Add(this.chkStealth);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblHead);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "AntiCheat";
            this.Text = "Anti Cheat Software";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        //Public variables

        public static int toggleList = 0;
        public static int toggleHelp = 0;
        public static int toggleHistory = 0;
        public string selectedItem;
        bool stealth = false;
        string connectionString = @"Data Source = tpisql01.avcol.school.nz; Initial Catalog = ProcessTimeline; Integrated Security = True;";

        //Classes

        //Status Change
        private void StatusScan()
        {
            lblStatus.Text = "Scanning";
            lblStatus.ForeColor = System.Drawing.Color.Red;
            progressBar1.Value = 100;
        }

        private void StatusReady()
        {
            lblStatus.Text = "Ready To Scan";
            lblStatus.ForeColor = System.Drawing.Color.Green;
            progressBar1.Value = 0;
            txtInput.Text = "";
            chkStealth.Checked = false;
        }


        /*These limit classes are here to prevent mutliple copies of the form from being opened
         When clicking the tab on the menustrip, it will +1 to the toggle variable so it cant be opened again until closed (-1 from toggle)*/

        private void LimitHelp()
        {
              if (toggleHelp == 0)
            {
                toggleHelp += 1;
                Help help = new Help();
                help.Show();
            }
        }

        private void LimitHistory()
        {
            if (toggleHistory == 0)
            {
                toggleHistory += 1;
                Timeline timeline = new Timeline();
                timeline.Show();
            }
        }

        private void AddData()
        {
            //Adds the date & time, process name and method of closing into the database(in connectionString)
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                //First we open the connection
                sqlCon.Open();
                //SqlCommand helps us execute commands from here to the database
                SqlCommand sqlCmd = new SqlCommand("Timeline", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@ProcessName", txtInput.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@DateTime", DateTime.Now.ToLocalTime());
                if (stealth == true)
                {
                    sqlCmd.Parameters.AddWithValue("@MethodClose", "Stealth");
                }

                else
                {
                    sqlCmd.Parameters.AddWithValue("@MethodClose", "Manual");
                }
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Added to database");
            }
        }


        //While loop to continiously scan until the specified process is detected and will close it
        /*It will run in the background and will continuously look for the specified process and until it is found, it will
       continue running*/
        private void StealthMode()
        {
            if (chkStealth.Checked == true && txtInput.Text != "")
            {
                this.Hide();
                NotifyIcon1.Visible = true;

                Process.GetProcessesByName(txtInput.Text);
                Process[] findProcess = Process.GetProcessesByName(txtInput.Text);

                if (findProcess.Length != 0)
                {
                    StatusScan();
                    stealth = true;

                    foreach (var p in Process.GetProcessesByName(txtInput.Text))
                    {
                        //When it's found, it will kill the process and unveil the form.
                        p.Kill();
                        chkStealth.Checked = false;
                        AddData();
                        StatusReady();

                        this.Show();
                        NotifyIcon1.Visible = false;
                    }

                }
            }
            
        }

        private void loadProcessList()
        {
            Process[] processes = Process.GetProcesses();
            listProcess.Items.Clear();
            //Checks all the active process names and adds them to the "listProcess" listview
            foreach (Process process in processes)
            {
                ListViewItem item = new ListViewItem(process.ProcessName);
                item.Tag = processes;
                listProcess.Items.Add(item);
            }

        }

        private void searchProcess()
        {
            //See if the text in the textbox matches any of the items in the viewlist
            if (txtProcess.Text != "")
            {
                System.Collections.IList list = listProcess.Items;
                //The viewlist will be filtered through a for loop
                for (int i = 0; i < list.Count; i++)
                {
                    ListViewItem item = (ListViewItem)list[i];
                    if (item.Text.Contains(txtProcess.Text.ToLower()))
                    {

                    }

                    else
                    {
                        listProcess.Items.Remove(item);
                    }
                }
            }

        }
        //
        //Events
        //
        private void btnScan_Click(object sender, EventArgs e)
        {
            //Detects the input in the textbox, the "process"
            Process.GetProcessesByName(txtInput.Text);
            Process[] findProcess = Process.GetProcessesByName(txtInput.Text);
            StatusScan();

            if (findProcess.Length == 0)
            {
                MessageBox.Show("Process Not Found");

            }
            else
            {
                DialogResult killProcess = MessageBox.Show("Process Found\nWould you like to terminate the process: " + txtInput.Text + "?", "Confirm"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (killProcess == DialogResult.Yes)
                {
                    foreach (var p in Process.GetProcessesByName(txtInput.Text))
                    {
                        p.Kill();
                        AddData();
                    }
                }
            }
            txtInput.Text = "";
            StatusReady();

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Ready To Scan";
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;      
        }

        private void checkBox1_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.chkStealth, "Enabling will make the Anti Cheat close the specified process as soon as it opens");
        }

        //Toggle on/off "Automatic" Mode
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStealth.Checked)
            {
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            StealthMode();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpToolStrip_Click(object sender, EventArgs e)
        {
            LimitHelp();
        }

        private void timelineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LimitHistory();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            StatusReady();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listProcess_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Once an item is double clicked, it'll hide the task form the taskbar

            if (listProcess.SelectedItems.Count > 0)
            {
                var item = listProcess.SelectedItems[0];
                selectedItem = item.Text;

                txtInput.Text = selectedItem;

            }
        }

        private void txtProcess_TextChanged(object sender, EventArgs e)
        {
            searchProcess();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadProcessList();
        }
    }
}
