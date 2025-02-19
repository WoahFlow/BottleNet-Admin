namespace BottleNet_Admin
{
    partial class Analytics
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_year = new Guna.UI2.WinForms.Guna2Button();
            this.btn_month = new Guna.UI2.WinForms.Guna2Button();
            this.btn_week = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.analyticPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 5;
            this.guna2Panel1.Controls.Add(this.btn_year);
            this.guna2Panel1.Controls.Add(this.btn_month);
            this.guna2Panel1.Controls.Add(this.btn_week);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(112, 44);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Depth = 20;
            this.guna2Panel1.ShadowDecoration.Enabled = true;
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.guna2Panel1.Size = new System.Drawing.Size(1686, 81);
            this.guna2Panel1.TabIndex = 5;
            // 
            // btn_year
            // 
            this.btn_year.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.btn_year.BorderRadius = 7;
            this.btn_year.BorderThickness = 1;
            this.btn_year.CheckedState.Parent = this.btn_year;
            this.btn_year.CustomBorderThickness = new System.Windows.Forms.Padding(5);
            this.btn_year.CustomImages.Parent = this.btn_year;
            this.btn_year.FillColor = System.Drawing.Color.White;
            this.btn_year.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_year.ForeColor = System.Drawing.Color.Black;
            this.btn_year.HoverState.Parent = this.btn_year;
            this.btn_year.Location = new System.Drawing.Point(1490, 19);
            this.btn_year.Name = "btn_year";
            this.btn_year.ShadowDecoration.Parent = this.btn_year;
            this.btn_year.Size = new System.Drawing.Size(135, 45);
            this.btn_year.TabIndex = 3;
            this.btn_year.Text = "Yearly";
            this.btn_year.Click += new System.EventHandler(this.btn_year_Click);
            // 
            // btn_month
            // 
            this.btn_month.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.btn_month.BorderRadius = 7;
            this.btn_month.BorderThickness = 1;
            this.btn_month.CheckedState.Parent = this.btn_month;
            this.btn_month.CustomBorderThickness = new System.Windows.Forms.Padding(5);
            this.btn_month.CustomImages.Parent = this.btn_month;
            this.btn_month.FillColor = System.Drawing.Color.White;
            this.btn_month.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_month.ForeColor = System.Drawing.Color.Black;
            this.btn_month.HoverState.Parent = this.btn_month;
            this.btn_month.Location = new System.Drawing.Point(1320, 19);
            this.btn_month.Name = "btn_month";
            this.btn_month.ShadowDecoration.Parent = this.btn_month;
            this.btn_month.Size = new System.Drawing.Size(135, 45);
            this.btn_month.TabIndex = 2;
            this.btn_month.Text = "Monthly";
            this.btn_month.Click += new System.EventHandler(this.btn_month_Click);
            // 
            // btn_week
            // 
            this.btn_week.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.btn_week.BorderRadius = 7;
            this.btn_week.BorderThickness = 1;
            this.btn_week.CheckedState.Parent = this.btn_week;
            this.btn_week.CustomBorderThickness = new System.Windows.Forms.Padding(5);
            this.btn_week.CustomImages.Parent = this.btn_week;
            this.btn_week.FillColor = System.Drawing.Color.White;
            this.btn_week.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_week.ForeColor = System.Drawing.Color.Black;
            this.btn_week.HoverState.Parent = this.btn_week;
            this.btn_week.Location = new System.Drawing.Point(1152, 19);
            this.btn_week.Name = "btn_week";
            this.btn_week.ShadowDecoration.Parent = this.btn_week;
            this.btn_week.Size = new System.Drawing.Size(135, 45);
            this.btn_week.TabIndex = 1;
            this.btn_week.Text = "Weekly";
            this.btn_week.Click += new System.EventHandler(this.btn_week_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("SF Pro Display", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(49, 11);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(339, 59);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Analytic Report";
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_SLIDE;
            // 
            // analyticPanel
            // 
            this.analyticPanel.Location = new System.Drawing.Point(112, 175);
            this.analyticPanel.Name = "analyticPanel";
            this.analyticPanel.ShadowDecoration.Parent = this.analyticPanel;
            this.analyticPanel.Size = new System.Drawing.Size(1686, 683);
            this.analyticPanel.TabIndex = 0;
            // 
            // Analytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1919, 996);
            this.Controls.Add(this.analyticPanel);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Analytics";
            this.Text = "Analytics";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btn_year;
        private Guna.UI2.WinForms.Guna2Button btn_month;
        private Guna.UI2.WinForms.Guna2Button btn_week;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Panel analyticPanel;
    }
}