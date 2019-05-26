namespace CadencePublicProductPortfolio
{
    partial class ICPackagingSiPProductPortfolio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ICPackagingSiPProductPortfolio));
            this.ICPackagingSiP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ICPackagingSiP
            // 
            this.ICPackagingSiP.Location = new System.Drawing.Point(754, -2);
            this.ICPackagingSiP.Name = "ICPackagingSiP";
            this.ICPackagingSiP.Size = new System.Drawing.Size(151, 19);
            this.ICPackagingSiP.TabIndex = 0;
            this.ICPackagingSiP.Text = "IC Packaging and SiP";
            this.ICPackagingSiP.UseVisualStyleBackColor = true;
            this.ICPackagingSiP.Click += new System.EventHandler(this.ICPackagingSiP_Click);
            // 
            // ICPackagingSiPProductPortfolio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1007, 559);
            this.Controls.Add(this.ICPackagingSiP);
            this.MaximumSize = new System.Drawing.Size(1023, 598);
            this.Name = "ICPackagingSiPProductPortfolio";
            this.Text = "ICPackagingSiPProductPortfolio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ICPackagingSiP;
    }
}