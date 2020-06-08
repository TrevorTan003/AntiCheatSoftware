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
        private ToolStripMenuItem listToolStrip;
        private ToolStripMenuItem helpToolStrip;
        public TextBox txtInput;


        public AntiCheat()
        {
            InitializeComponent();

        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnScan = new System.Windows.Forms.Button();
            this.lblHead = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.chkStealth = new System.Windows.Forms.CheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.listToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(355, 152);
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
            this.lblHead.Location = new System.Drawing.Point(161, 100);
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
            this.lblStatus.Location = new System.Drawing.Point(232, 100);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(140, 24);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Ready To Scan";
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.HotPink;
            this.progressBar1.Location = new System.Drawing.Point(96, 181);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(334, 23);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Anti Cheat Software";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(96, 154);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(253, 20);
            this.txtInput.TabIndex = 5;
            // 
            // chkStealth
            // 
            this.chkStealth.AutoSize = true;
            this.chkStealth.Location = new System.Drawing.Point(341, 215);
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
            this.listToolStrip,
            this.helpToolStrip,
            this.exitToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(558, 24);
            this.menuStrip.TabIndex = 8;
            this.menuStrip.Text = "menuStrip1";
            // 
            // listToolStrip
            // 
            this.listToolStrip.Name = "listToolStrip";
            this.listToolStrip.Size = new System.Drawing.Size(37, 20);
            this.listToolStrip.Text = "List";
            this.listToolStrip.Click += new System.EventHandler(this.listToolStripMenuItem_Click_1);
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
            // AntiCheat
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(558, 299);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            //Clicked button
            lblStatus.Text = "Scanning";
            lblStatus.ForeColor = System.Drawing.Color.Red;
            progressBar1.Value = 100;

            //Detects the input in the textbox, the "process" will be declared as an array
            Process.GetProcessesByName(txtInput.Text);
            Process[] findProcess = Process.GetProcessesByName(txtInput.Text);

            //Logical statements
            if (findProcess.Length == 0)
            {
                MessageBox.Show("Process Not Found");
            }

            else
            {
                lblStatus.Text = "Scanning";
                lblStatus.ForeColor = System.Drawing.Color.Red;
                DialogResult killProcess = MessageBox.Show("Process Found\nWould you like to terminate the process: "+txtInput.Text+"?","Confirm"
                    ,MessageBoxButtons.YesNo,MessageBoxIcon.Error);

                if (killProcess == DialogResult.Yes)
                {
                    foreach (var p in Process.GetProcessesByName(txtInput.Text))
                    {
                        p.Kill();
                    }
                }
            }

            lblStatus.Text = "Ready To Scan";
            lblStatus.ForeColor = System.Drawing.Color.Green;
            txtInput.Text = "";
            progressBar1.Value = 0;
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
            toolTip.SetToolTip(this.chkStealth, "Enabling will make the Anti Cheat run in the background");
        }

        //Toggle on/off "Stealth Mode"
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool detected = false;

            if (chkStealth.Checked)
            {
                while (detected == false && txtInput.Text != "")
                {
                    /*Once the checkbox is ticked and conditions for while loop is satisfied the program will go into "stealth mode".
                     It will run in the background and will continuously look for the specified process and until it is found, it will
                     continue running*/
                    Process.GetProcessesByName(txtInput.Text);
                    Process[] findProcess = Process.GetProcessesByName(txtInput.Text);
                    this.Hide();
                    this.ShowInTaskbar = false;

                    if (findProcess.Length != 0)
                    {
                        detected = true;
                        DialogResult r = MessageBox.Show("Process has been found and will now close", "Anti Cheat", MessageBoxButtons.OK);

                        if (r == System.Windows.Forms.DialogResult.OK)
                        {
                            foreach (var p in Process.GetProcessesByName(txtInput.Text))
                            {
                                //When it's found, it will kill the process and unveil the form.
                                p.Kill();
                                this.Show();
                                this.ShowInTaskbar = true;
                                chkStealth.Checked = false;
                            }

                        }
                    }
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public static int toggleList = 0;
        private void listToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            /*To prevent having multiple of the same forms, I made a public int 'toggleList' & 'toggleHelp', upon clicking opening the new form
             it will increase the toggle int by 1 so it does not satisfy the if statement hence preventing multiple forms opening. When the form
             is closed, it will make the toggle int back to 0 so it can be opened again.*/

            if (toggleList == 0)
            {
                toggleList += 1;
                List list = new List();
                list.Show();
            }
        }

        private void helpToolStrip_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
        }

    }
}