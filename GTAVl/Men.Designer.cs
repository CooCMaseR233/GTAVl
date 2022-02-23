
namespace GTAVl
{
    partial class Men
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Men));
            this.btnGrandpa = new System.Windows.Forms.Button();
            this.lbl3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGrandpa
            // 
            this.btnGrandpa.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGrandpa.Location = new System.Drawing.Point(639, 323);
            this.btnGrandpa.Name = "btnGrandpa";
            this.btnGrandpa.Size = new System.Drawing.Size(149, 115);
            this.btnGrandpa.TabIndex = 0;
            this.btnGrandpa.Text = "Next";
            this.btnGrandpa.UseVisualStyleBackColor = true;
            this.btnGrandpa.Click += new System.EventHandler(this.btnGrandpa_Click);
            // 
            // lbl3
            // 
            this.lbl3.BackColor = System.Drawing.Color.Transparent;
            this.lbl3.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl3.Location = new System.Drawing.Point(0, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(615, 204);
            this.lbl3.TabIndex = 1;
            this.lbl3.Text = "The pain in you is growing and unfortunately you are trying to fill the gap in yo" +
    "ur heart while playing League of legends\r\n";
            // 
            // Men
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.btnGrandpa);
            this.Name = "Men";
            this.Text = "Men";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CloseForm);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGrandpa;
        private System.Windows.Forms.Label lbl3;
    }
}