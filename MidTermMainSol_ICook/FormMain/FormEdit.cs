using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMain
{
	public partial class FormEdit : Form
	{
		public FormEdit()
		{
			InitializeComponent();
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(213)))), ((int)(((byte)(230)))));
		}





		private void buttonSave_Click(object sender, EventArgs e)
		{
			try
			{
				//儲存程序寫這裡
			}
			catch
			{  //儲存失敗的狀況
				MessageBox.Show("儲存失敗，請稍後再試");
				return;
			}

			//通知(儲存成功的狀況)
			INotify frm = this.Owner as INotify;
			frm.Success();

			//關閉本視窗
			this.Close();
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
