namespace Project_SeveN
{
    partial class Loader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loader));
            this.pnlTop = new Guna.UI.WinForms.GunaGradient2Panel();
            this.btnClose = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.btnMInimize = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.drgctrlpaneltop = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.lblName = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlTop.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Transparent;
            this.pnlTop.Controls.Add(this.lblName);
            this.pnlTop.Controls.Add(this.btnMInimize);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.GradientColor1 = System.Drawing.Color.Purple;
            this.pnlTop.GradientColor2 = System.Drawing.Color.Transparent;
            this.pnlTop.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.pnlTop.Location = new System.Drawing.Point(-2, -3);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(722, 40);
            this.pnlTop.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.AnimationHoverSpeed = 0.07F;
            this.btnClose.AnimationSpeed = 0.03F;
            this.btnClose.BaseColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderColor = System.Drawing.Color.Black;
            this.btnClose.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnClose.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnClose.CheckedForeColor = System.Drawing.Color.White;
            this.btnClose.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnClose.CheckedImage")));
            this.btnClose.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.FocusedColor = System.Drawing.Color.Empty;
            this.btnClose.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = null;
            this.btnClose.ImageSize = new System.Drawing.Size(52, 52);
            this.btnClose.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnClose.Location = new System.Drawing.Point(682, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBaseColor = System.Drawing.Color.Red;
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClose.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Size = new System.Drawing.Size(37, 37);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMInimize
            // 
            this.btnMInimize.AnimationHoverSpeed = 0.07F;
            this.btnMInimize.AnimationSpeed = 0.03F;
            this.btnMInimize.BaseColor = System.Drawing.Color.Transparent;
            this.btnMInimize.BorderColor = System.Drawing.Color.Black;
            this.btnMInimize.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnMInimize.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnMInimize.CheckedForeColor = System.Drawing.Color.White;
            this.btnMInimize.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnMInimize.CheckedImage")));
            this.btnMInimize.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnMInimize.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMInimize.FocusedColor = System.Drawing.Color.Empty;
            this.btnMInimize.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMInimize.ForeColor = System.Drawing.Color.White;
            this.btnMInimize.Image = null;
            this.btnMInimize.ImageSize = new System.Drawing.Size(52, 52);
            this.btnMInimize.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnMInimize.Location = new System.Drawing.Point(639, 3);
            this.btnMInimize.Name = "btnMInimize";
            this.btnMInimize.OnHoverBaseColor = System.Drawing.Color.Purple;
            this.btnMInimize.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMInimize.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMInimize.OnHoverImage = null;
            this.btnMInimize.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnMInimize.OnPressedColor = System.Drawing.Color.Black;
            this.btnMInimize.Size = new System.Drawing.Size(37, 37);
            this.btnMInimize.TabIndex = 2;
            this.btnMInimize.Text = "_";
            this.btnMInimize.Click += new System.EventHandler(this.btnMInimize_Click);
            // 
            // drgctrlpaneltop
            // 
            this.drgctrlpaneltop.TargetControl = this.pnlTop;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblName.Location = new System.Drawing.Point(154, -1);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(404, 40);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Project SeveN Loader";
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gunaPanel1.Controls.Add(this.flowLayoutPanel1);
            this.gunaPanel1.Location = new System.Drawing.Point(-2, 352);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(719, 23);
            this.gunaPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Purple;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(10, 23);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Loader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(716, 375);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Loader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOADER";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.gunaPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradient2Panel pnlTop;
        private Guna.UI.WinForms.GunaAdvenceTileButton btnMInimize;
        private Guna.UI.WinForms.GunaAdvenceTileButton btnClose;
        private Guna.UI.WinForms.GunaDragControl drgctrlpaneltop;
        private Guna.UI.WinForms.GunaLabel lblName;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Timer timer1;
    }
}

