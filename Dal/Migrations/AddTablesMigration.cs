using FluentMigrator;
using JobService.Dal.Models;
using JobService.Logic.JobLogicService;

namespace JobService.Dal.Migrations;

[Migration(0001)]
public class AddTablesMigration : Migration
{
    private readonly string _jobTableName = nameof(JobModel);
    private readonly string _ticketTableName = nameof(TicketModel);
    
    /// <inheritdoc/>
    public override void Up()
    {
        if (!Schema.Table(_jobTableName).Exists())
        {
            Create.Table(_jobTableName)
                .WithColumn(nameof(JobModel.Id)).AsGuid().PrimaryKey()
                .WithColumn(nameof(JobModel.Title)).AsString(50).Nullable()
                .WithColumn(nameof(JobModel.Description)).AsString().Nullable()
                .WithColumn(nameof(JobModel.Type)).AsInt16().Nullable()
                .WithColumn(nameof(JobModel.Department)).AsString().Nullable()
                .WithColumn(nameof(JobModel.Salary)).AsDecimal().Nullable()
                .WithColumn(nameof(JobModel.Deadline)).AsDateTime().Nullable()
                .WithColumn(nameof(JobModel.CreatedAt)).AsDateTime().NotNullable()
                .WithColumn(nameof(JobModel.UpdatedAt)).AsDateTime().Nullable();
        }

        if (!Schema.Table(_ticketTableName).Exists())
        {
            Create.Table(_ticketTableName)
                .WithColumn(nameof(TicketModel.Id)).AsGuid().PrimaryKey()
                .WithColumn(nameof(TicketModel.JobId)).AsGuid().NotNullable()
                .WithColumn(nameof(TicketModel.UserId)).AsString().Nullable()
                .WithColumn(nameof(TicketModel.Email)).AsString().Nullable()
                .WithColumn(nameof(TicketModel.CoverLetter)).AsString().Nullable()
                .WithColumn(nameof(TicketModel.Status)).AsInt16().Nullable()
                .WithColumn(nameof(TicketModel.AppliedAt)).AsDateTime().Nullable();
        }
    }

    /// <inheritdoc/>
    public override void Down()
    {
        if (Schema.Table(_jobTableName).Exists())
        {
            Delete.Table(_jobTableName);
        }

        if (Schema.Table(_ticketTableName).Exists())
        {
            Delete.Table(_ticketTableName);
        }
    }
}