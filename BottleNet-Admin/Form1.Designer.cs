namespace BottleNet_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PanelHeader = new Guna.UI.WinForms.GunaPanel();
            this.btn_acc = new Guna.UI2.WinForms.Guna2Button();
            this.btn_analytics = new Guna.UI2.WinForms.Guna2Button();
            this.btn_dash = new Guna.UI2.WinForms.Guna2Button();
            this.MainPanel = new Guna.UI.WinForms.GunaLinePanel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btn_close = new Guna.UI2.WinForms.Guna2Button();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.White;
            this.PanelHeader.Controls.Add(this.gunaLabel1);
            this.PanelHeader.Controls.Add(this.guna2CirclePictureBox1);
            this.PanelHeader.Controls.Add(this.btn_acc);
            this.PanelHeader.Controls.Add(this.btn_analytics);
            this.PanelHeader.Controls.Add(this.btn_close);
            this.PanelHeader.Controls.Add(this.btn_dash);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(1920, 94);
            this.PanelHeader.TabIndex = 0;
            this.PanelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelHeader_Paint);
            // 
            // btn_acc
            // 
            this.btn_acc.Animated = true;
            this.btn_acc.AutoRoundedCorners = true;
            this.btn_acc.BorderRadius = 32;
            this.btn_acc.CheckedState.Parent = this.btn_acc;
            this.btn_acc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_acc.CustomImages.Parent = this.btn_acc;
            this.btn_acc.FillColor = System.Drawing.Color.White;
            this.btn_acc.Font = new System.Drawing.Font("SF Pro Display", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_acc.ForeColor = System.Drawing.Color.Black;
            this.btn_acc.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_acc.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(86)))));
            this.btn_acc.HoverState.Parent = this.btn_acc;
            this.btn_acc.Location = new System.Drawing.Point(1105, 13);
            this.btn_acc.Name = "btn_acc";
            this.btn_acc.PressedColor = System.Drawing.Color.Transparent;
            this.btn_acc.PressedDepth = 0;
            this.btn_acc.ShadowDecoration.Parent = this.btn_acc;
            this.btn_acc.Size = new System.Drawing.Size(180, 66);
            this.btn_acc.TabIndex = 6;
            this.btn_acc.Text = "Account";
            this.btn_acc.Click += new System.EventHandler(this.btn_acc_Click);
            // 
            // btn_analytics
            // 
            this.btn_analytics.Animated = true;
            this.btn_analytics.AutoRoundedCorners = true;
            this.btn_analytics.BorderRadius = 32;
            this.btn_analytics.CheckedState.Parent = this.btn_analytics;
            this.btn_analytics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_analytics.CustomImages.Parent = this.btn_analytics;
            this.btn_analytics.FillColor = System.Drawing.Color.White;
            this.btn_analytics.Font = new System.Drawing.Font("SF Pro Display", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_analytics.ForeColor = System.Drawing.Color.Black;
            this.btn_analytics.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_analytics.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(86)))));
            this.btn_analytics.HoverState.Parent = this.btn_analytics;
            this.btn_analytics.Location = new System.Drawing.Point(868, 13);
            this.btn_analytics.Name = "btn_analytics";
            this.btn_analytics.PressedColor = System.Drawing.Color.Transparent;
            this.btn_analytics.PressedDepth = 0;
            this.btn_analytics.ShadowDecoration.Parent = this.btn_analytics;
            this.btn_analytics.Size = new System.Drawing.Size(180, 66);
            this.btn_analytics.TabIndex = 5;
            this.btn_analytics.Text = "Analytics";
            this.btn_analytics.Click += new System.EventHandler(this.btn_analytics_Click_1);
            // 
            // btn_dash
            // 
            this.btn_dash.Animated = true;
            this.btn_dash.AutoRoundedCorners = true;
            this.btn_dash.BorderRadius = 32;
            this.btn_dash.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btn_dash.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(86)))));
            this.btn_dash.CheckedState.Parent = this.btn_dash;
            this.btn_dash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dash.CustomImages.Parent = this.btn_dash;
            this.btn_dash.FillColor = System.Drawing.Color.White;
            this.btn_dash.Font = new System.Drawing.Font("SF Pro Display", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dash.ForeColor = System.Drawing.Color.Black;
            this.btn_dash.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_dash.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btn_dash.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_dash.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(86)))));
            this.btn_dash.HoverState.Parent = this.btn_dash;
            this.btn_dash.Location = new System.Drawing.Point(631, 13);
            this.btn_dash.Name = "btn_dash";
            this.btn_dash.PressedColor = System.Drawing.Color.Transparent;
            this.btn_dash.PressedDepth = 0;
            this.btn_dash.ShadowDecoration.BorderRadius = 0;
            this.btn_dash.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.btn_dash.ShadowDecoration.Depth = 0;
            this.btn_dash.ShadowDecoration.Parent = this.btn_dash;
            this.btn_dash.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0);
            this.btn_dash.Size = new System.Drawing.Size(180, 66);
            this.btn_dash.TabIndex = 4;
            this.btn_dash.Text = "Dashboard";
            this.btn_dash.Click += new System.EventHandler(this.btn_dash_Click_1);
            // 
            // MainPanel
            // 
            this.MainPanel.AutoSize = true;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.LineColor = System.Drawing.Color.Black;
            this.MainPanel.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.MainPanel.Location = new System.Drawing.Point(0, 94);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1920, 986);
            this.MainPanel.TabIndex = 1;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(89, 0);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(99, 94);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 7;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("SF Pro Display", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(194, 24);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(175, 44);
            this.gunaLabel1.TabIndex = 8;
            this.gunaLabel1.Text = "Bottlenet";
            // 
            // btn_close
            // 
            this.btn_close.Animated = true;
            this.btn_close.CheckedState.Parent = this.btn_close;
            this.btn_close.CustomImages.Parent = this.btn_close;
            this.btn_close.FillColor = System.Drawing.Color.White;
            this.btn_close.Font = new System.Drawing.Font("SF Pro Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.Black;
            this.btn_close.HoverState.Parent = this.btn_close;
            this.btn_close.Location = new System.Drawing.Point(1797, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.PressedColor = System.Drawing.Color.Transparent;
            this.btn_close.ShadowDecoration.Parent = this.btn_close;
            this.btn_close.Size = new System.Drawing.Size(86, 67);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "X";
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.PanelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel PanelHeader;
        private Guna.UI.WinForms.GunaLinePanel MainPanel;
        private Guna.UI2.WinForms.Guna2Button btn_dash;
        private Guna.UI2.WinForms.Guna2Button btn_acc;
        private Guna.UI2.WinForms.Guna2Button btn_analytics;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2Button btn_close;
    }
}

