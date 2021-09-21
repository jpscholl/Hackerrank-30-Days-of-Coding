using System;
using System.Collections.Generic;

namespace User
{
    class Program
    {
        public class User
        {
            //class variables
            String username;
            String password;
            int age;
            HashSet<int> orderIDs;

            //class constructors
            public User(String customUserName, String customPassword, int customAge, HashSet<int> orderIDs)
            {
                this.username = customUserName;
                this.password = customPassword;
                this.age = customAge;
                this.orderIDs = orderIDs;
            }
        }

        static void Main(string[] args)
        {
            HashSet<int> a = new HashSet<int>();
            a.Add(1212);
            User jonathan = new User("Aeon", "nicebuns20", 33, a);

            //that was the whole video...??? Not really much to the day 28 video
        }
    }
}