using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 指挥控制终端.CustomControl
{
    public partial class UserControlButton : UserControl
    {
        public UserControlButton()
        {
            InitializeComponent();
        }
        [Browsable(true)]
        [Description("设置图片"), Category("setPic"), DefaultValue(" ")]
        public Image CusBackgroudPicture {
            get { return flowLayoutPanel1.BackgroundImage; }
            set { flowLayoutPanel1.BackgroundImage = value; }
        }
        public string CusName {
            get { return lbSubmit.Text; }
            set { lbSubmit.Text = value; }
            }
        public event EventHandler ButtonClick;
        private void lbSubmit_Click(object sender, EventArgs e)
        {
            ButtonClick?.Invoke(sender, e);
        }
    }
}
