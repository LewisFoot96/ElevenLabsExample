using ElevenLabsExample.ApiService.Models;

namespace ElevenLabsExample.ApiService.Infrastructure;

public interface IPhoneCallRepository
{
    Task AddPhoneCallAsync(PhoneCall phoneCall, CancellationToken cancellationToken);
    Task UpdatePhoneCallStatusAsync(Guid phoneCallId, string phoneCallStatus, CancellationToken cancellationToken);
}
