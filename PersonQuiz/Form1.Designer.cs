namespace PersonQuiz
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();

            // pictureBox
            this.pictureBox.Location = new System.Drawing.Point(50, 30);
            this.pictureBox.Size = new System.Drawing.Size(400, 300);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            // answerTextBox
            this.answerTextBox.Location = new System.Drawing.Point(50, 350);
            this.answerTextBox.Size = new System.Drawing.Size(300, 20);

            // submitButton
            this.submitButton.Location = new System.Drawing.Point(370, 350);
            this.submitButton.Size = new System.Drawing.Size(80, 25);
            this.submitButton.Text = "제출";
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);

            // resultLabel
            this.resultLabel.Location = new System.Drawing.Point(50, 390);
            this.resultLabel.Size = new System.Drawing.Size(400, 20);

            // nextButton
            this.nextButton.Location = new System.Drawing.Point(50, 420);
            this.nextButton.Size = new System.Drawing.Size(80, 25);
            this.nextButton.Text = "다음";
            this.nextButton.Click += new System.EventHandler(this.NextButton_Click);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.nextButton);
            this.Text = "인물 퀴즈";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button nextButton;
    }
}

