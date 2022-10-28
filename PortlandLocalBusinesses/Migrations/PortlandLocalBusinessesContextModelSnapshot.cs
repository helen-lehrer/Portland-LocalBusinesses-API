﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PortlandLocalBusinesses.Models;

namespace MessageBoard.Migrations
{
    [DbContext(typeof(PortlandLocalBusinessesContext))]
    partial class PortlandLocalBusinessesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("PortlandLocalBusinesses.Models.Business", b =>
                {
                    b.Property<int>("BusinessId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4");

                    b.Property<int>("NeighborhoodId")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("BusinessId");

                    b.HasIndex("NeighborhoodId");

                    b.ToTable("Businesses");

                    b.HasData(
                        new
                        {
                            BusinessId = 1,
                            Description = "Portrait, Branding, and Boudoir Photography",
                            Name = "Abigayle Tarsches Photography",
                            NeighborhoodId = 1,
                            PhoneNumber = "415-609-7914"
                        },
                        new
                        {
                            BusinessId = 2,
                            Description = "Full service bike shop",
                            Name = "Gladys Bikes",
                            NeighborhoodId = 1,
                            PhoneNumber = "971-373-8388"
                        },
                        new
                        {
                            BusinessId = 3,
                            Description = "Women's clothing, costume jewelry, accessories, fashion face mask",
                            Name = "Moods of Florence Italy",
                            NeighborhoodId = 19,
                            PhoneNumber = "503-740-1874"
                        },
                        new
                        {
                            BusinessId = 4,
                            Description = "Local family owned shoe repair in the Hollywood District",
                            Name = "Shoe",
                            NeighborhoodId = 25,
                            PhoneNumber = "503-206-6455"
                        },
                        new
                        {
                            BusinessId = 5,
                            Description = "Your photos printed on Canvas and Fine Art Papers",
                            Name = "Photo to Canvas",
                            NeighborhoodId = 41,
                            PhoneNumber = "503-896-5643"
                        });
                });

