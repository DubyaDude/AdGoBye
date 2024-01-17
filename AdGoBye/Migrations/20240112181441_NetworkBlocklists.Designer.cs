﻿// <auto-generated />
using AdGoBye;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AdGoBye.Migrations
{
    [DbContext(typeof(State.IndexContext))]
    [Migration("20240112181441_NetworkBlocklists")]
    partial class NetworkBlocklists
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("AdGoBye.Blocklist+NetworkBlocklist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Contents")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ETag")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("NetworkBlocklists");
                });

            modelBuilder.Entity("AdGoBye.Content", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("StableContentName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VersionMetaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("VersionMetaId");

                    b.ToTable("Content");
                });

            modelBuilder.Entity("AdGoBye.Content+ContentVersionMeta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("PatchedBy")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Version")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("ContentVersionMetas");
                });

            modelBuilder.Entity("AdGoBye.Content", b =>
                {
                    b.HasOne("AdGoBye.Content+ContentVersionMeta", "VersionMeta")
                        .WithMany()
                        .HasForeignKey("VersionMetaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VersionMeta");
                });
#pragma warning restore 612, 618
        }
    }
}
