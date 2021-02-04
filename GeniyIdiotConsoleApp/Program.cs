using System;
using System.Collections.Generic;
using GeniyIdiotClassLibrary;

namespace GeniyIdiotConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var userName = GetUserName();
                var user = new User(userName);
                var game = new Game(user);
                while (!game.End())
                {
                    var currentQuestion = game.PopRandomQuestion();
                    Console.WriteLine(game.GetQuestionNumberInfo());
                    Console.WriteLine(currentQuestion.Text);
                    var correctUserAnswer = CheckCorrectInput();
                    game.AcceptUserAnswer(correctUserAnswer);
                }
                Console.WriteLine("Количество правильных ответов: " + user.CountRightAnswers);
                Console.WriteLine(game.DiagnoseCalculate());
                UserResultStorage.Append(user);
                Console.WriteLine("Отобразить таблицу общих результатов:");
                var userInput = Console.ReadLine();
                if (userInput.ToLower() == "да")
                {
                    var users = UserResultStorage.GetAll();
                    ViewResultsTable(users);
                }
                Console.WriteLine("Желаете добавить вопрос в систему? \n(Внимание: Ответом на вопрос должна быть цифра!)");
                if (Console.ReadLine().ToLower() == "да")
                {
                    SaveUserQuestions();
                }
                Console.WriteLine("Пройти тестирование заново?");
                userInput = Console.ReadLine();
                if (userInput.ToLower() != "да")
                {
                    break;
                }
            }
        }
        static string GetUserName()
        {
            Console.WriteLine("Введите ФИО:");
            bool isValidName = false;
            string userName = "";
            while (isValidName != true)
            {
                userName = Console.ReadLine();

                foreach (char c in userName)
                {
                    if (!Char.IsLetter(c) && c != ' ')
                    {
                        Console.WriteLine("ФИО содержат недопустимые символы, пожалуйста повторите ввод");
                        isValidName = false;
                        break;
                    }
                    isValidName = true;
                }
            }
            return userName;
        }
        static int CheckCorrectInput()
        {
            int inputNumber;
            while (!Int32.TryParse(Console.ReadLine(), out inputNumber))
            {
                Console.WriteLine("Некорректный формат ответа, попробуйте еще раз:");
            }
            return inputNumber;
        }
        static void ViewResultsTable(List<User> users)
        {
            Console.Write(" {0,-35}", "ФИО");
            Console.Write(" {0,-35}", "Количество верных ответов");
            Console.WriteLine(" {0,-35}", "Диагноз");
            foreach(var user in users)
            {
                Console.Write(" {0,-35}", user.Name);
                Console.Write(" {0,-35}", user.CountRightAnswers);
                Console.WriteLine(" {0,-35}", user.Diagnose);
            }
        }
        static void SaveUserQuestions()
        {
            Console.WriteLine("Введите вопрос:");
            var userQuestion = Console.ReadLine();
            Console.WriteLine("Введите ответ на вопрос:");
            var userQuestionAnswer = CheckCorrectInput();
            Question question= new Question(userQuestion, userQuestionAnswer);
            QuestionsStorage.Add(question);
        }
    }
}