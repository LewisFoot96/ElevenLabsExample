namespace ElevenLabsExample.ApiService.Application;

public interface IElevenLabsService
{
    Task CreateElevenLabsPhoneCall(CancellationToken cancellationToken);
}
