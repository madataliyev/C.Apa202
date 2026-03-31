using System;
using _08_StatiClassExtensionMethodsExceptions.Models;
using _08_StatiClassExtensionMethodsExceptions.Exceptions;

namespace ProjectName.Services
{
    public class LoginSystem 
    {
        private User[] users;
        private const int MaxAttempts = 3;

        public LoginSystem() 
        {
            users = new User[] {
                new User("admin", "admin123"),
                new User("student", "student123"),
                new User("teacher", "teacher123")
            };
        }

        public void ValidateUsername(string username) 
        {
            if (string.IsNullOrEmpty(username) || username.Length < 3)
                throw new InvalidUsernameException();
        }

        public void ValidatePassword(string password) 
        {
            if (string.IsNullOrEmpty(password) || password.Length < 6)
                throw new InvalidPasswordException();
        }

        private User FindUser(string username) 
        {
            foreach (var u in users) 
            {
                if (u.Username.ToLower() == username.ToLower())
                    return u;
            }
            return null;
        }

        public bool Login(string username, string password) 
        {
            ValidateUsername(username);
            ValidatePassword(password);

            User found = FindUser(username);
            if (found == null) throw new UserNotFoundException(username);
            if (found.IsLocked) throw new AccountLockedException();

            if (found.Password == password) 
            {
                found.FailedAttempts = 0;
                Console.WriteLine("Sistemə daxil oldunuz!");
                return true;
            } 
            else 
            {
                found.FailedAttempts++;
                int left = MaxAttempts - found.FailedAttempts;

                if (left > 0) throw new IncorrectPasswordException(left);
                
                found.IsLocked = true;
                throw new AccountLockedException();
            }
        }
    }
}