﻿// <auto-generated />
using BookStore.Domain.DAL;
using BookStore.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace BookStore.Migrations
{
    [DbContext(typeof(BookStoreContext))]
    partial class BookStoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("BookStore.Domain.Models.ActionLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BookEditionId");

                    b.Property<int>("CheckinPoint");

                    b.Property<int>("CheckinTotalPoint");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("PushEmail");

                    b.Property<string>("PushFromPlatform");

                    b.Property<int>("PushStatus");

                    b.Property<int>("PushUseTime");

                    b.Property<int>("Taxonomy");

                    b.Property<string>("UserAgent");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("BookEditionId");

                    b.HasIndex("UserId");

                    b.ToTable("action_logs");
                });

            modelBuilder.Entity("BookStore.Domain.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author")
                        .HasMaxLength(500);

                    b.Property<string>("AuthorIntroduction");

                    b.Property<string>("BookCatelog");

                    b.Property<DateTime>("CreateTime");

                    b.Property<int>("DoubanId");

                    b.Property<int>("DoubanRatingPeople");

                    b.Property<float>("DoubanRatingScore");

                    b.Property<string>("DoubanUrl");

                    b.Property<string>("Introduction");

                    b.Property<int>("IsDelete");

                    b.Property<string>("Isbn")
                        .HasMaxLength(100);

                    b.Property<string>("Logo")
                        .HasMaxLength(500);

                    b.Property<string>("Publisher")
                        .HasMaxLength(500);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("Translator")
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.ToTable("books");
                });

            modelBuilder.Entity("BookStore.Domain.Models.BookEdition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BookId");

                    b.Property<string>("CheckSum")
                        .HasMaxLength(2000);

                    b.Property<DateTime>("CreateTime");

                    b.Property<int>("DownloadCount");

                    b.Property<int>("FavoriteCount");

                    b.Property<string>("Filename")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<long>("Filesize");

                    b.Property<string>("Hashcode");

                    b.Property<string>("OriginalFilename")
                        .HasMaxLength(500);

                    b.Property<int>("PushCount");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("book_editions");
                });

            modelBuilder.Entity("BookStore.Domain.Models.BookEditionComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AtUserId");

                    b.Property<int?>("BookEditionId");

                    b.Property<string>("Comment");

                    b.Property<DateTime>("CreateTime");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("AtUserId");

                    b.HasIndex("BookEditionId");

                    b.HasIndex("UserId");

                    b.ToTable("book_edition_comments");
                });

            modelBuilder.Entity("BookStore.Domain.Models.BookTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BookId");

                    b.Property<int>("TagId");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("TagId");

                    b.ToTable("book_tag");
                });

            modelBuilder.Entity("BookStore.Domain.Models.PushSetting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CreateTime");

                    b.Property<int>("IsDefault");

                    b.Property<string>("PushEmail")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("push_settings");
                });

            modelBuilder.Entity("BookStore.Domain.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.ToTable("tags");
                });

            modelBuilder.Entity("BookStore.Domain.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Avatar")
                        .HasMaxLength(2000);

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("Email")
                        .HasMaxLength(500);

                    b.Property<int>("IsDelete");

                    b.Property<int>("LoginCount");

                    b.Property<string>("LoginIp")
                        .HasMaxLength(100);

                    b.Property<DateTime>("LoginTime");

                    b.Property<string>("Password")
                        .HasMaxLength(2000);

                    b.Property<int>("PointCount");

                    b.Property<int>("UserType");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.ToTable("users");
                });

            modelBuilder.Entity("BookStore.Domain.Models.UserPointLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ActionLogId");

                    b.Property<DateTime>("CreateTime");

                    b.Property<int>("Point");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ActionLogId");

                    b.HasIndex("UserId");

                    b.ToTable("user_point_logs");
                });

            modelBuilder.Entity("BookStore.Domain.Models.ActionLog", b =>
                {
                    b.HasOne("BookStore.Domain.Models.BookEdition", "BookEdition")
                        .WithMany()
                        .HasForeignKey("BookEditionId");

                    b.HasOne("BookStore.Domain.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("BookStore.Domain.Models.BookEdition", b =>
                {
                    b.HasOne("BookStore.Domain.Models.Book", "Book")
                        .WithMany("BookEditions")
                        .HasForeignKey("BookId");

                    b.HasOne("BookStore.Domain.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("BookStore.Domain.Models.BookEditionComment", b =>
                {
                    b.HasOne("BookStore.Domain.Models.User", "AtUser")
                        .WithMany()
                        .HasForeignKey("AtUserId");

                    b.HasOne("BookStore.Domain.Models.BookEdition", "BookEdition")
                        .WithMany("BookEditionComments")
                        .HasForeignKey("BookEditionId");

                    b.HasOne("BookStore.Domain.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("BookStore.Domain.Models.BookTag", b =>
                {
                    b.HasOne("BookStore.Domain.Models.Book", "Book")
                        .WithMany("BookTags")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("BookStore.Domain.Models.Tag", "Tag")
                        .WithMany("BookTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("BookStore.Domain.Models.PushSetting", b =>
                {
                    b.HasOne("BookStore.Domain.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("BookStore.Domain.Models.UserPointLog", b =>
                {
                    b.HasOne("BookStore.Domain.Models.ActionLog", "ActionLog")
                        .WithMany()
                        .HasForeignKey("ActionLogId");

                    b.HasOne("BookStore.Domain.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
