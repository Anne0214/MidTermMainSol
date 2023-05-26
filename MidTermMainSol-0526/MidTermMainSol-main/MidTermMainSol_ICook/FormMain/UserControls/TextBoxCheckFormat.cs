﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBoxAndTable
{
	public partial class TextBoxCheckFormat : UserControl
	{
		public TextBoxCheckFormat()
		{
			InitializeComponent();
		}

		public string afiledName
		{
			get { return label1.Text; }
			set { 
				label1.Text = value;
				label2.Text = "請輸入正確格式的" + afiledName;
				}
		}
		public string afiledValue
		{
			get { return textBox1.Text; }
			set { textBox1.Text = value; }
		}

		
		public bool CheckFormat(Func<bool> FormatRule)
		{
			bool isRight = FormatRule();
			label2.Visible = isRight ? false:true;
			panel1.Visible= isRight ? false : true;
			return isRight;
		}


	}
}
