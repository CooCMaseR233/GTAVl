
namespace GTAVl
{
    partial class reality
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reality));
            this.btnDepressed = new System.Windows.Forms.Button();
            this.lbl5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDepressed
            // 
            this.btnDepressed.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDepressed.Location = new System.Drawing.Point(659, 337);
            this.btnDepressed.Name = "btnDepressed";
            this.btnDepressed.Size = new System.Drawing.Size(129, 101);
            this.btnDepressed.TabIndex = 0;
            this.btnDepressed.Text = "Next";
            this.btnDepressed.UseVisualStyleBackColor = true;
            this.btnDepressed.Click += new System.EventHandler(this.btnDepressed_Click);
            // 
            // lbl5
            // 
            this.lbl5.BackColor = System.Drawing.Color.Transparent;
            this.lbl5.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl5.Location = new System.Drawing.Point(12, 9);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(224, 192);
            this.lbl5.TabIndex = 1;
            this.lbl5.Text = "You realize that GTA VI will not come out\r\n";
            // 
            // reality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.btnDepressed);
            this.Name = "reality";
            this.Text = "reality";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CloseForm);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDepressed;
        private System.Windows.Forms.Label lbl5;
    }
}