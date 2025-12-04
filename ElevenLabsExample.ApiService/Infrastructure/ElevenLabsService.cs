using ElevenLabsExample.ApiService.Application;

namespace ElevenLabsExample.ApiService.Infrastructure;

public class ElevenLabsService : IElevenLabsService
{
    private readonly HttpClient _httpClient;
    public ElevenLabsService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public Task CreateElevenLabsPhoneCall(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
