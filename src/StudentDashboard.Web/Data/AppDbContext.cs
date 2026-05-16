using Microsoft.EntityFrameworkCore;
using StudentDashboard.Web.Models;

namespace StudentDashboard.Web.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        public DbSet<Student> Students => Set<Student>();
    public DbSet<Course> Courses => Set<Course>();
    public DbSet<Enrollment> Enrollments => Set<Enrollment>();
    public DbSet<AttendanceRecord> AttendanceRecords => Set<AttendanceRecord>();
    public DbSet<GradeRecord> GradeRecords => Set<GradeRecord>();
    public DbSet<AssignmentItem> Assignments => Set<AssignmentItem>();
    public DbSet<FeeInvoice> FeeInvoices => Set<FeeInvoice>();
    public DbSet<NotificationItem> Notifications => Set<NotificationItem>();
    public DbSet<SupportTicket> SupportTickets => Set<SupportTicket>();
    public DbSet<CalendarEvent> CalendarEvents => Set<CalendarEvent>();
}
protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Student>()
            .HasIndex(student => student.StudentNumber)
            .IsUnique();

        modelBuilder.Entity<Course>()
            .HasIndex(course => course.Code)
            .IsUnique();
    }
}