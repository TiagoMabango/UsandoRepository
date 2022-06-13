﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Xyami.Core;

namespace Xyami.Core.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220315182125_AddFamily")]
    partial class AddFamily
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Xyami.Core.Entities.Category", b =>
                {
                    b.Property<long>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Designaction")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Xyami.Core.Entities.Family", b =>
                {
                    b.Property<long>("FamileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CategoryId")
                        .HasColumnType("bigint");

                    b.Property<string>("Designaction")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FamileId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Families");
                });

            modelBuilder.Entity("Xyami.Core.Entities.Family", b =>
                {
                    b.HasOne("Xyami.Core.Entities.Category", "Category")
                        .WithMany("Families")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Xyami.Core.Entities.Category", b =>
                {
                    b.Navigation("Families");
                });
#pragma warning restore 612, 618
        }
    }
}
