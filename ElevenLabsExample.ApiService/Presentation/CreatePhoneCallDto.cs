namespace ElevenLabsExample.ApiService.Presentation;

public record CreatePhoneCallDto(
    string CarerFirstName,
    int PhoneNumber,
    DateTime VisitDate,
    int VisitDurationMinutes,
    string ClientPostcode);