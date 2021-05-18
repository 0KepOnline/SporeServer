﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SporeServer.Data;

namespace SporeServer.Migrations
{
    [DbContext(typeof(SporeServerContext))]
    partial class SporeServerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.6");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<long>", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<long>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<long>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<long>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<long>", b =>
                {
                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<long>", b =>
                {
                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("SporeServer.Areas.Identity.Data.SporeServerAggregator", b =>
                {
                    b.Property<long>("AggregatorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("AuthorId")
                        .HasColumnType("bigint");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int>("SubscriberCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime(6)");

                    b.HasKey("AggregatorId");

                    b.HasIndex("AuthorId");

                    b.ToTable("Aggregators");
                });

            modelBuilder.Entity("SporeServer.Areas.Identity.Data.SporeServerAggregatorSubscription", b =>
                {
                    b.Property<long>("SubscriptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("AggregatorId")
                        .HasColumnType("bigint");

                    b.Property<long>("AuthorId")
                        .HasColumnType("bigint");

                    b.HasKey("SubscriptionId");

                    b.HasIndex("AggregatorId");

                    b.HasIndex("AuthorId");

                    b.ToTable("AggregatorSubscriptions");
                });

            modelBuilder.Entity("SporeServer.Areas.Identity.Data.SporeServerAsset", b =>
                {
                    b.Property<long>("AssetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("AuthorId")
                        .HasColumnType("bigint");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("ImageFile2Url")
                        .HasColumnType("longtext");

                    b.Property<string>("ImageFile3Url")
                        .HasColumnType("longtext");

                    b.Property<string>("ImageFile4Url")
                        .HasColumnType("longtext");

                    b.Property<string>("ImageFileUrl")
                        .HasColumnType("longtext");

                    b.Property<string>("ModelFileUrl")
                        .HasColumnType("longtext");

                    b.Property<long>("ModelType")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<long>("ParentAssetId")
                        .HasColumnType("bigint");

                    b.Property<long>("Size")
                        .HasColumnType("bigint");

                    b.Property<bool>("Slurped")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Tags")
                        .HasColumnType("longtext");

                    b.Property<string>("ThumbFileUrl")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("Timestamp")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("Type")
                        .HasColumnType("bigint");

                    b.Property<bool>("Used")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("AssetId");

                    b.HasIndex("AuthorId");

                    b.ToTable("Assets");

                    b.HasData(
                        new
                        {
                            AssetId = 600000000000L,
                            AuthorId = 1L,
                            ModelType = 0L,
                            ParentAssetId = 0L,
                            Size = 0L,
                            Slurped = false,
                            Type = 0L,
                            Used = false
                        });
                });

            modelBuilder.Entity("SporeServer.Areas.Identity.Data.SporeServerUnlockedAchievement", b =>
                {
                    b.Property<long>("UnlockedAchievementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("AchievementId")
                        .HasColumnType("bigint");

                    b.Property<long>("AuthorId")
                        .HasColumnType("bigint");

                    b.HasKey("UnlockedAchievementId");

                    b.HasIndex("AuthorId");

                    b.ToTable("UnlockedAchievements");
                });

            modelBuilder.Entity("SporeServer.Areas.Identity.Data.SporeServerUser", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("NextAssetId")
                        .HasColumnType("bigint");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0bb7a089-fb1a-4d8a-9369-73d3eca4a6d1",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NextAssetId = 0L,
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false
                        });
                });

            modelBuilder.Entity("SporeServer.Areas.Identity.Data.SporeServerUserSubscription", b =>
                {
                    b.Property<long>("SubscriptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("AuthorId")
                        .HasColumnType("bigint");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("SubscriptionId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("UserId");

                    b.ToTable("UserSubscriptions");
                });

            modelBuilder.Entity("SporeServerAggregatorSporeServerAsset", b =>
                {
                    b.Property<long>("AggregatorsAggregatorId")
                        .HasColumnType("bigint");

                    b.Property<long>("AssetsAssetId")
                        .HasColumnType("bigint");

                    b.HasKey("AggregatorsAggregatorId", "AssetsAssetId");

                    b.HasIndex("AssetsAssetId");

                    b.ToTable("SporeServerAggregatorSporeServerAsset");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<long>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<long>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<long>", b =>
                {
                    b.HasOne("SporeServer.Areas.Identity.Data.SporeServerUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<long>", b =>
                {
                    b.HasOne("SporeServer.Areas.Identity.Data.SporeServerUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<long>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<long>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SporeServer.Areas.Identity.Data.SporeServerUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<long>", b =>
                {
                    b.HasOne("SporeServer.Areas.Identity.Data.SporeServerUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SporeServer.Areas.Identity.Data.SporeServerAggregator", b =>
                {
                    b.HasOne("SporeServer.Areas.Identity.Data.SporeServerUser", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("SporeServer.Areas.Identity.Data.SporeServerAggregatorSubscription", b =>
                {
                    b.HasOne("SporeServer.Areas.Identity.Data.SporeServerAggregator", "Aggregator")
                        .WithMany()
                        .HasForeignKey("AggregatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SporeServer.Areas.Identity.Data.SporeServerUser", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aggregator");

                    b.Navigation("Author");
                });

            modelBuilder.Entity("SporeServer.Areas.Identity.Data.SporeServerAsset", b =>
                {
                    b.HasOne("SporeServer.Areas.Identity.Data.SporeServerUser", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("SporeServer.Areas.Identity.Data.SporeServerUnlockedAchievement", b =>
                {
                    b.HasOne("SporeServer.Areas.Identity.Data.SporeServerUser", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("SporeServer.Areas.Identity.Data.SporeServerUserSubscription", b =>
                {
                    b.HasOne("SporeServer.Areas.Identity.Data.SporeServerUser", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SporeServer.Areas.Identity.Data.SporeServerUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SporeServerAggregatorSporeServerAsset", b =>
                {
                    b.HasOne("SporeServer.Areas.Identity.Data.SporeServerAggregator", null)
                        .WithMany()
                        .HasForeignKey("AggregatorsAggregatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SporeServer.Areas.Identity.Data.SporeServerAsset", null)
                        .WithMany()
                        .HasForeignKey("AssetsAssetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
