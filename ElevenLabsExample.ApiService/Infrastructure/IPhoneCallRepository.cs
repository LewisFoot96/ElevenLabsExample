namespace ElevenLabsExample.ApiService.Infrastructure;

public interface IPhoneCallRepository
{
    Task AddPhoneCall(CancellationToken cancellationToken);
}