            modelBuilder.Entity("PortlandLocalBusinesses.Models.Neighborhood", b =>
                {
                    b.Property<int>("NeighborhoodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4");

                    b.HasKey("NeighborhoodId");

                    b.ToTable("Neighborhoods");

                    b.HasData(
                        new
                        {
                            NeighborhoodId = 1,
                            Name = "Northwest Portland"
                        },
                        new
                        {
                            NeighborhoodId = 2,
                            Name = "Pearl District"
                        },
                        new
                        {
                            NeighborhoodId = 3,
                            Name = "Goose Hollow Foothills League"
                        },
                        new
                        {
                            NeighborhoodId = 4,
                            Name = "Portland Downtown"
                        },
                        new
                        {
                            NeighborhoodId = 5,
                            Name = "Laurelhurst"
                        },
                        new
                        {
                            NeighborhoodId = 6,
                            Name = "Arlington Heights"
                        },
                        new
                        {
                            NeighborhoodId = 7,
                            Name = "Sellwood - Moreland"
                        },
                        new
                        {
                            NeighborhoodId = 8,
                            Name = "Eastmoreland"
                        },
                        new
                        {
                            NeighborhoodId = 9,
                            Name = "Irvington"
                        },
                        new
                        {
                            NeighborhoodId = 10,
                            Name = "Southwest Hills"
                        },
                        new
                        {
                            NeighborhoodId = 11,
                            Name = "Hosford-Abernethy"
                        },
                        new
                        {
                            NeighborhoodId = 12,
                            Name = "Northwest Heights"
                        },
                        new
                        {
                            NeighborhoodId = 13,
                            Name = "Beaumont - Wilshire"
                        },
                        new
                        {
                            NeighborhoodId = 14,
                            Name = "Healy Heights"
                        },
                        new
                        {
                            NeighborhoodId = 15,
                            Name = "Kerns"
                        },
                        new
                        {
                            NeighborhoodId = 16,
                            Name = "South Portland"
                        },
                        new
                        {
                            NeighborhoodId = 17,
                            Name = "Forest Park"
                        },
                        new
                        {
                            NeighborhoodId = 18,
                            Name = "Sylvan - Highlands"
                        },
                        new
                        {
                            NeighborhoodId = 19,
                            Name = "Old Town"
                        },
                        new
                        {
                            NeighborhoodId = 20,
                            Name = "Sullivan's Gulch"
                        },
                        new
                        {
                            NeighborhoodId = 21,
                            Name = "Marshall Park"
                        },
                        new
                        {
                            NeighborhoodId = 22,
                            Name = "Northwest Industrial"
                        },
                        new
                        {
                            NeighborhoodId = 23,
                            Name = "Grant Park"
                        },
                        new
                        {
                            NeighborhoodId = 24,
                            Name = "Northeast Portland"
                        },
                        new
                        {
                            NeighborhoodId = 25,
                            Name = "Hollywood"
                        },
                        new
                        {
                            NeighborhoodId = 26,
                            Name = "Buckman"
                        },
                        new
                        {
                            NeighborhoodId = 27,
                            Name = "Arnold Creek"
                        },
                        new
                        {
                            NeighborhoodId = 28,
                            Name = "Collins View"
                        },
                        new
                        {
                            NeighborhoodId = 29,
                            Name = "South Waterfront"
                        },
                        new
                        {
                            NeighborhoodId = 30,
                            Name = "Mount Tabor"
                        },
                        new
                        {
                            NeighborhoodId = 31,
                            Name = "Multnomah"
                        },
                        new
                        {
                            NeighborhoodId = 32,
                            Name = "Overlook"
                        },
                        new
                        {
                            NeighborhoodId = 33,
                            Name = "Hawthorne"
                        },
                        new
                        {
                            NeighborhoodId = 34,
                            Name = "St.Johns"
                        },
                        new
                        {
                            NeighborhoodId = 35,
                            Name = "Boise"
                        },
                        new
                        {
                            NeighborhoodId = 36,
                            Name = "Central Eastside"
                        },
                        new
                        {
                            NeighborhoodId = 37,
                            Name = "Nob Hill"
                        },
                        new
                        {
                            NeighborhoodId = 38,
                            Name = "Montavilla"
                        },
                        new
                        {
                            NeighborhoodId = 39,
                            Name = "Southeast Portland"
                        },
                        new
                        {
                            NeighborhoodId = 40,
                            Name = "Pleasant Valley"
                        },
                        new
                        {
                            NeighborhoodId = 41,
                            Name = "Lloyd District"
                        },
                        new
                        {
                            NeighborhoodId = 42,
                            Name = "Creston - Kenilworth"
                        },
                        new
                        {
                            NeighborhoodId = 43,
                            Name = "University Park"
                        },
                        new
                        {
                            NeighborhoodId = 44,
                            Name = "Cully"
                        },
                        new
                        {
                            NeighborhoodId = 45,
                            Name = "Southwest Portland"
                        },
                        new
                        {
                            NeighborhoodId = 46,
                            Name = "Sabin"
                        },
                        new
                        {
                            NeighborhoodId = 47,
                            Name = "Alameda"
                        },
                        new
                        {
                            NeighborhoodId = 48,
                            Name = "Richmond"
                        },
                        new
                        {
                            NeighborhoodId = 49,
                            Name = "Sunnyside"
                        },
                        new
                        {
                            NeighborhoodId = 50,
                            Name = "Hillsdale"
                        });
                });

            modelBuilder.Entity("PortlandLocalBusinesses.Models.Business", b =>
                {
                    b.HasOne("PortlandLocalBusinesses.Models.Neighborhood", "Neighborhood")
                        .WithMany("Businesses")
                        .HasForeignKey("NeighborhoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Neighborhood");
                });

            modelBuilder.Entity("PortlandLocalBusinesses.Models.Neighborhood", b =>
                {
                    b.Navigation("Businesses");
                });
#pragma warning restore 612, 618
        }
    }
}
