namespace Telefon_Rehberi
{
    partial class ListContactForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListContactForm));
            this.rchtxtReadFile = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rchtxtReadFile
            // 
            this.rchtxtReadFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.rchtxtReadFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rchtxtReadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rchtxtReadFile.Location = new System.Drawing.Point(13, 57);
            this.rchtxtReadFile.Name = "rchtxtReadFile";
            this.rchtxtReadFile.ReadOnly = true;
            this.rchtxtReadFile.Size = new System.Drawing.Size(368, 286);
            this.rchtxtReadFile.TabIndex = 2;
            this.rchtxtReadFile.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Crimson;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBack.Location = new System.Drawing.Point(13, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(114, 39);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Geri Dön";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Orange;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearch.Location = new System.Drawing.Point(133, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 39);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Ara";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxSearch.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtBoxSearch.Location = new System.Drawing.Point(253, 12);
            this.txtBoxSearch.Multiline = true;
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(128, 39);
            this.txtBoxSearch.TabIndex = 17;
            this.txtBoxSearch.Text = "Aramak istediğiniz kişinin ismini yazınız.";
            this.txtBoxSearch.Click += new System.EventHandler(this.txtBoxSearch_Click);
            // 
            // ListContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(238)))));
            this.BackgroundImage = global::Telefon_Rehberi.Properties.Resources.Background_2_;
            this.ClientSize = new System.Drawing.Size(393, 355);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.rchtxtReadFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ListContactForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt Listeleme - Telefon Rehberi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ListContactForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rchtxtReadFile;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtBoxSearch;
    }
}