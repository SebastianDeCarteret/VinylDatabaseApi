﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VinylDatabaseApi.Data;

#nullable disable

namespace VinylDatabaseApi.Migrations
{
    [DbContext(typeof(VinylDatabaseApiContext))]
    [Migration("20231206100017_UpdateVinylToNullable")]
    partial class UpdateVinylToNullable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("VinylDatabaseApi.Models.Track", b =>
                {
                    b.Property<int>("TrackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TrackId"));

                    b.Property<float>("Length")
                        .HasColumnType("real");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VinylId")
                        .HasColumnType("int");

                    b.HasKey("TrackId");

                    b.HasIndex("VinylId");

                    b.ToTable("Track");
                });

            modelBuilder.Entity("VinylDatabaseApi.Models.Vinyl", b =>
                {
                    b.Property<int>("VinylId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VinylId"));

                    b.Property<string>("Artist")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfLps")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfTracks")
                        .HasColumnType("int");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VinylId");

                    b.ToTable("Vinyl");

                    b.HasData(
                        new
                        {
                            VinylId = 1,
                            Artist = "Bon Jovi",
                            ImageLink = "Link",
                            NumberOfLps = 2,
                            NumberOfTracks = 16,
                            Price = 39.99f,
                            ReleaseDate = new DateTime(1982, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Slippery When Wet"
                        });
                });

            modelBuilder.Entity("VinylDatabaseApi.Models.Track", b =>
                {
                    b.HasOne("VinylDatabaseApi.Models.Vinyl", "Vinyl")
                        .WithMany("Tracks")
                        .HasForeignKey("VinylId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vinyl");
                });

            modelBuilder.Entity("VinylDatabaseApi.Models.Vinyl", b =>
                {
                    b.Navigation("Tracks");
                });
#pragma warning restore 612, 618
        }
    }
}
