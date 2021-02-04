using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace GeniyIdiotClassLibrary
{
    public class UserResultStorage
    {
        public static string Path = "UserResults.json"; 
        public static void Append(User user)
        {
            var userResults = GetAll();
            userResults.Add(user);
            Save(userResults);
        }
        public static List<User> GetAll()
        {
            if (!FileProvider.Exist(Path))
            {
                return new List<User>();
            }
            var data = FileProvider.Get(Path);
            var userResults = JsonConvert.DeserializeObject<List<User>>(data);
            return userResults;
        }
        static void Save(List<User> userResults)
        {
            var jsonData = JsonConvert.SerializeObject(userResults, Formatting.Indented);
            FileProvider.Replase(Path, jsonData);
        }
    }
}
