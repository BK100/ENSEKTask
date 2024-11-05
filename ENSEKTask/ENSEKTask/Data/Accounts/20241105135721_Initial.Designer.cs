﻿// <auto-generated />
using ENSEKTask.Data.Accounts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ENSEKTask.Data.Accounts
{
    [DbContext(typeof(AccountsDbContext))]
    [Migration("20241105135721_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("ENSEKTask.Models.Account", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AccountId");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            AccountId = 2344,
                            FirstName = "Tommy",
                            LastName = "Test"
                        },
                        new
                        {
                            AccountId = 2233,
                            FirstName = "Barry",
                            LastName = "Test"
                        },
                        new
                        {
                            AccountId = 8766,
                            FirstName = "Sally",
                            LastName = "Test"
                        },
                        new
                        {
                            AccountId = 2345,
                            FirstName = "Jerry",
                            LastName = "Test"
                        },
                        new
                        {
                            AccountId = 2346,
                            FirstName = "Ollie",
                            LastName = "Test"
                        },
                        new
                        {
                            AccountId = 2347,
                            FirstName = "Tara",
                            LastName = "Test"
                        },
                        new
                        {
                            AccountId = 2348,
                            FirstName = "Tammmy",
                            LastName = "Test"
                        },
                        new
                        {
                            AccountId = 2349,
                            FirstName = "Simon",
                            LastName = "Test"
                        },
                        new
                        {
                            AccountId = 2350,
                            FirstName = "Colin",
                            LastName = "Test"
                        },
                        new
                        {
                            AccountId = 2351,
                            FirstName = "Gladys",
                            LastName = "Test"
                        },
                        new
                        {
                            AccountId = 2352,
                            FirstName = "Greg",
                            LastName = "Test"
                        },
                        new
                        {
                            AccountId = 2353,
                            FirstName = "Tony",
                            LastName = "Test"
                        },
                        new
                        {
                            AccountId = 2355,
                            FirstName = "Arthur",
                            LastName = "Test"
                        },
                        new
                        {
                            AccountId = 2356,
                            FirstName = "Craig",
                            LastName = "Test"
                        },
                        new
                        {
                            AccountId = 6776,
                            FirstName = "Laura",
                            LastName = "Test"
                        },
                        new
                        {
                            AccountId = 4534,
                            FirstName = "JOSH",
                            LastName = "TEST"
                        },
                        new
                        {
                            AccountId = 1234,
                            FirstName = "Freya",
                            LastName = "Test"
                        },
                        new
                        {
                            AccountId = 1239,
                            FirstName = "Noddy",
                            LastName = "Test"
                        },
                        new
                        {
                            AccountId = 1240,
                            FirstName = "Archie",
                            LastName = "Test"
                        },
                        new
                        {
                            AccountId = 1241,
                            FirstName = "Lara",
                            LastName = "Test"
                        },
                        new
                        {
                            AccountId = 1242,
                            FirstName = "Tim",
                            LastName = "Test"
                        },
                        new
                        {
                            AccountId = 1243,
                            FirstName = "Graham",
                            LastName = "Test"
                        },
                        new
                        {
                            AccountId = 1244,
                            FirstName = "Tony",
                            LastName = "Test"
                        },
                        new
                        {
                            AccountId = 1245,
                            FirstName = "Neville",
                            LastName = "Test"
                        },
                        new
                        {
                            AccountId = 1246,
                            FirstName = "Jo",
                            LastName = "Test"
                        },
                        new
                        {
                            AccountId = 1247,
                            FirstName = "Jim",
                            LastName = "Test"
                        },
                        new
                        {
                            AccountId = 1248,
                            FirstName = "Pam",
                            LastName = "Test"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
