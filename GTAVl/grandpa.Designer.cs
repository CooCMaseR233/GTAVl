
namespace GTAVl
{
    partial class grandpa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(grandpa));
            this.btnReality = new System.Windows.Forms.Button();
            this.lbl4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReality
            // 
            this.btnReality.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReality.Location = new System.Drawing.Point(632, 324);
            this.btnReality.Name = "btnReality";
            this.btnReality.Size = new System.Drawing.Size(156, 114);
            this.btnReality.TabIndex = 0;
            this.btnReality.Text = "Next";
            this.btnReality.UseVisualStyleBackColor = true;
            this.btnReality.Click += new System.EventHandler(this.btnReality_Click);
            // 
            // lbl4
            // 
            this.lbl4.BackColor = System.Drawing.Color.Transparent;
            this.lbl4.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl4.Location = new System.Drawing.Point(12, 9);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(317, 129);
            this.lbl4.TabIndex = 1;
            this.lbl4.Text = "In your old age, you somehow still manage to pass the time while waiting for GTA " +
    "VI\r\n";
            // 
            // grandpa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.btnReality);
            this.Name = "grandpa";
            this.Text = "grandpa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CloseForm);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReality;
        private System.Windows.Forms.Label lbl4;
    }
}