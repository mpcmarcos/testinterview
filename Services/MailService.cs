using Microsoft.Extensions.Logging;

namespace Interview.Services
{
  public class MailService : IMailService
  {
    private readonly ILogger<MailService> _logger;

    public MailService(ILogger<MailService> logger)
    {
      _logger = logger;
    }

    public void Send(string to, string from, string body)
    {
      _logger.LogInformation("To: {to} | From: {from} | Body: {body}", to, from, body);
    }
  }
}