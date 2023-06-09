﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApp.Context;

namespace WebApp.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20230416095606_AddSeedDataUpdate")]
    partial class AddSeedDataUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApp.Models.AppUser", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreatedDate = new DateTime(2023, 4, 16, 12, 56, 5, 209, DateTimeKind.Local).AddTicks(3081),
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Password = "$2a$11$qgoZKieJdal2rgIUCtsoXuT7hCCu55Z38N7mCz.43ZVp/tz573JmK",
                            Role = 1,
                            Status = 0,
                            UserName = "administrator"
                        },
                        new
                        {
                            ID = 2,
                            CreatedDate = new DateTime(2023, 4, 16, 12, 56, 5, 214, DateTimeKind.Local).AddTicks(1400),
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Password = "$2a$11$QfAbWGg.cc5uArZHa3Bt3OWnvQXbgcWF8Kt.FwswFQBF.fTVK7vnm",
                            Role = 2,
                            Status = 0,
                            UserName = "Aslı"
                        });
                });

            modelBuilder.Entity("WebApp.Models.Author", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("WebApp.Models.Book", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorID")
                        .HasColumnType("int");

                    b.Property<int>("BookTypeID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PageCount")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AuthorID");

                    b.HasIndex("BookTypeID");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("WebApp.Models.BookType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("BookTypes");
                });

            modelBuilder.Entity("WebApp.Models.Operation", b =>
                {
                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.Property<int>("BookID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("StudentID", "BookID");

                    b.HasIndex("BookID");

                    b.ToTable("Operations");
                });

            modelBuilder.Entity("WebApp.Models.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreatedDate = new DateTime(2023, 4, 16, 12, 56, 5, 216, DateTimeKind.Local).AddTicks(4898),
                            FirstName = "Avacato",
                            Gender = 0,
                            LastName = "Great",
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 0
                        },
                        new
                        {
                            ID = 2,
                            CreatedDate = new DateTime(2023, 4, 16, 12, 56, 5, 216, DateTimeKind.Local).AddTicks(6551),
                            FirstName = "Mooncake",
                            Gender = 0,
                            LastName = "Green",
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 0
                        },
                        new
                        {
                            ID = 3,
                            CreatedDate = new DateTime(2023, 4, 16, 12, 56, 5, 216, DateTimeKind.Local).AddTicks(6604),
                            FirstName = "Gary",
                            Gender = 0,
                            LastName = "GoodSpeed",
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 0
                        },
                        new
                        {
                            ID = 4,
                            CreatedDate = new DateTime(2023, 4, 16, 12, 56, 5, 216, DateTimeKind.Local).AddTicks(6609),
                            FirstName = "Tribore",
                            Gender = 1,
                            LastName = "Menendez",
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 0
                        });
                });

            modelBuilder.Entity("WebApp.Models.StudentDetail", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SchoolNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("StudentID")
                        .IsUnique();

                    b.ToTable("StudentDetail");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            BirthDay = new DateTime(1987, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedDate = new DateTime(2023, 4, 16, 12, 56, 5, 216, DateTimeKind.Local).AddTicks(7808),
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SchoolNumber = "70",
                            Status = 0,
                            StudentID = 1
                        },
                        new
                        {
                            ID = 2,
                            BirthDay = new DateTime(1989, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedDate = new DateTime(2023, 4, 16, 12, 56, 5, 216, DateTimeKind.Local).AddTicks(9964),
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SchoolNumber = "85",
                            Status = 0,
                            StudentID = 2
                        },
                        new
                        {
                            ID = 3,
                            BirthDay = new DateTime(1986, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedDate = new DateTime(2023, 4, 16, 12, 56, 5, 217, DateTimeKind.Local).AddTicks(26),
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SchoolNumber = "196",
                            Status = 0,
                            StudentID = 3
                        },
                        new
                        {
                            ID = 4,
                            BirthDay = new DateTime(1986, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedDate = new DateTime(2023, 4, 16, 12, 56, 5, 217, DateTimeKind.Local).AddTicks(31),
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SchoolNumber = "317",
                            Status = 0,
                            StudentID = 4
                        });
                });

            modelBuilder.Entity("WebApp.Models.Book", b =>
                {
                    b.HasOne("WebApp.Models.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApp.Models.BookType", "BookType")
                        .WithMany("Books")
                        .HasForeignKey("BookTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApp.Models.Operation", b =>
                {
                    b.HasOne("WebApp.Models.Book", "Book")
                        .WithMany("Operations")
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApp.Models.Student", "Student")
                        .WithMany("Operations")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApp.Models.StudentDetail", b =>
                {
                    b.HasOne("WebApp.Models.Student", "Student")
                        .WithOne("StudentDetail")
                        .HasForeignKey("WebApp.Models.StudentDetail", "StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
