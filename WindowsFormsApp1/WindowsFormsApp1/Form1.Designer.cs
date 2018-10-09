namespace WindowsFormsApp1
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
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
			this.batsText = new System.Windows.Forms.TextBox();
			this.hitsText = new System.Windows.Forms.TextBox();
			this.endButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.calculationButton = new System.Windows.Forms.Button();
			this.clearButton = new System.Windows.Forms.Button();
			this.averageText = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// batsText
			// 
			this.batsText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.batsText.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.batsText.Location = new System.Drawing.Point(236, 81);
			this.batsText.Margin = new System.Windows.Forms.Padding(2);
			this.batsText.Name = "batsText";
			this.batsText.Size = new System.Drawing.Size(111, 31);
			this.batsText.TabIndex = 0;
			this.batsText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.batsText.Click += new System.EventHandler(this.SelectAll);
			this.batsText.Enter += new System.EventHandler(this.SelectAll);
			// 
			// hitsText
			// 
			this.hitsText.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.hitsText.Location = new System.Drawing.Point(236, 138);
			this.hitsText.Margin = new System.Windows.Forms.Padding(2);
			this.hitsText.Name = "hitsText";
			this.hitsText.Size = new System.Drawing.Size(111, 34);
			this.hitsText.TabIndex = 1;
			this.hitsText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.hitsText.Click += new System.EventHandler(this.SelectAll);
			this.hitsText.Enter += new System.EventHandler(this.SelectAll);
			// 
			// endButton
			// 
			this.endButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.endButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.endButton.Location = new System.Drawing.Point(478, 318);
			this.endButton.Margin = new System.Windows.Forms.Padding(2);
			this.endButton.Name = "endButton";
			this.endButton.Size = new System.Drawing.Size(100, 33);
			this.endButton.TabIndex = 4;
			this.endButton.Text = "終了";
			this.endButton.UseVisualStyleBackColor = false;
			this.endButton.Click += new System.EventHandler(this.endButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("ＭＳ ゴシック", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label1.Location = new System.Drawing.Point(195, 31);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(215, 27);
			this.label1.TabIndex = 1;
			this.label1.Text = "打率計算アプリ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("ＭＳ ゴシック", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label2.Location = new System.Drawing.Point(98, 86);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 22);
			this.label2.TabIndex = 4;
			this.label2.Text = "打数　：";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("ＭＳ ゴシック", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label3.Location = new System.Drawing.Point(77, 144);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(120, 22);
			this.label3.TabIndex = 5;
			this.label3.Text = "安打数　：";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label4.Location = new System.Drawing.Point(116, 279);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 22);
			this.label4.TabIndex = 5;
			this.label4.Text = "打率　：";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(600, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// calculationButton
			// 
			this.calculationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.calculationButton.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.calculationButton.Location = new System.Drawing.Point(216, 189);
			this.calculationButton.Margin = new System.Windows.Forms.Padding(2);
			this.calculationButton.Name = "calculationButton";
			this.calculationButton.Size = new System.Drawing.Size(218, 46);
			this.calculationButton.TabIndex = 2;
			this.calculationButton.Text = "計算";
			this.calculationButton.UseMnemonic = false;
			this.calculationButton.UseVisualStyleBackColor = false;
			this.calculationButton.Click += new System.EventHandler(this.calculationButtons_click);
			// 
			// clearButton
			// 
			this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.clearButton.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.clearButton.Location = new System.Drawing.Point(478, 117);
			this.clearButton.Margin = new System.Windows.Forms.Padding(2);
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new System.Drawing.Size(91, 33);
			this.clearButton.TabIndex = 3;
			this.clearButton.Text = "クリア";
			this.clearButton.UseVisualStyleBackColor = false;
			this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
			// 
			// averageText
			// 
			this.averageText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.averageText.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.averageText.Location = new System.Drawing.Point(216, 267);
			this.averageText.Margin = new System.Windows.Forms.Padding(2);
			this.averageText.Name = "averageText";
			this.averageText.Size = new System.Drawing.Size(218, 39);
			this.averageText.TabIndex = 9;
			this.averageText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.ClientSize = new System.Drawing.Size(600, 360);
			this.Controls.Add(this.averageText);
			this.Controls.Add(this.clearButton);
			this.Controls.Add(this.calculationButton);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.endButton);
			this.Controls.Add(this.hitsText);
			this.Controls.Add(this.batsText);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox batsText;
        private System.Windows.Forms.TextBox hitsText;
        private System.Windows.Forms.Button endButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button calculationButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox averageText;
    }
}

