using ElevenLabsExample.ApiService.Presentation;

namespace ElevenLabsExample.ApiService.Application;

public interface ICreatePhoneCallHandler
{
    public Task CreatePhoneCall(CreatePhoneCallDto createPhoneCallDto, CancellationToken cancellationToken);
}
