using _08_StatiClassExtensionMethodsExceptions.Exceptions;
using ProjectName.Services;
class Program
{
    static void Main()
    {
        LoginSystem system = new LoginSystem();

        while (true)
        {
            try
            {
               
                Console.Write("Username: ");
                string name = Console.ReadLine();
                Console.Write("Password: ");
                string pass = Console.ReadLine();

                if (system.Login(name, pass)) break;
            }
            catch (InvalidUsernameException ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }
            catch (InvalidPasswordException ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }
            catch (UserNotFoundException ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
                Console.WriteLine("Mövcud userlər: admin, student, teacher");
            }
            catch (IncorrectPasswordException ex)
            {
                Console.WriteLine("WARNING: " + ex.Message);
            }
            catch (AccountLockedException ex)
            {
                Console.WriteLine("CRITICAL: " + ex.Message + " Adminlə əlaqə saxlayın.");
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine("UNEXPECTED ERROR: " + ex.Message);
            }
        }
    }
}
