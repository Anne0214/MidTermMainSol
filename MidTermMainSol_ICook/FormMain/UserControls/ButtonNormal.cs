using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMain
{
    public partial class ButtonNormal : UserControl
    {
        public ButtonNormal()
        {
            InitializeComponent();
        }

        public string aButtonCancelText
            
        {
            get { return buttonCXL.Text; }
            set { buttonCXL.Text = value; }
        }
    }
}
