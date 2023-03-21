using Microsoft.EntityFrameworkCore;
using mngapp.Features.User.UserModels;

namespace mngapp.Database;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options):base(options){}

    public DbSet<UserModel> User { get; set; } = null!;
}