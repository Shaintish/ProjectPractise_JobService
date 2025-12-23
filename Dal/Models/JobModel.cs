using JobService.Dal.Models.Enums;

namespace JobService.Dal.Models;

/// <summary>
/// Модель данных вакансии
/// </summary>
public record JobModel
{
    /// <summary>
    /// Айди вакансии
    /// </summary>
    public Guid Id { get; init; }

    /// <summary>
    /// Название вакансии
    /// </summary>
    public string Title { get; init; }

    /// <summary>
    /// Описание вакансии
    /// </summary>
    public string? Description { get; init; }

    /// <summary>
    /// Тип вакансии
    /// </summary>
    public JobTypeEnum Type { get; init; }
    
    /// <summary>
    /// Департамент (кафедра, отдел)
    /// </summary>
    public string? Department { get; init; }

    /// <summary>
    /// Зарплата
    /// </summary>
    public decimal? Salary { get; init; }

    /// <summary>
    /// Дедлайн подачи заявок
    /// </summary>
    public DateTime? Deadline { get; init; }

    /// <summary>
    /// Дата и время создания вакансии
    /// </summary>
    public DateTime CreatedAt { get; init; }

    /// <summary>
    /// Дата и время последнего обновления вакансии
    /// </summary>
    public DateTime UpdatedAt { get; init; }
}