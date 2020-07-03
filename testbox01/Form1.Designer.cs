namespace testbox01
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.reverse_text = new System.Windows.Forms.TextBox();
            this.upper_text = new System.Windows.Forms.TextBox();
            this.input_text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // reverse_text
            // 
            this.reverse_text.Location = new System.Drawing.Point(190, 159);
            this.reverse_text.Name = "reverse_text";
            this.reverse_text.ReadOnly = true;
            this.reverse_text.Size = new System.Drawing.Size(170, 21);
            this.reverse_text.TabIndex = 0;
            this.reverse_text.TextChanged += new System.EventHandler(this.reverse_text_TextChanged);
            // 
            // upper_text
            // 
            this.upper_text.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.upper_text.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.upper_text.Location = new System.Drawing.Point(416, 158);
            this.upper_text.Name = "upper_text";
            this.upper_text.ReadOnly = true;
            this.upper_text.Size = new System.Drawing.Size(219, 21);
            this.upper_text.TabIndex = 1;
            this.upper_text.TextChanged += new System.EventHandler(this.upper_text_TextChanged);
            // 
            // input_text
            // 
            this.input_text.Location = new System.Drawing.Point(246, 277);
            this.input_text.Name = "input_text";
            this.input_text.Size = new System.Drawing.Size(269, 21);
            this.input_text.TabIndex = 2;
            this.input_text.TextChanged += new System.EventHandler(this.input_text_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.input_text);
            this.Controls.Add(this.upper_text);
            this.Controls.Add(this.reverse_text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox reverse_text;
        private System.Windows.Forms.TextBox upper_text;
        private System.Windows.Forms.TextBox input_text;
    }
}

