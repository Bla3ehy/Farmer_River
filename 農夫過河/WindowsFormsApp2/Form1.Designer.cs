namespace WindowsFormsApp2
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
            this.LstLeft = new System.Windows.Forms.ListBox();
            this.LstRight = new System.Windows.Forms.ListBox();
            this.BtnGo = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstLeft
            // 
            this.LstLeft.FormattingEnabled = true;
            this.LstLeft.ItemHeight = 20;
            this.LstLeft.Location = new System.Drawing.Point(21, 36);
            this.LstLeft.MultiColumn = true;
            this.LstLeft.Name = "LstLeft";
            this.LstLeft.Size = new System.Drawing.Size(205, 204);
            this.LstLeft.TabIndex = 0;
            // 
            // LstRight
            // 
            this.LstRight.FormattingEnabled = true;
            this.LstRight.ItemHeight = 20;
            this.LstRight.Location = new System.Drawing.Point(352, 36);
            this.LstRight.Name = "LstRight";
            this.LstRight.Size = new System.Drawing.Size(200, 204);
            this.LstRight.TabIndex = 1;
            // 
            // BtnGo
            // 
            this.BtnGo.Location = new System.Drawing.Point(264, 59);
            this.BtnGo.Name = "BtnGo";
            this.BtnGo.Size = new System.Drawing.Size(75, 23);
            this.BtnGo.TabIndex = 2;
            this.BtnGo.Text = ">";
            this.BtnGo.UseVisualStyleBackColor = true;
            this.BtnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(264, 200);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 3;
            this.BtnBack.Text = "<";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(423, 337);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(82, 27);
            this.BtnReset.TabIndex = 4;
            this.BtnReset.Text = "重來";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 407);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnGo);
            this.Controls.Add(this.LstRight);
            this.Controls.Add(this.LstLeft);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LstLeft;
        private System.Windows.Forms.ListBox LstRight;
        private System.Windows.Forms.Button BtnGo;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnReset;
    }
}

