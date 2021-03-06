﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using YourDailyWord.Data;

namespace YourDailyWord.Data.Migrations
{
    [DbContext(typeof(YourDailyWordDbContext))]
    [Migration("20180423202936_Third Migration")]
    partial class ThirdMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("YourDailyWord.Data.Models.WordGallery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("Description1");

                    b.Property<string>("Description2");

                    b.Property<string>("Description3");

                    b.Property<string>("IndexUrl");

                    b.Property<string>("Title");

                    b.Property<string>("Url");

                    b.Property<string>("Verse1");

                    b.Property<string>("Verse2");

                    b.Property<string>("Verse3");

                    b.HasKey("Id");

                    b.ToTable("WordGalleries");
                });

            modelBuilder.Entity("YourDailyWord.Data.Models.WordTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<int?>("WordGalleryId");

                    b.HasKey("Id");

                    b.HasIndex("WordGalleryId");

                    b.ToTable("WordTags");
                });

            modelBuilder.Entity("YourDailyWord.Data.Models.WordTag", b =>
                {
                    b.HasOne("YourDailyWord.Data.Models.WordGallery")
                        .WithMany("Tags")
                        .HasForeignKey("WordGalleryId");
                });
#pragma warning restore 612, 618
        }
    }
}
