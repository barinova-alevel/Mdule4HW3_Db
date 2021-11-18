﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MySolution.DataAccess;

namespace MySolution.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20211118081815_RenameDBSet")]
    partial class RenameDBSet
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MySolution.DataAccess.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("First Name");

                    b.Property<DateTime>("FirstOrder")
                        .HasColumnType("datetime2")
                        .HasColumnName("ClientSince");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("LastName");

                    b.HasKey("Id");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "mail1@mail.se",
                            FirstName = "Client1",
                            FirstOrder = new DateTime(2020, 5, 9, 9, 15, 0, 0, DateTimeKind.Unspecified),
                            LastName = "LastNameClient 2"
                        },
                        new
                        {
                            Id = 2,
                            Email = "mail2@mail.se",
                            FirstName = "Client2",
                            FirstOrder = new DateTime(2020, 5, 9, 9, 15, 0, 0, DateTimeKind.Unspecified),
                            LastName = "LastNameClient 2"
                        },
                        new
                        {
                            Id = 3,
                            Email = "mail3@mail.se",
                            FirstName = "Client3",
                            FirstOrder = new DateTime(2020, 5, 9, 9, 15, 0, 0, DateTimeKind.Unspecified),
                            LastName = "LastNameClient 2"
                        },
                        new
                        {
                            Id = 4,
                            Email = "mail4@mail.se",
                            FirstName = "Client4",
                            FirstOrder = new DateTime(2020, 5, 9, 9, 15, 0, 0, DateTimeKind.Unspecified),
                            LastName = "LastNameClient 2"
                        },
                        new
                        {
                            Id = 5,
                            Email = "mail5@mail.se",
                            FirstName = "Client5",
                            FirstOrder = new DateTime(2020, 5, 9, 9, 15, 0, 0, DateTimeKind.Unspecified),
                            LastName = "LastNameClient 2"
                        });
                });

            modelBuilder.Entity("MySolution.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2")
                        .HasColumnName("DateOfBirdth");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("First Name");

                    b.Property<DateTime>("HiredDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("HiredDate");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("LastName");

                    b.Property<int>("OfficeId")
                        .HasColumnType("int")
                        .HasColumnName("OfficeId");

                    b.Property<int?>("ProjectId")
                        .HasColumnType("int");

                    b.Property<int>("TitleId")
                        .HasColumnType("int")
                        .HasColumnName("TitleId");

                    b.HasKey("Id");

                    b.HasIndex("OfficeId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("TitleId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfBirth = new DateTime(2000, 5, 9, 9, 15, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Aaron",
                            HiredDate = new DateTime(2021, 5, 9, 9, 15, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Aronson",
                            OfficeId = 1,
                            TitleId = 1
                        },
                        new
                        {
                            Id = 2,
                            DateOfBirth = new DateTime(2000, 5, 9, 9, 15, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Adam",
                            HiredDate = new DateTime(2021, 5, 9, 9, 15, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Adamson",
                            OfficeId = 1,
                            TitleId = 1
                        },
                        new
                        {
                            Id = 3,
                            DateOfBirth = new DateTime(2000, 5, 9, 9, 15, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Devid",
                            HiredDate = new DateTime(2021, 5, 9, 9, 15, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Devidson",
                            OfficeId = 2,
                            TitleId = 1
                        },
                        new
                        {
                            Id = 4,
                            DateOfBirth = new DateTime(2000, 5, 9, 9, 15, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Kevin",
                            HiredDate = new DateTime(2021, 5, 9, 9, 15, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Aronson",
                            OfficeId = 1,
                            TitleId = 1
                        });
                });

            modelBuilder.Entity("MySolution.EmployeeProject", b =>
                {
                    b.Property<int>("EmployeeProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("EmployeeProjectId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int")
                        .HasColumnName("EmployeeId");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int")
                        .HasColumnName("ProjectId");

                    b.Property<decimal>("Rate")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("Rate");

                    b.Property<DateTime>("StartedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("StartedDate");

                    b.HasKey("EmployeeProjectId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ProjectId");

                    b.ToTable("EmployeeProject");

                    b.HasData(
                        new
                        {
                            EmployeeProjectId = 1,
                            EmployeeId = 1,
                            ProjectId = 1,
                            Rate = 25m,
                            StartedDate = new DateTime(2019, 5, 9, 9, 15, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            EmployeeProjectId = 2,
                            EmployeeId = 1,
                            ProjectId = 1,
                            Rate = 15m,
                            StartedDate = new DateTime(2016, 5, 9, 9, 15, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            EmployeeProjectId = 3,
                            EmployeeId = 1,
                            ProjectId = 1,
                            Rate = 250m,
                            StartedDate = new DateTime(2018, 5, 9, 9, 15, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("MySolution.Office", b =>
                {
                    b.Property<int>("OfficeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("OfficeId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Location");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Title");

                    b.HasKey("OfficeId");

                    b.ToTable("Office");

                    b.HasData(
                        new
                        {
                            OfficeId = 1,
                            Location = "Address 1",
                            Title = "CityOffice"
                        },
                        new
                        {
                            OfficeId = 2,
                            Location = "Address 2",
                            Title = "CountrySideOffice"
                        },
                        new
                        {
                            OfficeId = 3,
                            Location = "Address 3",
                            Title = "OneMoreCountrySideOffice"
                        });
                });

            modelBuilder.Entity("MySolution.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ProjectId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Budget")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("Budget");

                    b.Property<int>("ClientId")
                        .HasColumnType("int")
                        .HasColumnName("ClientId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Name");

                    b.Property<DateTime>("StartedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("StartedDate");

                    b.HasKey("ProjectId");

                    b.HasIndex("ClientId");

                    b.ToTable("Project");

                    b.HasData(
                        new
                        {
                            ProjectId = 1,
                            Budget = 1005.5m,
                            ClientId = 2,
                            Name = "Project1",
                            StartedDate = new DateTime(2019, 5, 9, 9, 15, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ProjectId = 2,
                            Budget = 20000.5m,
                            ClientId = 2,
                            Name = "Project2",
                            StartedDate = new DateTime(2021, 5, 9, 9, 15, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ProjectId = 3,
                            Budget = 4000m,
                            ClientId = 2,
                            Name = "Project3",
                            StartedDate = new DateTime(2018, 7, 10, 10, 25, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ProjectId = 4,
                            Budget = 3500m,
                            ClientId = 1,
                            Name = "Project4",
                            StartedDate = new DateTime(2018, 7, 10, 10, 25, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ProjectId = 5,
                            Budget = 8700m,
                            ClientId = 3,
                            Name = "Project5",
                            StartedDate = new DateTime(2019, 6, 10, 10, 25, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("MySolution.Title", b =>
                {
                    b.Property<int>("TitleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("TitleId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Name");

                    b.HasKey("TitleId");

                    b.ToTable("Title");

                    b.HasData(
                        new
                        {
                            TitleId = 1,
                            Name = "Title1"
                        },
                        new
                        {
                            TitleId = 2,
                            Name = "Title2"
                        },
                        new
                        {
                            TitleId = 3,
                            Name = "Title3"
                        });
                });

            modelBuilder.Entity("MySolution.Employee", b =>
                {
                    b.HasOne("MySolution.Office", "Office")
                        .WithMany("Employees")
                        .HasForeignKey("OfficeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MySolution.Project", null)
                        .WithMany("Employees")
                        .HasForeignKey("ProjectId");

                    b.HasOne("MySolution.Title", "Title")
                        .WithMany("employees")
                        .HasForeignKey("TitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Office");

                    b.Navigation("Title");
                });

            modelBuilder.Entity("MySolution.EmployeeProject", b =>
                {
                    b.HasOne("MySolution.Employee", "Employee")
                        .WithMany("EmployeeProjects")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MySolution.Project", "Project")
                        .WithMany("EmployeeProjects")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("MySolution.Project", b =>
                {
                    b.HasOne("MySolution.DataAccess.Models.Client", "Client")
                        .WithMany("Projects")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("MySolution.DataAccess.Models.Client", b =>
                {
                    b.Navigation("Projects");
                });

            modelBuilder.Entity("MySolution.Employee", b =>
                {
                    b.Navigation("EmployeeProjects");
                });

            modelBuilder.Entity("MySolution.Office", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("MySolution.Project", b =>
                {
                    b.Navigation("EmployeeProjects");

                    b.Navigation("Employees");
                });

            modelBuilder.Entity("MySolution.Title", b =>
                {
                    b.Navigation("employees");
                });
#pragma warning restore 612, 618
        }
    }
}
