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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlDisplay = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
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
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(159)))), ((int)(((byte)(4)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.Location = new System.Drawing.Point(864, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(24, 24);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.Text = "-\r\n";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(159)))), ((int)(((byte)(4)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(19)))), ((int)(((byte)(4)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(894, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 24);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "X";
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
            this.LeftNavPanel.Controls.Add(this.button6);
            this.LeftNavPanel.Controls.Add(this.button5);
            this.LeftNavPanel.Controls.Add(this.button4);
            this.LeftNavPanel.Controls.Add(this.button3);
            this.LeftNavPanel.Controls.Add(this.button2);
            this.LeftNavPanel.Controls.Add(this.button1);
            this.LeftNavPanel.Controls.Add(this.btnHome);
            this.LeftNavPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftNavPanel.Location = new System.Drawing.Point(0, 30);
            this.LeftNavPanel.Name = "LeftNavPanel";
            this.LeftNavPanel.Size = new System.Drawing.Size(170, 506);
            this.LeftNavPanel.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(159)))), ((int)(((byte)(4)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(4)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(115)))), ((int)(((byte)(4)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(0, 307);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(170, 52);
            this.button4.TabIndex = 7;
            this.button4.Text = "SETTINGS";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(159)))), ((int)(((byte)(4)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(4)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(115)))), ((int)(((byte)(4)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(0, 249);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 52);
            this.button3.TabIndex = 6;
            this.button3.Text = "NOTIFICATIONS";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(159)))), ((int)(((byte)(4)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(4)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(115)))), ((int)(((byte)(4)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(0, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 52);
            this.button2.TabIndex = 5;
            this.button2.Text = "MATCHES";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(159)))), ((int)(((byte)(4)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(4)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(115)))), ((int)(((byte)(4)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(0, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 52);
            this.button1.TabIndex = 4;
            this.button1.Text = "TEAMS";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(159)))), ((int)(((byte)(4)))));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(4)))));
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(115)))), ((int)(((byte)(4)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHome.Location = new System.Drawing.Point(0, 17);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(170, 52);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "HOME";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHome.UseVisualStyleBackColor = false;
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
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(159)))), ((int)(((byte)(4)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(4)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(115)))), ((int)(((byte)(4)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.Location = new System.Drawing.Point(0, 442);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(170, 52);
            this.button5.TabIndex = 8;
            this.button5.Text = "LOGOUT";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(159)))), ((int)(((byte)(4)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(4)))));
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(115)))), ((int)(((byte)(4)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button6.Location = new System.Drawing.Point(0, 75);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(170, 52);
            this.button6.TabIndex = 9;
            this.button6.Text = "PLAYERS";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = false;
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

