using Microsoft.AspNetCore.Mvc;

namespace JobService.Api.Controllers;

/// <summary>
/// Контроллер по управлению вакансиями
/// </summary>
[ApiController]
[Route("api/jobs")]
public class JobController : ControllerBase
{
    /// <summary>
    /// Конструктор
    /// </summary>
    public JobController()
    {
        
    }

    /// <summary>
    /// Получить вакансию
    /// </summary>
    [HttpGet("{id}")]
    public async Task GetJobAsync()
    {
        
    }

    /// <summary>
    /// Получить список вакансий
    /// </summary>
    [HttpGet]
    public async Task GetJobListAsync()
    {
        
    }

    /// <summary>
    /// Создать вакансию
    /// </summary>
    [HttpPost]
    public async Task CreateJobAsync()
    {
        
    }
    
    /// <summary>
    /// Обновить вакансию
    /// </summary>
    [HttpPut("{id}")]
    public async Task UpdateJobAsync()
    {
        
    }

    /// <summary>
    /// Удалить вакансию
    /// </summary>
    [HttpDelete("{id}")]
    public async Task DeleteJobAsync()
    {
        
    }
}