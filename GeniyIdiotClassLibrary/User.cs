using System;

namespace GeniyIdiotClassLibrary
{
    public class User
    {
        public string Name;
        public int CountRightAnswers;
        public string Diagnose;
        public User (string name)
        {
            Name = name;
            CountRightAnswers = 0;
            Diagnose = "Неизвестно";
        }

        public void AcceptRightAnswers()
        {
            CountRightAnswers++;
        }
    }
}