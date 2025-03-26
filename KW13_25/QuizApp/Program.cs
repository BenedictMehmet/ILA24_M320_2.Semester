using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA24_M320_2.Semester.KW13_25.QuizApp
{
    class Program
    {
        static void Main(string[]args)
        {

            Question[] allQuestions = new Question[]
            {
                           // questionText              // Answers                      //AnswerIndex
                           //  public Question (string questionText, string[] answers, int answerIndex)
                new Question("Frage 1", new string[] {"Antwort1", "Antwort2", "Antwort3"}, 0),


                 new Question("Frage 2", new string[] {"Antwort1", "Antwort2"}, 0),

                 new Question("Frage 3", new string[] {"Antwort1", "Antwort2", "Antwort3", "Antwort4"}, 0)

            };

            

            Quiz q = new Quiz(allQuestions);

            q.StartQuiz();




        }
    }
}
