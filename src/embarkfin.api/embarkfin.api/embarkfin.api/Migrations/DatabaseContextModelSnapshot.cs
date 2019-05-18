﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using embarkfin.api.Models.Database;

namespace embarkfin.api.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("embarkfin.api.Models.Assets.AssetEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at");

                    b.Property<DateTime>("Date_Purchased")
                        .HasColumnName("Date_Purchased");

                    b.Property<int>("DisposalId")
                        .HasColumnName("DisposalId");

                    b.Property<int>("LocationId")
                        .HasColumnName("LocationId");

                    b.Property<long>("Period")
                        .HasColumnName("Period");

                    b.Property<double>("Purchase_Price")
                        .HasColumnName("Purchase_Price");

                    b.Property<string>("Serial_Number")
                        .HasColumnName("Serial_Number");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("DisposalId");

                    b.HasIndex("LocationId");

                    b.ToTable("Asset");
                });

            modelBuilder.Entity("embarkfin.api.Models.Assets.DisposalEntity", b =>
                {
                    b.Property<int>("DisposalEntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("DisposalId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DisposedDate")
                        .HasColumnName("Disposed_Date");

                    b.Property<double>("DisposedPrice")
                        .HasColumnName("Disposal_Price");

                    b.HasKey("DisposalEntityId");

                    b.ToTable("Disposal");
                });

            modelBuilder.Entity("embarkfin.api.Models.Assets.LocationEntity", b =>
                {
                    b.Property<int>("LocationEntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("LocationId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCaptured")
                        .HasColumnName("Date_Captured");

                    b.Property<long>("Latitude")
                        .HasColumnName("Latitude");

                    b.Property<long>("Longitude")
                        .HasColumnName("Longitude");

                    b.HasKey("LocationEntityId");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("embarkfin.api.Models.Login.LoginEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at");

                    b.Property<string>("Password")
                        .HasColumnName("Password");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnName("updated_at");

                    b.Property<string>("User_Name")
                        .HasColumnName("User_Name");

                    b.HasKey("Id");

                    b.ToTable("Login");
                });

            modelBuilder.Entity("embarkfin.api.Models.Assets.AssetEntity", b =>
                {
                    b.HasOne("embarkfin.api.Models.Assets.LocationEntity", "location")
                        .WithMany()
                        .HasForeignKey("DisposalId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("embarkfin.api.Models.Assets.DisposalEntity", "disposal")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
