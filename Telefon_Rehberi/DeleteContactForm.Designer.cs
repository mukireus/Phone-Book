namespace Telefon_Rehberi
{
    partial class DeleteContactForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteContactForm));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Crimson;
            resources.ApplyResources(this.btnBack, "btnBack");
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Name = "btnBack";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Orange;
            resources.ApplyResources(this.btnSil, "btnSil");
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Name = "btnSil";
            this.btnSil.UseVisualStyleBackColor = false;
            // 
            // DeleteContactForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Telefon_Rehberi.Properties.Resources.Background_2_;
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnBack);
            this.MaximizeBox = false;
            this.Name = "DeleteContactForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DeleteContactForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSil;
    }
}