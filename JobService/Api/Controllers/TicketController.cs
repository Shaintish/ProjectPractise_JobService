using Microsoft.AspNetCore.Mvc;

namespace JobService.Api.Controllers;

/// <summary>
/// Контроллер по управлению заявками на вакансию / стажировку
/// </summary>
[ApiController]
[Route("api/tickets")]
public class TicketController : ControllerBase
{
    /// <summary>
    /// Конструктор
    /// </summary>
    public TicketController()
    {
        
    }

    /// <summary>
    /// Получить заявку
    /// </summary>
    [HttpGet("{id}")]
    public async Task GetTicketAsync()
    {
        
    }

    /// <summary>
    /// Получить список заявок
    /// </summary>
    [HttpGet]
    public async Task GetTicketListAsync()
    {
        
    }
    
    /// <summary>
    /// Создать заявку
    /// </summary>
    [HttpPost]
    public async Task CreateTicketAsync()
    {
        
    }

    /// <summary>
    /// Обновить заявку
    /// </summary>
    [HttpPut("{id}")]
    public async Task UpdateTicketAsync()
    {
        
    }

    /// <summary>
    /// Удалить заявку
    /// </summary>
    [HttpDelete("{id}")]
    public async Task DeleteTicketAsync()
    {
        
    }
}