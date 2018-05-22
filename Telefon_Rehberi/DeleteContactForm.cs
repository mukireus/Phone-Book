using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telefon_Rehberi
{
    public partial class DeleteContactForm : Form
    {
        public DeleteContactForm()
        {
            InitializeComponent();
        }

        private void DeleteContactForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm openForm = new MainForm();
            openForm.Show();
            this.Hide();
        }
    }
}
