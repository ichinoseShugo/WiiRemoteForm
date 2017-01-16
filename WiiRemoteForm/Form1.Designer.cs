namespace WiiRemoteForm
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.wiiRec = new System.Windows.Forms.CheckBox();
            this.ax = new System.Windows.Forms.Label();
            this.ay = new System.Windows.Forms.Label();
            this.az = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wiiRec
            // 
            this.wiiRec.AutoSize = true;
            this.wiiRec.Location = new System.Drawing.Point(12, 25);
            this.wiiRec.Name = "wiiRec";
            this.wiiRec.Size = new System.Drawing.Size(39, 16);
            this.wiiRec.TabIndex = 1;
            this.wiiRec.Text = "Wii";
            this.wiiRec.UseVisualStyleBackColor = true;
            // 
            // ax
            // 
            this.ax.AutoSize = true;
            this.ax.Location = new System.Drawing.Point(12, 44);
            this.ax.Name = "ax";
            this.ax.Size = new System.Drawing.Size(25, 12);
            this.ax.TabIndex = 2;
            this.ax.Text = "x軸:";
            // 
            // ay
            // 
            this.ay.AutoSize = true;
            this.ay.Location = new System.Drawing.Point(12, 60);
            this.ay.Name = "ay";
            this.ay.Size = new System.Drawing.Size(25, 12);
            this.ay.TabIndex = 3;
            this.ay.Text = "y軸:";
            // 
            // az
            // 
            this.az.AutoSize = true;
            this.az.Location = new System.Drawing.Point(12, 76);
            this.az.Name = "az";
            this.az.Size = new System.Drawing.Size(24, 12);
            this.az.TabIndex = 4;
            this.az.Text = "z軸:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.az);
            this.Controls.Add(this.ay);
            this.Controls.Add(this.ax);
            this.Controls.Add(this.wiiRec);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox wiiRec;
        private System.Windows.Forms.Label ax;
        private System.Windows.Forms.Label ay;
        private System.Windows.Forms.Label az;
    }
}

