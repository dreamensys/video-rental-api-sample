using RentalVideo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentalVideo.Repository
{
    
    public class UserRepository
    {
        public static UserRepository instance;
        private List<UserLoginVIewModel> usersList = new List<UserLoginVIewModel>();

        public UserRepository()
        {
            usersList.Add(new UserLoginVIewModel()
            {
                Id = 1,
                Name = "Pepe Perez",
                Email = "pepe@hotmail.com",
                Password = "123",
                Language = "es"
            });
            usersList.Add(new UserLoginVIewModel()
            {
                Id = 2,
                Name = "Mary",
                Email = "mary@hotmail.com",
                Password = "789",
                Language = "en"
            });
            usersList.Add(new UserLoginVIewModel()
            {
                Id = 3,
                Name = "Ramón Lopez",
                Email = "ramon@hotmail.com",
                Password = "9911",
                Language = "en"
            });
        }

        public List<UserLoginVIewModel> GetAllUsers()
        {
            return usersList;
        }
        public UserLoginVIewModel AuthenticateUser(string email, string password)
        {
            UserLoginVIewModel model = usersList.FirstOrDefault(x => x.Email.Equals(email) && x.Password.Equals(password));
            return model;
        }
        public static UserRepository GetInstance()
        {
            if (instance == null)
            {
                instance = new UserRepository();
            }
            return instance;
        }
    }
}