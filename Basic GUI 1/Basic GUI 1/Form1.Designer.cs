namespace Basic_GUI_1
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
            this.buttonNE.BackColor = System.Drawing.Color.Transparent;
            this.buttonNE.FlatAppearance.BorderSize = 0;
            this.buttonNE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNE.Location = new System.Drawing.Point(470, 0);
            this.buttonNE.Name = "buttonNE";
            this.buttonNE.Size = new System.Drawing.Size(220, 250);
            this.buttonNE.TabIndex = 0;
            this.buttonNE.Text = "North East";
            this.buttonNE.UseVisualStyleBackColor = false;
            // 
            // buttonE
            // 
            this.buttonE.BackColor = System.Drawing.Color.Transparent;
            this.buttonE.FlatAppearance.BorderSize = 0;
            this.buttonE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonE.Location = new System.Drawing.Point(470, 125);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(220, 250);
            this.buttonE.TabIndex = 1;
            this.buttonE.Text = "East";
            this.buttonE.UseVisualStyleBackColor = false;
            // 
            // buttonSE
            // 
            this.buttonSE.BackColor = System.Drawing.Color.Transparent;
            this.buttonSE.FlatAppearance.BorderSize = 0;
            this.buttonSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSE.Location = new System.Drawing.Point(470, 250);
            this.buttonSE.Name = "buttonSE";
            this.buttonSE.Size = new System.Drawing.Size(220, 250);
            this.buttonSE.TabIndex = 2;
            this.buttonSE.Text = "South East";
            this.buttonSE.UseVisualStyleBackColor = false;
            // 
            // buttonSW
            // 
            this.buttonSW.BackColor = System.Drawing.Color.Transparent;
            this.buttonSW.FlatAppearance.BorderSize = 0;
            this.buttonSW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSW.Location = new System.Drawing.Point(250, 250);
            this.buttonSW.Name = "buttonSW";
            this.buttonSW.Size = new System.Drawing.Size(220, 250);
            this.buttonSW.TabIndex = 5;
            this.buttonSW.Text = "South West";
            this.buttonSW.UseVisualStyleBackColor = false;
            // 
            // buttonW
            // 
            this.buttonW.BackColor = System.Drawing.Color.Transparent;
            this.buttonW.FlatAppearance.BorderSize = 0;
            this.buttonW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonW.Location = new System.Drawing.Point(250, 125);
            this.buttonW.Name = "buttonW";
            this.buttonW.Size = new System.Drawing.Size(220, 250);
            this.buttonW.TabIndex = 4;
            this.buttonW.Text = "West";
            this.buttonW.UseVisualStyleBackColor = false;
            // 
            // buttonNW
            // 
            this.buttonNW.BackColor = System.Drawing.Color.Transparent;
            this.buttonNW.FlatAppearance.BorderSize = 0;
            this.buttonNW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNW.Location = new System.Drawing.Point(250, 0);
            this.buttonNW.Name = "buttonNW";
            this.buttonNW.Size = new System.Drawing.Size(220, 250);
            this.buttonNW.TabIndex = 3;
            this.buttonNW.Text = "North West";
            this.buttonNW.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.buttonSW);
            this.Controls.Add(this.buttonW);
            this.Controls.Add(this.buttonNW);
            this.Controls.Add(this.buttonSE);
            this.Controls.Add(this.buttonE);
            this.Controls.Add(this.buttonNE);
            this.Name = "Form1";
            this.Text = "GUI";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
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
    }
}

