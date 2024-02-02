using BlogOS.API.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogOS.API.Data;

public class BlogOSContext : DbContext
{
    public BlogOSContext(DbContextOptions<BlogOSContext> options)
        : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Category> Categories { get; set; }
}
