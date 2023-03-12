namespace Project_SeveN
{
    partial class MAIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAIN));
            this.gunaAdvenceTileButton1 = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.SuspendLayout();
            // 
            // gunaAdvenceTileButton1
            // 
            this.gunaAdvenceTileButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceTileButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceTileButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaAdvenceTileButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceTileButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceTileButton1.CheckedImage")));
            this.gunaAdvenceTileButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceTileButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceTileButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceTileButton1.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.gunaAdvenceTileButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceTileButton1.Image")));
            this.gunaAdvenceTileButton1.ImageSize = new System.Drawing.Size(52, 52);
            this.gunaAdvenceTileButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceTileButton1.Location = new System.Drawing.Point(345, 219);
            this.gunaAdvenceTileButton1.Name = "gunaAdvenceTileButton1";
            this.gunaAdvenceTileButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaAdvenceTileButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton1.OnHoverImage = null;
            this.gunaAdvenceTileButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceTileButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton1.Size = new System.Drawing.Size(160, 160);
            this.gunaAdvenceTileButton1.TabIndex = 0;
            this.gunaAdvenceTileButton1.Text = "gunaAdvenceTileButton1";
            this.gunaAdvenceTileButton1.Click += new System.EventHandler(this.gunaAdvenceTileButton1_Click);
            // 
            // MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gunaAdvenceTileButton1);
            this.Name = "MAIN";
            this.Text = "MAIN";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaAdvenceTileButton gunaAdvenceTileButton1;
    }
}