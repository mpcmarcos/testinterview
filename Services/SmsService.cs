using Microsoft.Extensions.Logging;

namespace Interview.Services
{
  public class SmsService : ISmsService
  {
    private readonly ILogger<SmsService> _logger;

    public SmsService(ILogger<SmsService> logger)
    {
      _logger = logger;
    }

    public void Send(string phone, string message)
    {
      _logger.LogInformation("Phone: {phone} | Message: {message}", phone, message);
    }
  }
}