using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace FormMain
{
    public partial class ButtonUpload : UserControl
    {
        public ButtonUpload()
        {
            InitializeComponent();
        }

        public string aButtonUploadText
        {
            get { return buttonUpload2.Text; }
            set { buttonUpload2.Text = value; }
        }
    }
}
