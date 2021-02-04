using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniyIdiotClassLibrary
{
    public class QuestionsStorage
    {
        public static string Path = "QuestionsList.json";

        public static void Add(Question question)
        {
            var questionList = GetAll();
            questionList.Add(question);
            Save(questionList);
        }

        public static List<Question> GetAll()
        {
            var questions = new List<Question>();
            if (FileProvider.Exist(Path))
            {
                var data = FileProvider.Get(Path);
                questions = JsonConvert.DeserializeObject<List<Question>>(data);
                return questions;
            }
            questions.Add(new Question("Сколько будет два плюс два умноженное на два?", 6));
            questions.Add(new Question("Бревно нужно распилить на 10 частей, сколько надо сделать распилов?", 9));
            questions.Add(new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25));
            questions.Add(new Question("Укол делают каждые полчаса, сколько нужно минут для трех уколов?", 60));
            questions.Add(new Question("Пять свечей горело, две потухли. Сколько свечей осталось?", 2));
            return questions;
        }

        static void Save(List<Question> questions)
        {
            var jsonData = JsonConvert.SerializeObject(questions,Formatting.Indented);
            FileProvider.Replase(Path, jsonData);
        }
    }
}
