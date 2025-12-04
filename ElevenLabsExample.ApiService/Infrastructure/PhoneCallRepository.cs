
namespace ElevenLabsExample.ApiService.Infrastructure;

public class PhoneCallRepository : IPhoneCallRepository
{
    private readonly ApplicationDbContext _dbContext;
    public PhoneCallRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public Task AddPhoneCall(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
