namespace CadencePublicProductPortfolio
{
    partial class PrintedCircuitBoardDesignAnalysis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintedCircuitBoardDesignAnalysis));
            this.PCBDesignAnalysis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PCBDesignAnalysis
            // 
            this.PCBDesignAnalysis.Location = new System.Drawing.Point(721, 12);
            this.PCBDesignAnalysis.Name = "PCBDesignAnalysis";
            this.PCBDesignAnalysis.Size = new System.Drawing.Size(168, 22);
            this.PCBDesignAnalysis.TabIndex = 0;
            this.PCBDesignAnalysis.Text = "PCB Design Analysis";
            this.PCBDesignAnalysis.UseVisualStyleBackColor = true;
            this.PCBDesignAnalysis.Click += new System.EventHandler(this.PCBDesignAnalysis_Click);
            // 
            // PrintedCircuitBoardDesignAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(937, 574);
            this.Controls.Add(this.PCBDesignAnalysis);
            this.MaximumSize = new System.Drawing.Size(953, 613);
            this.Name = "PrintedCircuitBoardDesignAnalysis";
            this.Text = "PrintedCircuitBoardDesignAnalysis";
            this.Load += new System.EventHandler(this.PrintedCircuitBoardDesignAnalysis_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PCBDesignAnalysis;
    }
}