namespace JobService.Dal.Repositories.JobRepository;

/// <summary>
/// Репозиторий по управлению вакансиями
/// </summary>
public interface IJobRepository
{
    /// <summary>
    /// Получить вакансию
    /// </summary>
    Task GetJobAsync();

    /// <summary>
    /// Получить список вакансий
    /// </summary>
    Task GetJobListAsync();
    /// <summary>
    /// Создать вакансию
    /// </summary>
    Task CreateJobAsync();

    /// <summary>
    /// Обновить вакансию
    /// </summary>
    Task UpdateJobAsync();

    /// <summary>
    /// Удалить вакансию
    /// </summary>
    Task DeleteJobAsync();
}