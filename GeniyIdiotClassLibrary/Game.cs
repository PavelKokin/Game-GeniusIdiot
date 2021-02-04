using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniyIdiotClassLibrary
{
    public class Game
    {
        private List<Question> questions;
        private Question currentQuestion;
        private User user;
        private int questionNumber = 0;
        private int allCountQuestions;
        public Game(User user)
        {
            this.user = user;
            questions = QuestionsStorage.GetAll();
            allCountQuestions = questions.Count;
        }
        public Question PopRandomQuestion()
        {
            var random = new Random();
            var index = random.Next(0, questions.Count);
            currentQuestion = questions[index];
            questions.RemoveAt(index);
            questionNumber++;
            return currentQuestion;
        }
        public bool End()
        {
            return questions.Count == 0;
        }
        public void AcceptUserAnswer(int userAnswer)
        {
            var rightAnswer = currentQuestion.Answer;
            if (userAnswer == rightAnswer)
            {
                user.AcceptRightAnswers();
            }
        }
        public string GetQuestionNumberInfo()
        {
            return "Вопрос №" + questionNumber;
        }
        public string DiagnoseCalculate()
        {
            DiagnoseCalculator.Calculate(user, allCountQuestions);
            return user.Name + ", Ваш диагноз: " + user.Diagnose;
        }
    }
}
