namespace FrontToBack.Services
{
    public interface IEmailService
    {
        string OffEmail { get; set; }
        void SendEmail();

    }
}
