using Shadowsocks.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Shadowsocks.Properties;

namespace Shadowsocks.View
{
    public partial class NewGroup : Form
    {
        private string strGroupName;
        public NewGroup()
        {
            InitializeComponent();
            this.Text = I18N.GetString("Assign to new group");
            this.Icon = Icon.FromHandle(Resources.ssw128.GetHicon());
        }

        public string StrGroupName { get => strGroupName; set => strGroupName = value; }

        private void BtnNewGroupConfirm_Click(object sender, EventArgs e)
        {
            strGroupName = textBoxNewGroup.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void BtnNewGroupCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
