﻿// <auto-generated />
using System;
using Demos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Demos.Migrations
{
    [DbContext(typeof(BloggingContext))]
    partial class BloggingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-preview2-30571")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Demos.Blog", b =>
                {
                    b.Property<int>("BlogId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BlogUrl");

                    b.Property<int?>("ThemeId");

                    b.HasKey("BlogId");

                    b.HasIndex("ThemeId");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("Demos.Theme", b =>
                {
                    b.Property<int>("ThemeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("TitleColor");

                    b.HasKey("ThemeId");

                    b.ToTable("Themes");

                    b.HasData(
                        new { ThemeId = 1, Name = "MSDN", TitleColor = "AliceBlue" },
                        new { ThemeId = 2, Name = "TechNet", TitleColor = "DarkCyan" },
                        new { ThemeId = 3, Name = "EF", TitleColor = "Purple" },
                        new { ThemeId = 4, Name = "Personal", TitleColor = "LightBlue" }
                    );
                });

            modelBuilder.Entity("Demos.Blog", b =>
                {
                    b.HasOne("Demos.Theme", "Theme")
                        .WithMany()
                        .HasForeignKey("ThemeId");
                });
#pragma warning restore 612, 618
        }
    }
}
