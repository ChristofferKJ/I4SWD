using System;
using System.Collections.Generic;
using System.Text;
using App1.Model;

namespace App1.Services
{
    public class UserServices
    {
        public UserServices()
        {

        }

        public List<User> GetUsers()
        {
            var list = new List<User>
            {
                new User
                {
                    Username = "MarkusFriis123",
                    UserHiscore = 484
                },

                new User
                {
                    Username = "MowgliWonKanobi",
                    UserHiscore = 900
                },
                new User
                {
                    Username = "RasmusRøved",
                    UserHiscore = 33
                },
                new User
                {
                    Username = "Sucker4Love",
                    UserHiscore = 999
                }
            };
        return list; 
        }



    }
}
