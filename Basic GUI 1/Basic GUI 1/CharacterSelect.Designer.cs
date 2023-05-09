namespace Basic_GUI_1
{
    partial class CharacterSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterSelect));
            this.pictureBoxPlain = new System.Windows.Forms.PictureBox();
            this.pictureBoxBow = new System.Windows.Forms.PictureBox();
            this.pictureBoxBen = new System.Windows.Forms.PictureBox();
            this.pictureBoxRedshirt = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRedshirt)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPlain
            // 
            this.pictureBoxPlain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxPlain.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPlain.Image = global::Basic_GUI_1.Properties.Resources.PlainFront;
            this.pictureBoxPlain.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxPlain.InitialImage")));
            this.pictureBoxPlain.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxPlain.Name = "pictureBoxPlain";
            this.pictureBoxPlain.Size = new System.Drawing.Size(100, 200);
            this.pictureBoxPlain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPlain.TabIndex = 7;
            this.pictureBoxPlain.TabStop = false;
            this.pictureBoxPlain.Click += new System.EventHandler(this.pictureBoxPlain_Click);
            // 
            // pictureBoxBow
            // 
            this.pictureBoxBow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxBow.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBow.Image = global::Basic_GUI_1.Properties.Resources.BowFront;
            this.pictureBoxBow.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxBow.InitialImage")));
            this.pictureBoxBow.Location = new System.Drawing.Point(118, 12);
            this.pictureBoxBow.Name = "pictureBoxBow";
            this.pictureBoxBow.Size = new System.Drawing.Size(100, 200);
            this.pictureBoxBow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBow.TabIndex = 8;
            this.pictureBoxBow.TabStop = false;
            this.pictureBoxBow.Click += new System.EventHandler(this.pictureBoxBow_Click);
            // 
            // pictureBoxBen
            // 
            this.pictureBoxBen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxBen.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBen.Image = global::Basic_GUI_1.Properties.Resources.BenFront;
            this.pictureBoxBen.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxBen.InitialImage")));
            this.pictureBoxBen.Location = new System.Drawing.Point(224, 12);
            this.pictureBoxBen.Name = "pictureBoxBen";
            this.pictureBoxBen.Size = new System.Drawing.Size(100, 200);
            this.pictureBoxBen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBen.TabIndex = 9;
            this.pictureBoxBen.TabStop = false;
            this.pictureBoxBen.Click += new System.EventHandler(this.pictureBoxBen_Click);
            // 
            // pictureBoxRedshirt
            // 
            this.pictureBoxRedshirt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxRedshirt.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxRedshirt.Image = global::Basic_GUI_1.Properties.Resources.RedshirtFront;
            this.pictureBoxRedshirt.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxRedshirt.InitialImage")));
            this.pictureBoxRedshirt.Location = new System.Drawing.Point(330, 12);
            this.pictureBoxRedshirt.Name = "pictureBoxRedshirt";
            this.pictureBoxRedshirt.Size = new System.Drawing.Size(100, 200);
            this.pictureBoxRedshirt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRedshirt.TabIndex = 10;
            this.pictureBoxRedshirt.TabStop = false;
            this.pictureBoxRedshirt.Click += new System.EventHandler(this.pictureBoxRedshirt_Click);
            // 
            // CharacterSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(436, 223);
            this.Controls.Add(this.pictureBoxRedshirt);
            this.Controls.Add(this.pictureBoxBen);
            this.Controls.Add(this.pictureBoxBow);
            this.Controls.Add(this.pictureBoxPlain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CharacterSelect";
            this.Text = "Select your character:";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRedshirt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPlain;
        private System.Windows.Forms.PictureBox pictureBoxBow;
        private System.Windows.Forms.PictureBox pictureBoxBen;
        private System.Windows.Forms.PictureBox pictureBoxRedshirt;
    }
}