using Microsoft.EntityFrameworkCore;
using ManagementDAL.IRepository;
using ManagementDAL.Infrastructure.DAL.DbContextManagement;
using Microsoft.Extensions.DependencyInjection;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DatabaseContext>(options =>
        options.UseSqlite("Data Source=test.db"));

// IOC Container
builder.Services.AddScoped(typeof(ManagementDAL.IRepository.IRepository), typeof(Repository ));

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<DatabaseContext>();
    SeedData.Initialize(context);
}
app.Run();