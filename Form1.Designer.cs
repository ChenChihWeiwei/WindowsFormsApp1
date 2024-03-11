namespace WindowsFormsApp1
{
    partial class Form1
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

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btngo = new System.Windows.Forms.Button();
            this.txtshow = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btngo
            // 
            this.btngo.Font = new System.Drawing.Font("新細明體", 15F);
            this.btngo.Location = new System.Drawing.Point(339, 151);
            this.btngo.Name = "btngo";
            this.btngo.Size = new System.Drawing.Size(92, 54);
            this.btngo.TabIndex = 0;
            this.btngo.Text = "開始";
            this.btngo.UseVisualStyleBackColor = true;
            this.btngo.Click += new System.EventHandler(this.btn1_Click);
            // 
            // txtshow
            // 
            this.txtshow.Font = new System.Drawing.Font("新細明體", 15F);
            this.txtshow.Location = new System.Drawing.Point(233, 221);
            this.txtshow.Name = "txtshow";
            this.txtshow.Size = new System.Drawing.Size(296, 31);
            this.txtshow.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtshow);
            this.Controls.Add(this.btngo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngo;
        private System.Windows.Forms.TextBox txtshow;
    }
}

