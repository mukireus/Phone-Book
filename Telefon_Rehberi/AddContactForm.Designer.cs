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
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdNameRed = new System.Windows.Forms.RadioButton();
            this.rdNameBlue = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdNameGreen = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdSurnameGreen = new System.Windows.Forms.RadioButton();
            this.rdSurnameRed = new System.Windows.Forms.RadioButton();
            this.rdSurnameBlue = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdPhoneNumberGreen = new System.Windows.Forms.RadioButton();
            this.rdPhoneNumberRed = new System.Windows.Forms.RadioButton();
            this.rdPhoneNumberBlue = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
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
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // rdNameRed
            // 
            resources.ApplyResources(this.rdNameRed, "rdNameRed");
            this.rdNameRed.Name = "rdNameRed";
            this.rdNameRed.TabStop = true;
            this.rdNameRed.UseVisualStyleBackColor = true;
            this.rdNameRed.CheckedChanged += new System.EventHandler(this.rdNameRed_CheckedChanged);
            // 
            // rdNameBlue
            // 
            resources.ApplyResources(this.rdNameBlue, "rdNameBlue");
            this.rdNameBlue.Name = "rdNameBlue";
            this.rdNameBlue.TabStop = true;
            this.rdNameBlue.UseVisualStyleBackColor = true;
            this.rdNameBlue.CheckedChanged += new System.EventHandler(this.rdNameBlue_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdNameGreen);
            this.groupBox1.Controls.Add(this.rdNameRed);
            this.groupBox1.Controls.Add(this.rdNameBlue);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // rdNameGreen
            // 
            resources.ApplyResources(this.rdNameGreen, "rdNameGreen");
            this.rdNameGreen.Name = "rdNameGreen";
            this.rdNameGreen.TabStop = true;
            this.rdNameGreen.UseVisualStyleBackColor = true;
            this.rdNameGreen.CheckedChanged += new System.EventHandler(this.rdNameGreen_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdSurnameGreen);
            this.groupBox2.Controls.Add(this.rdSurnameRed);
            this.groupBox2.Controls.Add(this.rdSurnameBlue);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // rdSurnameGreen
            // 
            resources.ApplyResources(this.rdSurnameGreen, "rdSurnameGreen");
            this.rdSurnameGreen.Name = "rdSurnameGreen";
            this.rdSurnameGreen.TabStop = true;
            this.rdSurnameGreen.UseVisualStyleBackColor = true;
            this.rdSurnameGreen.CheckedChanged += new System.EventHandler(this.rdSurnameGreen_CheckedChanged);
            // 
            // rdSurnameRed
            // 
            resources.ApplyResources(this.rdSurnameRed, "rdSurnameRed");
            this.rdSurnameRed.Name = "rdSurnameRed";
            this.rdSurnameRed.TabStop = true;
            this.rdSurnameRed.UseVisualStyleBackColor = true;
            this.rdSurnameRed.CheckedChanged += new System.EventHandler(this.rdSurnameRed_CheckedChanged);
            // 
            // rdSurnameBlue
            // 
            resources.ApplyResources(this.rdSurnameBlue, "rdSurnameBlue");
            this.rdSurnameBlue.Name = "rdSurnameBlue";
            this.rdSurnameBlue.TabStop = true;
            this.rdSurnameBlue.UseVisualStyleBackColor = true;
            this.rdSurnameBlue.CheckedChanged += new System.EventHandler(this.rdSurnameBlue_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdPhoneNumberGreen);
            this.groupBox3.Controls.Add(this.rdPhoneNumberRed);
            this.groupBox3.Controls.Add(this.rdPhoneNumberBlue);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // rdPhoneNumberGreen
            // 
            resources.ApplyResources(this.rdPhoneNumberGreen, "rdPhoneNumberGreen");
            this.rdPhoneNumberGreen.Name = "rdPhoneNumberGreen";
            this.rdPhoneNumberGreen.TabStop = true;
            this.rdPhoneNumberGreen.UseVisualStyleBackColor = true;
            this.rdPhoneNumberGreen.CheckedChanged += new System.EventHandler(this.rdPhoneNumberGreen_CheckedChanged);
            // 
            // rdPhoneNumberRed
            // 
            resources.ApplyResources(this.rdPhoneNumberRed, "rdPhoneNumberRed");
            this.rdPhoneNumberRed.Name = "rdPhoneNumberRed";
            this.rdPhoneNumberRed.TabStop = true;
            this.rdPhoneNumberRed.UseVisualStyleBackColor = true;
            this.rdPhoneNumberRed.CheckedChanged += new System.EventHandler(this.rdPhoneNumberRed_CheckedChanged);
            // 
            // rdPhoneNumberBlue
            // 
            resources.ApplyResources(this.rdPhoneNumberBlue, "rdPhoneNumberBlue");
            this.rdPhoneNumberBlue.Name = "rdPhoneNumberBlue";
            this.rdPhoneNumberBlue.TabStop = true;
            this.rdPhoneNumberBlue.UseVisualStyleBackColor = true;
            this.rdPhoneNumberBlue.CheckedChanged += new System.EventHandler(this.rdPhoneNumberBlue_CheckedChanged);
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
            // txtPhoneNumber
            // 
            resources.ApplyResources(this.txtPhoneNumber, "txtPhoneNumber");
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNumber_KeyPress);
            // 
            // AddContactForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(238)))));
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.MaximizeBox = false;
            this.Name = "AddContactForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddContactForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdNameRed;
        private System.Windows.Forms.RadioButton rdNameBlue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdSurnameGreen;
        private System.Windows.Forms.RadioButton rdSurnameRed;
        private System.Windows.Forms.RadioButton rdSurnameBlue;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdPhoneNumberGreen;
        private System.Windows.Forms.RadioButton rdPhoneNumberRed;
        private System.Windows.Forms.RadioButton rdPhoneNumberBlue;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton rdNameGreen;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtPhoneNumber;
    }
}