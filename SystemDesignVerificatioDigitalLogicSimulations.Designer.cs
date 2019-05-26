namespace CadencePublicProductPortfolio
{
    partial class SystemDesignVerificatioDigitalLogicSimulations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemDesignVerificatioDigitalLogicSimulations));
            this.SystemDesignPlatform = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SystemDesignPlatform
            // 
            this.SystemDesignPlatform.BackColor = System.Drawing.SystemColors.Control;
            this.SystemDesignPlatform.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SystemDesignPlatform.Location = new System.Drawing.Point(713, 21);
            this.SystemDesignPlatform.Name = "SystemDesignPlatform";
            this.SystemDesignPlatform.Size = new System.Drawing.Size(217, 19);
            this.SystemDesignPlatform.TabIndex = 2;
            this.SystemDesignPlatform.Text = "HDL Simulators and Debug Platforms";
            this.SystemDesignPlatform.UseVisualStyleBackColor = false;
            this.SystemDesignPlatform.Click += new System.EventHandler(this.SystemDesignPlatform_Click);
            // 
            // SystemDesignVerificatioDigitalLogicSimulations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1007, 579);
            this.Controls.Add(this.SystemDesignPlatform);
            this.MaximumSize = new System.Drawing.Size(1023, 627);
            this.Name = "SystemDesignVerificatioDigitalLogicSimulations";
            this.Text = "SystemDesignVerificationDigitalLogicSimulations";
            this.Load += new System.EventHandler(this.SystemDesignVerificatioDigitalLogicSimulations_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SystemDesignPlatform;
    }
}