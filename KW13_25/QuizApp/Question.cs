using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA24_M320_2.Semester.KW13_25.QuizApp
{
    class Question
    {
        public string QuestionText { get; set; }

        public string[] Answers { get; set; }

        public int AnswerIndex { get; set; }

        public int ChooseAnswer { get; set; }

        public Question (string questionText, string[] answers, int answerIndex)
        {
            this.QuestionText = questionText;
            this.Answers = answers;
            this.AnswerIndex = answerIndex;
        }
    }
}
