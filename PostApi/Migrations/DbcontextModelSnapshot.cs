﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PostApi.DataAccessLayer;

namespace PostApi.Migrations
{
    [DbContext(typeof(Dbcontext))]
    partial class DbcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PostApi.DataAccessLayer.FoodPost", b =>
                {
                    b.Property<int>("FoodPostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FPostDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("FPostStatus")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FPosttDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FoodPostTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Postid")
                        .HasColumnType("int");

                    b.HasKey("FoodPostId");

                    b.HasIndex("Postid");

                    b.ToTable("FoodPostDbSet");
                });

            modelBuilder.Entity("PostApi.DataAccessLayer.Post", b =>
                {
                    b.Property<int>("postId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("User")
                        .HasColumnType("int");

                    b.Property<DateTime>("postDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("postDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("postImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("postStatus")
                        .HasColumnType("bit");

                    b.Property<string>("postTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("postId");

                    b.ToTable("PostDbSet");
                });

            modelBuilder.Entity("PostApi.DataAccessLayer.FoodPost", b =>
                {
                    b.HasOne("PostApi.DataAccessLayer.Post", "Post")
                        .WithMany("FPost")
                        .HasForeignKey("Postid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");
                });

            modelBuilder.Entity("PostApi.DataAccessLayer.Post", b =>
                {
                    b.Navigation("FPost");
                });
#pragma warning restore 612, 618
        }
    }
}