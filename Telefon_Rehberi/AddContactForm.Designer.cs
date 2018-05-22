namespace Telefon_Rehberi
{
    partial class AddContactForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddContactForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.btnColor = new System.Windows.Forms.Button();
            this.txtPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // txtName
            // 
            resources.ApplyResources(this.txtName, "txtName");
            this.txtName.Name = "txtName";
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // txtSurname
            // 
            resources.ApplyResources(this.txtSurname, "txtSurname");
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSurname_KeyPress);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.ForestGreen;
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Orange;
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.DeepSkyBlue;
            resources.ApplyResources(this.btnColor, "btnColor");
            this.btnColor.ForeColor = System.Drawing.Color.White;
            this.btnColor.Name = "btnColor";
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // txtPhoneNumber
            // 
            resources.ApplyResources(this.txtPhoneNumber, "txtPhoneNumber");
            this.txtPhoneNumber.Name = "txtPhoneNumber";
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
            // AddContactForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(238)))));
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.MaximizeBox = false;
            this.Name = "AddContactForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddContactForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.MaskedTextBox txtPhoneNumber;
        private System.Windows.Forms.Button btnBack;
    }
}