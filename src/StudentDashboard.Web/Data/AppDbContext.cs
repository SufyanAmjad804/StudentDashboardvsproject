// ==================== COMMIT 1 ====================
// Commit Message: "feat: Add AppDbContext class with base DbContext setup"
// Sirf yeh file banao aur commit karo
using Microsoft.EntityFrameworkCore;
using StudentDashboard.Web.Models;

namespace StudentDashboard.Web.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    // ==================== COMMIT 1 END - AB COMMIT KARO ====================


    // ==================== COMMIT 2 ====================
    // Commit Message: "feat: Add Students, Courses and Enrollments DbSets"
    // Yeh 3 lines add karo aur commit karo
    public DbSet<Student> Students => Set<Student>();
    public DbSet<Course> Courses => Set<Course>();
    public DbSet<Enrollment> Enrollments => Set<Enrollment>();
    // ==================== COMMIT 2 END - AB COMMIT KARO ====================


    // ==================== COMMIT 3 ====================
    // Commit Message: "feat: Add remaining DbSets for all entities"
    // Yeh sari lines add karo aur commit karo
    public DbSet<AttendanceRecord> AttendanceRecords => Set<AttendanceRecord>();
    public DbSet<GradeRecord> GradeRecords => Set<GradeRecord>();
    public DbSet<AssignmentItem> Assignments => Set<AssignmentItem>();
    public DbSet<FeeInvoice> FeeInvoices => Set<FeeInvoice>();
    public DbSet<NotificationItem> Notifications => Set<NotificationItem>();
    public DbSet<SupportTicket> SupportTickets => Set<SupportTicket>();
    public DbSet<CalendarEvent> CalendarEvents => Set<CalendarEvent>();
    // ==================== COMMIT 3 END - AB COMMIT KARO ====================


    // ==================== COMMIT 4 ====================
    // Commit Message: "feat: Add unique indexes for Student and Course"
    // Yeh method add karo aur commit karo
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Student>()
            .HasIndex(student => student.StudentNumber)
            .IsUnique();

        modelBuilder.Entity<Course>()
            .HasIndex(course => course.Code)
            .IsUnique();
        // ==================== COMMIT 4 END - AB COMMIT KARO ====================


        // ==================== COMMIT 5 ====================
        // Commit Message: "feat: Configure Enrollment relationships and foreign keys"
        // Yeh add karo aur commit karo
        modelBuilder.Entity<Enrollment>()
            .HasIndex(enrollment => new { enrollment.StudentId, enrollment.CourseId })
            .IsUnique();

        modelBuilder.Entity<Enrollment>()
            .HasOne(enrollment => enrollment.Student)
            .WithMany(student => student.Enrollments)
            .HasForeignKey(enrollment => enrollment.StudentId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Enrollment>()
            .HasOne(enrollment => enrollment.Course)
            .WithMany(course => course.Enrollments)
            .HasForeignKey(enrollment => enrollment.CourseId)
            .OnDelete(DeleteBehavior.Cascade);
        // ==================== COMMIT 5 END - AB COMMIT KARO ====================


        // ==================== COMMIT 5 ====================
        // Commit Message: "feat: Configure Enrollment relationships and foreign keys"
        // Yeh add karo aur commit karo
        modelBuilder.Entity<Enrollment>()
            .HasIndex(enrollment => new { enrollment.StudentId, enrollment.CourseId })
            .IsUnique();

        modelBuilder.Entity<Enrollment>()
            .HasOne(enrollment => enrollment.Student)
            .WithMany(student => student.Enrollments)
            .HasForeignKey(enrollment => enrollment.StudentId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Enrollment>()
            .HasOne(enrollment => enrollment.Course)
            .WithMany(course => course.Enrollments)
            .HasForeignKey(enrollment => enrollment.CourseId)
            .OnDelete(DeleteBehavior.Cascade);
        // ==================== COMMIT 5 END - AB COMMIT KARO ====================
    }
}
// ==================== COMMIT 6 END - APPDBCONTEXT COMPLETE ✅ ====================