﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using webapi_day3.DatabaseHelper;

namespace webapi_day3.Migrations
{
    [DbContext(typeof(TodoContext))]
    partial class TodoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("webapi_day3.DatabaseHelper.ToDo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<bool>("IsComplete");

                    b.HasKey("Id");

                    b.ToTable("ToDos");

                    b.HasData(
                        new { Id = 1, Description = "Clean house", IsComplete = false },
                        new { Id = 2, Description = "Bake cake", IsComplete = false }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
