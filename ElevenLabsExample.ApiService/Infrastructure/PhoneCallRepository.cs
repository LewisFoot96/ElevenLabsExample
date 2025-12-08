
using ElevenLabsExample.ApiService.Models;
using Microsoft.EntityFrameworkCore;

namespace ElevenLabsExample.ApiService.Infrastructure;

public class PhoneCallRepository : IPhoneCallRepository
{
    private readonly ApplicationDbContext _dbContext;
    public PhoneCallRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task AddPhoneCallAsync(PhoneCall phoneCall, CancellationToken cancellationToken)
    {
        _dbContext.PhoneCalls.Add(phoneCall);
        await _dbContext.SaveChangesAsync(cancellationToken);
    }

    public async Task UpdatePhoneCallStatusAsync(Guid phoneCallId, string phoneCallStatus, CancellationToken cancellationToken)
    {
        await _dbContext.PhoneCalls.Where(x => x.Id == phoneCallId)
            .ExecuteUpdateAsync(setters => setters.
                SetProperty(set => set.Status, phoneCallStatus), cancellationToken);
    }
}
