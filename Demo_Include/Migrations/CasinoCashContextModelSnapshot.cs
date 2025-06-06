﻿// <auto-generated />
using Demo_Include;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Demo_Include.Migrations
{
    [DbContext(typeof(CasinoCashContext))]
    partial class CasinoCashContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Demo_Include.Member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DiscountSettingId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Members");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DiscountSettingId = 100,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            DiscountSettingId = 200,
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            DiscountSettingId = 300,
                            UserId = 3
                        });
                });

            modelBuilder.Entity("Demo_Include.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Account")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Account = "user1"
                        },
                        new
                        {
                            Id = 2,
                            Account = "user2"
                        },
                        new
                        {
                            Id = 3,
                            Account = "user3"
                        });
                });

            modelBuilder.Entity("Demo_Include.Member", b =>
                {
                    b.HasOne("Demo_Include.User", "User")
                        .WithOne("Member")
                        .HasForeignKey("Demo_Include.Member", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Demo_Include.User", b =>
                {
                    b.Navigation("Member")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
