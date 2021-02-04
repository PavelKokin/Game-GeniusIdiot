using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniyIdiotClassLibrary
{
    public class DiagnoseCalculator
    {
        public static List<Diagnos> diagnosis = new List<Diagnos>()
        {
            new Diagnos("Идиот", 0),
            new Diagnos("Кретин", 0.2),
            new Diagnos("Дурак", 0.4),
            new Diagnos("Нормальный", 0.6),
            new Diagnos("Талант", 0.8),
            new Diagnos("Гений", 1)
        };


        public static void Calculate(User user, int countQuestions)
        {
            for (int i = 5; i >= 0; i--)
            {
                double currentRelativeQualityRightAnswers = (double)user.CountRightAnswers / countQuestions;
                int indexDiagnosis = i;
                if (currentRelativeQualityRightAnswers >= diagnosis[i].RelativeRang)
                {
                    user.Diagnose = diagnosis[indexDiagnosis].Name;
                    break;
                }
            }
        }
        public static List<Diagnos> GetDiagnosis()
        {
            return diagnosis;
        }
    }
}
