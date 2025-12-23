using JobService.Dal.Models.Enums;

namespace JobService.Dal.Models;

/// <summary>
/// Модель данных заявки
/// </summary>
public record TicketModel
{
    /// <summary>
    /// Идентификатор заявки
    /// </summary>
    public Guid Id { get; init; }

    /// <summary>
    /// Идентификатор вакансии на которую подана заявка
    /// </summary>
    public Guid JobId { get; init; }

    /// <summary>
    /// Идентификатор заявителя
    /// </summary>
    public string UserId { get; init; }
    
    /// <summary>
    /// Почта заявителя
    /// </summary>
    public string? Email { get; init; }

    /// <summary>
    /// Сопроводительное письмо
    /// </summary>
    public string? CoverLetter { get; init; }

    /// <summary>
    /// Текущий статус заявки
    /// </summary>
    public TicketStatusEnum Status { get; set; }

    /// <summary>
    /// Время подачи заявки
    /// </summary>
    public DateTime AppliedAt { get; set; }
}