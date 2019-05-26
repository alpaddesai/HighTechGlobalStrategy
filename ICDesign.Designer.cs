namespace CadencePublicProductPortfolio
{
    partial class ICDesign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ICDesign));
            this.VirtuosoSystemDesignPlatform = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VirtuosoSystemDesignPlatform
            // 
            this.VirtuosoSystemDesignPlatform.BackColor = System.Drawing.SystemColors.Control;
            this.VirtuosoSystemDesignPlatform.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VirtuosoSystemDesignPlatform.Location = new System.Drawing.Point(740, 22);
            this.VirtuosoSystemDesignPlatform.Name = "VirtuosoSystemDesignPlatform";
            this.VirtuosoSystemDesignPlatform.Size = new System.Drawing.Size(170, 25);
            this.VirtuosoSystemDesignPlatform.TabIndex = 0;
            this.VirtuosoSystemDesignPlatform.Text = "Virtuoso System Design Platform";
            this.VirtuosoSystemDesignPlatform.UseVisualStyleBackColor = false;
            this.VirtuosoSystemDesignPlatform.Click += new System.EventHandler(this.VirtuosoSystemDesignPlatform_Click);
            // 
            // ICDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1007, 588);
            this.Controls.Add(this.VirtuosoSystemDesignPlatform);
            this.MaximumSize = new System.Drawing.Size(1023, 627);
            this.Name = "ICDesign";
            this.Text = "ICDesign";
            this.Load += new System.EventHandler(this.ICDesign_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button VirtuosoSystemDesignPlatform;
    }
}