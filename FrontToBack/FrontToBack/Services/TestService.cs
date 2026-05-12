namespace FrontToBack.Services
{
    public class TestService : IEmailService
    {
        public string OffEmail { get; set; }

        public void SendEmail()
        {
            Console.WriteLine("Test service");
        }
    }
}
