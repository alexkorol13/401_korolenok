﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RecognitionApp;

namespace RecognitionApp.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20220213193314_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.12");

            modelBuilder.Entity("RecognitionApp.Image", b =>
                {
                    b.Property<int>("ImageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ImageHash")
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("image")
                        .HasColumnType("BLOB");

                    b.HasKey("ImageID");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("RecognitionApp.RecognitionObject", b =>
                {
                    b.Property<int>("RecognitionObjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ImageID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("type")
                        .HasColumnType("TEXT");

                    b.Property<int>("x0")
                        .HasColumnType("INTEGER");

                    b.Property<int>("x1")
                        .HasColumnType("INTEGER");

                    b.Property<int>("y0")
                        .HasColumnType("INTEGER");

                    b.Property<int>("y1")
                        .HasColumnType("INTEGER");

                    b.HasKey("RecognitionObjectID");

                    b.HasIndex("ImageID");

                    b.ToTable("Objects");
                });

            modelBuilder.Entity("RecognitionApp.RecognitionObject", b =>
                {
                    b.HasOne("RecognitionApp.Image", null)
                        .WithMany("objects")
                        .HasForeignKey("ImageID");
                });

            modelBuilder.Entity("RecognitionApp.Image", b =>
                {
                    b.Navigation("objects");
                });
#pragma warning restore 612, 618
        }
    }
}
