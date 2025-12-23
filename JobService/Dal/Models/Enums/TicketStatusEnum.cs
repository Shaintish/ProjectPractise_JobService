namespace JobService.Dal.Models.Enums;

/// <summary>
/// Статус заявки на вакансию
/// </summary>
public enum TicketStatusEnum
{
    /// <summary>
    /// На проверке
    /// </summary>
    InReview = 1,
    
    /// <summary>
    /// Подтверждена
    /// </summary>
    Accepted = 2,
    
    /// <summary>
    /// Отклонена
    /// </summary>
    Rejected = 3,
    
    /// <summary>
    /// Отменена
    /// </summary>
    Cancelled = 4
}