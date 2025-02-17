﻿namespace Saas.Permissions.Service.Data;

public class PermissionsContext : DbContext
{
    public PermissionsContext(DbContextOptions<PermissionsContext> options)
        : base(options)
    {

    }

    public DbSet<Permission> Permissions => Set<Permission>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        new PermissionEntityTypeConfiguration().Configure(modelBuilder.Entity<Permission>());
    }

}