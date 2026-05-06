using System;


namespace _08_StatiClassExtensionMethodsExceptions.Exceptions { 
    public class InvalidUsernameException : Exception
    {
        public InvalidUsernameException() : base("Username 3 simvoldan az olmamalıdır!") { }
        public InvalidUsernameException(string message) : base(message) { }
    }

    public class InvalidPasswordException : Exception
    {
        public InvalidPasswordException() : base("Password 6 simvoldan az olmamalıdır!") { }
        public InvalidPasswordException(string message) : base(message) { }
    }

    public class UserNotFoundException : Exception
    {
        public UserNotFoundException(string username) : base($"Sistemdə {username} adlı istifadəçi tapılmadı.") { }
    }

    public class IncorrectPasswordException : Exception
    {
        public int AttemptsLeft { get; set; }
        public IncorrectPasswordException(int left) : base($"Şifrə yanlışdır. Qalan cəhd: {left}")
        {
            AttemptsLeft = left;
        }
    }

    public class AccountLockedException : Exception
    {
        public AccountLockedException() : base("Hesab bloklanıb!") { }
    }
} 
