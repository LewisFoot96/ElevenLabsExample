namespace ElevenLabsExample.ApiService.Models;

public class PhoneCall
{
    public Guid Id { get; set; }
    public string CarerName { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
    public DateTime VisitDate { get; set; }
    public int VisitDuration { get; set; }
    public string ClientPostcode { get; set; } = null!;
    // Call tracking fields
    public string? ConversationId { get; set; }           // ElevenLabs conversation_id
    public string Status { get; set; } = "Pending";
    public string? Transcript { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? CompletedAt { get; set; }
    public int DurationSeconds { get; set; } = 0;
}
