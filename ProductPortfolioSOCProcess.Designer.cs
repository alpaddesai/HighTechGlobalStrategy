namespace CadencePublicProductPortfolio
{
    partial class ProductPortfolioSOCProcess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductPortfolioSOCProcess));
            this.DigitalDesignProcess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DigitalDesignProcess
            // 
            this.DigitalDesignProcess.Location = new System.Drawing.Point(725, 1);
            this.DigitalDesignProcess.Name = "DigitalDesignProcess";
            this.DigitalDesignProcess.Size = new System.Drawing.Size(192, 23);
            this.DigitalDesignProcess.TabIndex = 0;
            this.DigitalDesignProcess.Text = "SOC Digital Design Process";
            this.DigitalDesignProcess.UseVisualStyleBackColor = true;
            this.DigitalDesignProcess.Click += new System.EventHandler(this.DigitalDesignProcess_Click);
            // 
            // ProductPortfolioSOCProcess
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1017, 574);
            this.Controls.Add(this.DigitalDesignProcess);
            this.MaximumSize = new System.Drawing.Size(1033, 613);
            this.Name = "ProductPortfolioSOCProcess";
            this.Load += new System.EventHandler(this.ProductPortfolioSOCProcess_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DigitalDesignProcess;
    }
}