﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Models;

public partial class StudInfoSys1Context : DbContext
{
    public StudInfoSys1Context(DbContextOptions<StudInfoSys1Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Room> Rooms { get; set; }

    public virtual DbSet<Section> Sections { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<Teacher> Teachers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Course>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Course");

            entity.Property(e => e.CourseID)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CourseName)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<Room>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Room");

            entity.Property(e => e.CourseName)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.RoomID)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.RoomName)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.SectionName)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<Section>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Section");

            entity.Property(e => e.SectionID)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.SectionName)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Teacher)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Student");

            entity.Property(e => e.FirstName)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.LastName)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.StudentID)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<Teacher>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Teacher");

            entity.Property(e => e.TeacherID)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.TeacherName)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}