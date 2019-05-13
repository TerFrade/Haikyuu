namespace Haikyuu
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.TopNavPanel = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.LeftNavPanel = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlDisplay = new System.Windows.Forms.Panel();
            this.TopNavPanel.SuspendLayout();
            this.LeftNavPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopNavPanel
            // 
            this.TopNavPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(115)))), ((int)(((byte)(4)))));
            this.TopNavPanel.Controls.Add(this.btnMinimize);
            this.TopNavPanel.Controls.Add(this.btnClose);
            this.TopNavPanel.Controls.Add(this.lblHeader);
            this.TopNavPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopNavPanel.Location = new System.Drawing.Point(0, 0);
            this.TopNavPanel.Name = "TopNavPanel";
            this.TopNavPanel.Size = new System.Drawing.Size(921, 30);
            this.TopNavPanel.TabIndex = 0;
            this.TopNavPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopNavPanel_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.Location = new System.Drawing.Point(864, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(24, 24);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.Text = "-\r\n";
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(894, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 24);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "X";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblHeader.Location = new System.Drawing.Point(25, 5);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(122, 20);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "Welcome - User";
            this.lblHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblHeader_MouseDown);
            // 
            // LeftNavPanel
            // 
            this.LeftNavPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(67)))), ((int)(((byte)(82)))));
            this.LeftNavPanel.Controls.Add(this.btnHome);
            this.LeftNavPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftNavPanel.Location = new System.Drawing.Point(0, 30);
            this.LeftNavPanel.Name = "LeftNavPanel";
            this.LeftNavPanel.Size = new System.Drawing.Size(170, 506);
            this.LeftNavPanel.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(159)))), ((int)(((byte)(4)))));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(4)))));
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(115)))), ((int)(((byte)(4)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHome.Location = new System.Drawing.Point(0, 62);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(170, 52);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "HOME";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDisplay.Location = new System.Drawing.Point(170, 30);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.Size = new System.Drawing.Size(751, 506);
            this.pnlDisplay.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(921, 536);
            this.Controls.Add(this.pnlDisplay);
            this.Controls.Add(this.LeftNavPanel);
            this.Controls.Add(this.TopNavPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopNavPanel.ResumeLayout(false);
            this.TopNavPanel.PerformLayout();
            this.LeftNavPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopNavPanel;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel LeftNavPanel;
        private System.Windows.Forms.Panel pnlDisplay;
        private System.Windows.Forms.Button btnHome;
    }
}

