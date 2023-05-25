namespace FormMain
{
    partial class ButtonNormal
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
            this.buttonCXL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCXL
            // 
            this.buttonCXL.BackColor = System.Drawing.Color.White;
            this.buttonCXL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCXL.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonCXL.Location = new System.Drawing.Point(0, 0);
            this.buttonCXL.Name = "buttonCXL";
            this.buttonCXL.Size = new System.Drawing.Size(149, 40);
            this.buttonCXL.TabIndex = 0;
            this.buttonCXL.Text = "取消";
            this.buttonCXL.UseVisualStyleBackColor = false;
            // 
            // ButtonCancel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonCXL);
            this.Name = "ButtonCancel";
            this.Size = new System.Drawing.Size(149, 40);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCXL;
    }
}
