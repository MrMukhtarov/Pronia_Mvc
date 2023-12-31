﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProniaMvc.Models;

namespace ProniaMvc.DataAccess;

public class ProniaDbContext : IdentityDbContext
{
    public ProniaDbContext(DbContextOptions options) : base(options)
    {

    }
    public DbSet<Slider> Sliders { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductImage> ProductImages { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<ProductCategory> ProductCategories { get; set; }
    public DbSet<Setting> Settings { get; set; }
    public DbSet<AppUser> AppUsers { get; set; }
    public DbSet<ProductComment> ProductComments { get; set; }
    public DbSet<UserToken> UserTokens { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasIndex(p => p.Name).IsUnique();
        base.OnModelCreating(modelBuilder);
    }
}
