﻿namespace Basic_GUI_1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.buttonNE = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonE = new System.Windows.Forms.Button();
            this.buttonSE = new System.Windows.Forms.Button();
            this.buttonSW = new System.Windows.Forms.Button();
            this.buttonW = new System.Windows.Forms.Button();
            this.buttonNW = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.notifyIcon1.BalloonTipText = "run";
            this.notifyIcon1.BalloonTipTitle = "Your computer has a virus";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Visible = true;
            // 
            // buttonNE
            // 
            this.buttonNE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNE.BackColor = System.Drawing.Color.Transparent;
            this.buttonNE.FlatAppearance.BorderSize = 0;
            this.buttonNE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNE.Location = new System.Drawing.Point(239, -1);
            this.buttonNE.Name = "buttonNE";
            this.buttonNE.Size = new System.Drawing.Size(220, 250);
            this.buttonNE.TabIndex = 3;
            this.buttonNE.Text = "North East";
            this.buttonNE.UseVisualStyleBackColor = false;
            this.buttonNE.Click += new System.EventHandler(this.buttonNE_Click);
            // 
            // buttonE
            // 
            this.buttonE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonE.BackColor = System.Drawing.Color.Transparent;
            this.buttonE.FlatAppearance.BorderSize = 0;
            this.buttonE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonE.Location = new System.Drawing.Point(239, 124);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(220, 250);
            this.buttonE.TabIndex = 2;
            this.buttonE.Text = "East";
            this.buttonE.UseVisualStyleBackColor = false;
            this.buttonE.Click += new System.EventHandler(this.buttonE_Click);
            // 
            // buttonSE
            // 
            this.buttonSE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSE.BackColor = System.Drawing.Color.Transparent;
            this.buttonSE.FlatAppearance.BorderSize = 0;
            this.buttonSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSE.Location = new System.Drawing.Point(239, 249);
            this.buttonSE.Name = "buttonSE";
            this.buttonSE.Size = new System.Drawing.Size(220, 250);
            this.buttonSE.TabIndex = 3;
            this.buttonSE.Text = "South East";
            this.buttonSE.UseVisualStyleBackColor = false;
            this.buttonSE.Click += new System.EventHandler(this.buttonSE_Click);
            // 
            // buttonSW
            // 
            this.buttonSW.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSW.BackColor = System.Drawing.Color.Transparent;
            this.buttonSW.FlatAppearance.BorderSize = 0;
            this.buttonSW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSW.Location = new System.Drawing.Point(19, 249);
            this.buttonSW.Name = "buttonSW";
            this.buttonSW.Size = new System.Drawing.Size(220, 250);
            this.buttonSW.TabIndex = 5;
            this.buttonSW.Text = "South West";
            this.buttonSW.UseVisualStyleBackColor = false;
            this.buttonSW.Click += new System.EventHandler(this.buttonSW_Click);
            // 
            // buttonW
            // 
            this.buttonW.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonW.BackColor = System.Drawing.Color.Transparent;
            this.buttonW.FlatAppearance.BorderSize = 0;
            this.buttonW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonW.Location = new System.Drawing.Point(19, 124);
            this.buttonW.Name = "buttonW";
            this.buttonW.Size = new System.Drawing.Size(220, 250);
            this.buttonW.TabIndex = 4;
            this.buttonW.Text = "West";
            this.buttonW.UseVisualStyleBackColor = false;
            this.buttonW.Click += new System.EventHandler(this.buttonW_Click);
            // 
            // buttonNW
            // 
            this.buttonNW.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNW.BackColor = System.Drawing.Color.Transparent;
            this.buttonNW.FlatAppearance.BorderSize = 0;
            this.buttonNW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNW.Location = new System.Drawing.Point(19, -1);
            this.buttonNW.Name = "buttonNW";
            this.buttonNW.Size = new System.Drawing.Size(220, 250);
            this.buttonNW.TabIndex = 1;
            this.buttonNW.Text = "North West";
            this.buttonNW.UseVisualStyleBackColor = false;
            this.buttonNW.Click += new System.EventHandler(this.buttonNW_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonSW);
            this.panel1.Controls.Add(this.buttonNW);
            this.panel1.Controls.Add(this.buttonW);
            this.panel1.Controls.Add(this.buttonNE);
            this.panel1.Controls.Add(this.buttonE);
            this.panel1.Controls.Add(this.buttonSE);
            this.panel1.Location = new System.Drawing.Point(230, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 500);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI";
            this.ResizeBegin += new System.EventHandler(this.Form1_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button buttonNE;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonE;
        private System.Windows.Forms.Button buttonSE;
        private System.Windows.Forms.Button buttonSW;
        private System.Windows.Forms.Button buttonW;
        private System.Windows.Forms.Button buttonNW;
        private System.Windows.Forms.Panel panel1;
    }
}

