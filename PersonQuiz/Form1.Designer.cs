﻿namespace PersonQuiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(50, 60);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(400, 260);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // answerTextBox
            // 
            this.answerTextBox.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.answerTextBox.Location = new System.Drawing.Point(50, 340);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(300, 27);
            this.answerTextBox.TabIndex = 2;
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.submitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitButton.FlatAppearance.BorderSize = 0;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold);
            this.submitButton.ForeColor = System.Drawing.Color.White;
            this.submitButton.Location = new System.Drawing.Point(370, 338);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(80, 30);
            this.submitButton.TabIndex = 3;
            this.submitButton.Text = "제출";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold);
            this.resultLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.resultLabel.Location = new System.Drawing.Point(50, 380);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(400, 30);
            this.resultLabel.TabIndex = 4;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.nextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextButton.FlatAppearance.BorderSize = 0;
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold);
            this.nextButton.ForeColor = System.Drawing.Color.White;
            this.nextButton.Location = new System.Drawing.Point(200, 430);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(100, 35);
            this.nextButton.TabIndex = 5;
            this.nextButton.Text = "다음";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.titleLabel.Location = new System.Drawing.Point(170, 15);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(134, 37);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "인물 퀴즈";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(500, 550);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.nextButton);
            this.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
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
        private System.Windows.Forms.Label titleLabel;
    }
}

