using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Aspnetcore.Pieshop.Webapp.Models;

namespace Aspnetcore.Pieshop.Webapp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("Aspnetcore.Pieshop.Webapp.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CategoryName");

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Aspnetcore.Pieshop.Webapp.Models.Pie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AllergyInformation");

                    b.Property<int>("CategoryId");

                    b.Property<string>("ImageThumbnailUrl");

                    b.Property<string>("ImageUrl");

                    b.Property<bool>("InStock");

                    b.Property<bool>("IsPieOfTheWeek");

                    b.Property<string>("LongDescription");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<string>("ShortDescription");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Pies");
                });

            modelBuilder.Entity("Aspnetcore.Pieshop.Webapp.Models.Pie", b =>
                {
                    b.HasOne("Aspnetcore.Pieshop.Webapp.Models.Category", "Category")
                        .WithMany("Pies")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
