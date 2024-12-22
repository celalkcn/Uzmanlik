using System;
using Microsoft.EntityFrameworkCore;

namespace Proje13_EFCoreIntro;

public class ApplicationDbContext:DbContext
{
    public DbSet<Category>? Categories { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-FS0DTO0; Database=EfCoreIntroDb; Integrated Security=True; TrustServerCertificate=True; ");
        base.OnConfiguring(optionsBuilder);
    }
}
