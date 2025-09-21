using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class UserNames : Form
    {
        private string userName;
        public UserNames()
        {
            InitializeComponent();
        }
        public string GetUserNames()
        {
            return userName;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            userName = txtName.Text;
            if (!string.IsNullOrEmpty(userName))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else { MessageBox.Show("Please enter a name"); return; }
        }

        private void lblAskUsername_Click(object sender, EventArgs e)
        {

        }

        private void UserNames_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.DodgerBlue;
            lblAskUsername.ForeColor = System.Drawing.Color.White;
        }
    }
}
