namespace FormMain
{
	partial class FormSearch
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
			this.button1 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Checkbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.MemberPK = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Operation = new System.Windows.Forms.DataGridViewButtonColumn();
			this.LabelRowCount = new System.Windows.Forms.Label();
			this.toast = new FormItem.Toast();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(32, 34);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Checkbox,
            this.MemberPK,
            this.Operation});
			this.dataGridView1.Location = new System.Drawing.Point(43, 129);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1026, 589);
			this.dataGridView1.TabIndex = 4;
			// 
			// Checkbox
			// 
			this.Checkbox.HeaderText = "請選取";
			this.Checkbox.Name = "Checkbox";
			// 
			// MemberPK
			// 
			this.MemberPK.HeaderText = "會員PK";
			this.MemberPK.Name = "MemberPK";
			// 
			// Operation
			// 
			this.Operation.HeaderText = "操作";
			this.Operation.Name = "Operation";
			// 
			// LabelRowCount
			// 
			this.LabelRowCount.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.LabelRowCount.AutoSize = true;
			this.LabelRowCount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.LabelRowCount.Location = new System.Drawing.Point(986, 93);
			this.LabelRowCount.Name = "LabelRowCount";
			this.LabelRowCount.Size = new System.Drawing.Size(83, 20);
			this.LabelRowCount.TabIndex = 5;
			this.LabelRowCount.Text = "總共OO筆";
			// 
			// toast
			// 
			this.toast.AMessage = "儲存成功";
			this.toast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.toast.Location = new System.Drawing.Point(32, 653);
			this.toast.Name = "toast";
			this.toast.Size = new System.Drawing.Size(203, 55);
			this.toast.TabIndex = 1;
			this.toast.Visible = false;
			// 
			// FormSearch
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1098, 745);
			this.Controls.Add(this.LabelRowCount);
			this.Controls.Add(this.toast);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.button1);
			this.Name = "FormSearch";
			this.Text = "FormSearch";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private FormItem.Toast toast;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label LabelRowCount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Checkbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberPK;
        private System.Windows.Forms.DataGridViewButtonColumn Operation;
    }
}