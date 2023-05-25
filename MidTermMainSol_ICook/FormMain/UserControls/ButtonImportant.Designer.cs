namespace FormMain
{
    partial class ButtonImportant
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonUpload2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonUpload2
            // 
            this.buttonUpload2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(116)))), ((int)(((byte)(198)))));
            this.buttonUpload2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonUpload2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonUpload2.ForeColor = System.Drawing.Color.White;
            this.buttonUpload2.Location = new System.Drawing.Point(0, 0);
            this.buttonUpload2.Name = "buttonUpload2";
            this.buttonUpload2.Size = new System.Drawing.Size(149, 40);
            this.buttonUpload2.TabIndex = 2;
            this.buttonUpload2.Text = "上傳";
            this.buttonUpload2.UseCompatibleTextRendering = true;
            this.buttonUpload2.UseVisualStyleBackColor = false;
            // 
            // ButtonUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonUpload2);
            this.Name = "ButtonUpload";
            this.Size = new System.Drawing.Size(149, 40);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonUpload2;
    }
}
