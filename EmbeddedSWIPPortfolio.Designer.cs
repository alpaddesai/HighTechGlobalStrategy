namespace CadencePublicProductPortfolio
{
    partial class EmbeddedSWIPPortfolio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmbeddedSWIPPortfolio));
            this.EmbeddedSoftwareIPPortfolio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmbeddedSoftwareIPPortfolio
            // 
            this.EmbeddedSoftwareIPPortfolio.Location = new System.Drawing.Point(743, 26);
            this.EmbeddedSoftwareIPPortfolio.Name = "EmbeddedSoftwareIPPortfolio";
            this.EmbeddedSoftwareIPPortfolio.Size = new System.Drawing.Size(168, 23);
            this.EmbeddedSoftwareIPPortfolio.TabIndex = 0;
            this.EmbeddedSoftwareIPPortfolio.Text = "Embedded Software IP Portfolio";
            this.EmbeddedSoftwareIPPortfolio.UseVisualStyleBackColor = true;
            this.EmbeddedSoftwareIPPortfolio.Click += new System.EventHandler(this.EmbeddedSoftwareIPPortfolio_Click);
            // 
            // EmbeddedSWIPPortfolio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1007, 594);
            this.Controls.Add(this.EmbeddedSoftwareIPPortfolio);
            this.MaximumSize = new System.Drawing.Size(1023, 633);
            this.Name = "EmbeddedSWIPPortfolio";
            this.Text = "EmbeddedSWIPPortfolio";
            this.Load += new System.EventHandler(this.EmbeddedSWIPPortfolio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EmbeddedSoftwareIPPortfolio;
    }
}