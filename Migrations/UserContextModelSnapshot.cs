﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dnd.Models.User;

namespace dnd.Migrations
{
    [DbContext(typeof(UserContext))]
    partial class UserContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("dnd.Models.Chapter7Assignment.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AccessLevel")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Grade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessLevel = 10,
                            FirstName = "Nicholas",
                            Grade = "A",
                            LastName = "Lanes"
                        },
                        new
                        {
                            Id = 2,
                            AccessLevel = 8,
                            FirstName = "James",
                            Grade = "B",
                            LastName = "Smith"
                        },
                        new
                        {
                            Id = 3,
                            AccessLevel = 5,
                            FirstName = "John",
                            Grade = "C",
                            LastName = "Smith"
                        },
                        new
                        {
                            Id = 4,
                            AccessLevel = 1,
                            FirstName = "Sebastian",
                            Grade = "A",
                            LastName = "Bach"
                        },
                        new
                        {
                            Id = 5,
                            AccessLevel = 2,
                            FirstName = "Samuel",
                            Grade = "B",
                            LastName = "Jackson"
                        });
                });

            modelBuilder.Entity("dnd.Models.User.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Grade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Email = "email@test.com",
                            FirstName = "Nicholas",
                            Grade = "A",
                            LastName = "Lanes",
                            Password = "pass"
                        },
                        new
                        {
                            UserId = 2,
                            Email = "jfranc@gmail.com",
                            FirstName = "James",
                            Grade = "B",
                            LastName = "Franco",
                            Password = "francooo"
                        },
                        new
                        {
                            UserId = 3,
                            Email = "itsamemike@aol.com",
                            FirstName = "Michael",
                            Grade = "D",
                            LastName = "Scarn",
                            Password = "dementors"
                        },
                        new
                        {
                            UserId = 4,
                            Email = "dangitbobby@stricklandpropane.org",
                            FirstName = "Hank",
                            Grade = "A",
                            LastName = "Hill",
                            Password = "charcoal"
                        },
                        new
                        {
                            UserId = 5,
                            Email = "crowley1@gmail.com",
                            FirstName = "Sebastian",
                            Grade = "C+",
                            LastName = "Crowley",
                            Password = "crowdown"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}