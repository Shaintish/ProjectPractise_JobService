using System.Data;

namespace JobService.Dal.Repositories.JobRepository;

/// <inheritdoc/>
public class JobRepository : IJobRepository
{
    private readonly IDbConnection _dbConnection;

    public JobRepository(IDbConnection dbConnection)
    {
        _dbConnection = dbConnection;
    }
    
    /// <inheritdoc/>
    public async Task GetJobAsync()
    {
        
    }
    
    /// <inheritdoc/>
    public async Task GetJobListAsync()
    {
    }

    /// <inheritdoc/>
    public async Task UpdateJobAsync()
    {
        
    }

    /// <inheritdoc/>
    public async Task CreateJobAsync()
    {
        
    }

    /// <inheritdoc/>
    public async Task DeleteJobAsync()
    {
        
    }
}