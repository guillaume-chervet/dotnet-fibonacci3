﻿// <auto-generated />
using System;
using Leonardo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Leonardo.Migrations
{
    [DbContext(typeof(FibonacciDataContext))]
    partial class FibonacciDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Leonardo.TFibonacci", b =>
                {
                    b.Property<Guid>("FibId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("FIB_Id")
                        .HasDefaultValueSql("(newid())");

                    b.Property<DateTime>("FibCreatedTimestamp")
                        .HasColumnType("datetime2")
                        .HasColumnName("FIB_CreatedTimestamp");

                    b.Property<int>("FibInput")
                        .HasColumnType("int")
                        .HasColumnName("FIB_Input");

                    b.Property<long>("FibOutput")
                        .HasColumnType("bigint")
                        .HasColumnName("FIB_Output");

                    b.HasKey("FibId")
                        .HasName("PK_Fibonacci");

                    b.ToTable("T_Fibonacci", "sch_fib");
                });
#pragma warning restore 612, 618
        }
    }
}
