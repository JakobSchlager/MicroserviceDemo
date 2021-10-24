﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TicketDbLib;

namespace TicketDbLib.Migrations
{
    [DbContext(typeof(TicketDbContext))]
    [Migration("20211024121300_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("TicketDbLib.Entities.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CustomerName")
                        .HasColumnType("longtext");

                    b.Property<int>("PresentationId")
                        .HasColumnType("int");

                    b.Property<int>("SeatId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ticket");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerName = "Jakob Schlager",
                            PresentationId = 1,
                            SeatId = 15
                        },
                        new
                        {
                            Id = 2,
                            CustomerName = "Thomas Wahlmüller",
                            PresentationId = 1,
                            SeatId = 18
                        },
                        new
                        {
                            Id = 3,
                            CustomerName = "Florian Auer",
                            PresentationId = 2,
                            SeatId = 30
                        },
                        new
                        {
                            Id = 4,
                            CustomerName = "Fabian Graml",
                            PresentationId = 2,
                            SeatId = 31
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
