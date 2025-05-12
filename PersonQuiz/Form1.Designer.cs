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
            this.titleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 550);
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250); // 밝은 배경
            this.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Text = "인물 퀴즈";

            // titleLabel
            this.titleLabel.Text = "인물 퀴즈";
            this.titleLabel.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(170, 15);
            this.Controls.Add(this.titleLabel);

            // pictureBox
            this.pictureBox.Location = new System.Drawing.Point(50, 60);
            this.pictureBox.Size = new System.Drawing.Size(400, 260);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.BackColor = System.Drawing.Color.White;

            // answerTextBox
            this.answerTextBox.Location = new System.Drawing.Point(50, 340);
            this.answerTextBox.Size = new System.Drawing.Size(300, 25);
            this.answerTextBox.Font = new System.Drawing.Font("맑은 고딕", 11F);

            // submitButton
            this.submitButton.Location = new System.Drawing.Point(370, 338);
            this.submitButton.Size = new System.Drawing.Size(80, 30);
            this.submitButton.Text = "제출";
            this.submitButton.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold);
            this.submitButton.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.submitButton.ForeColor = System.Drawing.Color.White;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.FlatAppearance.BorderSize = 0;
            this.submitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);

            // resultLabel
            this.resultLabel.Location = new System.Drawing.Point(50, 380);
            this.resultLabel.Size = new System.Drawing.Size(400, 30);
            this.resultLabel.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold);
            this.resultLabel.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // nextButton
            this.nextButton.Location = new System.Drawing.Point(200, 430);
            this.nextButton.Size = new System.Drawing.Size(100, 35);
            this.nextButton.Text = "다음";
            this.nextButton.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold);
            this.nextButton.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.nextButton.ForeColor = System.Drawing.Color.White;
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.FlatAppearance.BorderSize = 0;
            this.nextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextButton.Click += new System.EventHandler(this.NextButton_Click);

            // Controls
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.nextButton);

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
        private System.Windows.Forms.Label titleLabel;
    }
}

