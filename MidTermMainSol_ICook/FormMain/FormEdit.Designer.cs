namespace FormMain
{
	partial class FormEdit
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
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.textBoxCannotBeChanged1 = new TextBoxAndTable.TextBoxCannotBeChanged();
			this.textBoxWordLimit1 = new TextBoxAndTable.TextBoxWordLimit();
			this.textBoxEditable1 = new TextBoxAndTable.TextBoxEditable();
			this.textBoxMultiline1 = new TextBoxAndTable.TextBoxMultiline();
			this.SuspendLayout();
			// 
			// buttonSave
			// 
			this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(116)))), ((int)(((byte)(198)))));
			this.buttonSave.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
			this.buttonSave.Location = new System.Drawing.Point(204, 390);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(105, 31);
			this.buttonSave.TabIndex = 0;
			this.buttonSave.Text = "儲存";
			this.buttonSave.UseVisualStyleBackColor = false;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
			this.buttonCancel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonCancel.ForeColor = System.Drawing.Color.Black;
			this.buttonCancel.Location = new System.Drawing.Point(56, 390);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(105, 31);
			this.buttonCancel.TabIndex = 0;
			this.buttonCancel.Text = "取消";
			this.buttonCancel.UseVisualStyleBackColor = false;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// textBoxCannotBeChanged1
			// 
			this.textBoxCannotBeChanged1.afiledName = "我可以塞最多這些";
			this.textBoxCannotBeChanged1.afiledValue = "";
			this.textBoxCannotBeChanged1.Location = new System.Drawing.Point(36, 24);
			this.textBoxCannotBeChanged1.Name = "textBoxCannotBeChanged1";
			this.textBoxCannotBeChanged1.Size = new System.Drawing.Size(650, 40);
			this.textBoxCannotBeChanged1.TabIndex = 1;
			// 
			// textBoxWordLimit1
			// 
			this.textBoxWordLimit1.afiledMaxCount = 0;
			this.textBoxWordLimit1.afiledName = "我可以塞最多這些";
			this.textBoxWordLimit1.afiledValue = "";
			this.textBoxWordLimit1.Location = new System.Drawing.Point(36, 70);
			this.textBoxWordLimit1.Name = "textBoxWordLimit1";
			this.textBoxWordLimit1.Size = new System.Drawing.Size(650, 40);
			this.textBoxWordLimit1.TabIndex = 2;
			// 
			// textBoxEditable1
			// 
			this.textBoxEditable1.afiledName = "我可以塞最多這些";
			this.textBoxEditable1.afiledValue = "";
			this.textBoxEditable1.Location = new System.Drawing.Point(36, 326);
			this.textBoxEditable1.Name = "textBoxEditable1";
			this.textBoxEditable1.Size = new System.Drawing.Size(650, 40);
			this.textBoxEditable1.TabIndex = 4;
			// 
			// textBoxMultiline1
			// 
			this.textBoxMultiline1.afiledMaxCount = 0;
			this.textBoxMultiline1.afiledName = "我可以塞最多這些";
			this.textBoxMultiline1.afiledValue = "";
			this.textBoxMultiline1.Location = new System.Drawing.Point(36, 105);
			this.textBoxMultiline1.Name = "textBoxMultiline1";
			this.textBoxMultiline1.Size = new System.Drawing.Size(680, 215);
			this.textBoxMultiline1.TabIndex = 5;
			// 
			// FormEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.textBoxMultiline1);
			this.Controls.Add(this.textBoxEditable1);
			this.Controls.Add(this.textBoxWordLimit1);
			this.Controls.Add(this.textBoxCannotBeChanged1);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonSave);
			this.Name = "FormEdit";
			this.Text = "FormEdit";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button buttonCancel;
		private TextBoxAndTable.TextBoxCannotBeChanged textBoxCannotBeChanged1;
		private TextBoxAndTable.TextBoxWordLimit textBoxWordLimit1;
		private TextBoxAndTable.TextBoxEditable textBoxEditable1;
		private TextBoxAndTable.TextBoxMultiline textBoxMultiline1;
	}
}