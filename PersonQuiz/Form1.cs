﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace PersonQuiz
{
    public partial class Form1 : Form
    {
        private List<(string ImagePath, string Answer)> quizData;
        private int currentQuestionIndex = 0;
        private int score = 0;

        public Form1()
        {
            InitializeComponent();
            LoadQuizData();
            DisplayQuestion();
        }

        private void LoadQuizData()
        {
            // 퀴즈 데이터 초기화
            quizData = new List<(string, string)>
            {
                (nameof(Properties.Resources.이정현), "이정현"),
                (nameof(Properties.Resources.김성훈), "김성훈"),
                (nameof(Properties.Resources.이승우), "이승우"),
                (nameof(Properties.Resources.류현진), "류현진"),
                 (nameof(Properties.Resources.김성훈1), "김성훈"),
            }; 

            // 리스트 셔플
            var rand = new Random();
            quizData = new List<(string, string)>(quizData.OrderBy(x => rand.Next()));
        }

        private void DisplayQuestion()
        {
            if (currentQuestionIndex < quizData.Count)
            {
                var currentQuestion = quizData[currentQuestionIndex];
                var imageName = currentQuestion.ImagePath;

                try
                {
                    var resourceObject = Properties.Resources.ResourceManager.GetObject(imageName);
                    if (resourceObject == null)
                    {
                        throw new Exception($"리소스 '{imageName}'를 찾을 수 없습니다.");
                    }

                    //byte[]: 바이트 배열 → MemoryStream → Bitmap 변환 후 표시
                    //Bitmap: 바로 표시
                    //리소스 추가 방식에 따라 타입이 달라질 수 있으므로,
                    //두 경우 모두 처리하는 것이 안전.

                    if (resourceObject is byte[] imageBytes)
                    {
                        using (var ms = new MemoryStream(imageBytes))
                        {
                            pictureBox.Image = new Bitmap(ms);
                        }
                    }
                    else if (resourceObject is Bitmap bitmap)
                    {
                        pictureBox.Image = bitmap;
                    }
                    else
                    {
                        throw new Exception($"리소스 '{imageName}'는 지원되지 않는 형식입니다.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"이미지를 로드하는 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pictureBox.Image = null; // 기본값 설정
                }

                answerTextBox.Text = string.Empty;
                resultLabel.Text = string.Empty;
            }
            else
            {
                MessageBox.Show($"퀴즈 종료! 점수: {score}/{quizData.Count}");
                Application.Exit();
            }
        }


        private void SubmitButton_Click(object sender, EventArgs e)
        {
            var userAnswer = answerTextBox.Text.Trim();
            var correctAnswer = quizData[currentQuestionIndex].Answer;

            if (userAnswer.Equals(correctAnswer, StringComparison.OrdinalIgnoreCase))
            {
                resultLabel.Text = "정답입니다!";
                resultLabel.ForeColor = Color.Green;
                score++;
            }
            else
            {
                resultLabel.Text = $"틀렸습니다! 정답: {correctAnswer}";
                resultLabel.ForeColor = Color.Red;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            currentQuestionIndex++;
            DisplayQuestion();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
