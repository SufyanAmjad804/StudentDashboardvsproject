using Microsoft.EntityFrameworkCore;
using StudentDashboard.Web.Models;

namespace StudentDashboard.Web.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
}