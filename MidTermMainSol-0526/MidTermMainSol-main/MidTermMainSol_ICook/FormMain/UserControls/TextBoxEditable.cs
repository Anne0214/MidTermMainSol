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
	public partial class TextBoxEditable : UserControl
	{
		public TextBoxEditable()
		{
			InitializeComponent();
		}
		public string afiledName
		{
			get { return label1.Text; }
			set { label1.Text = value; }
		}
		public string afiledValue
		{
			get { return textBox1.Text; }
			set { textBox1.Text = value; }
		}

	}
}
