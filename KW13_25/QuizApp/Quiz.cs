using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA24_M320_2.Semester.KW13_25.QuizApp
{
    class Quiz
    {
        private Question[] allQuestions;
        private int score;
      


        public Quiz(Question[] allQuestions)
        {
            this.allQuestions = allQuestions;
            this.score = 0;
        }


        private void DisplayQuestion(Question q)
        {
            Console.WriteLine();
            Console.WriteLine(q.QuestionText);
            
            
            int answerNumber = 1;

            for(int i = 0; i < q.Answers.Length; i++)
            {
                Console.Write($"\t{answerNumber++}. ");
                Console.WriteLine(q.Answers[i]);
            }

            q.ChooseAnswer = Result(q);
            ControlAnswer(q);
           
        }


        private int Result(Question q)
        {
            Console.WriteLine($"Gebe eine Zahl von 1 bis {q.Answers.Length}");
            string myString;
            bool isZahl;
            int number;

            myString = Console.ReadLine();
            isZahl = int.TryParse(myString, out number);

            while(!isZahl || number < 1 || number > q.Answers.Length)
            {
                Console.WriteLine("Ungültige Eingabe. Gib eine Zahl ein!");
                myString = Console.ReadLine();
                isZahl = int.TryParse(myString, out number);
            }

            return number;

        }


        private void ControlAnswer(Question q)
        {
            if(q.ChooseAnswer - 1 == q.AnswerIndex)
            {
                Console.WriteLine("Korrekt");
                score++;
            } else
            {
                Console.WriteLine($"Falsch. Die richtige Antwort ist {q.Answers[q.AnswerIndex]}");
            }
        }

        public void Score(Question[] q)
        {
            Console.WriteLine($"Du hast {score} Punkt(e) von {q.Length} Fragen");
        }


        public void StartQuiz()
        {
            Console.WriteLine("Willkommen zum Quiz");

            foreach(Question q in allQuestions)
            {
                DisplayQuestion(q);
            }

            Score(allQuestions);
        }

    }
}
