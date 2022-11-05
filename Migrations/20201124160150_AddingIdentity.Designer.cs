﻿// <auto-generated />
using System;
using COSE71197_DL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace COSE71197_DL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20201124160150_AddingIdentity")]
    partial class AddingIdentity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("COSE71197_DL.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Computing"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Audio"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Cables"
                        });
                });

            modelBuilder.Entity("COSE71197_DL.Models.Hardware", b =>
                {
                    b.Property<int>("HardwareId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsInStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOnSale")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("HardwareId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Hardwares");

                    b.HasData(
                        new
                        {
                            HardwareId = 1,
                            CategoryId = 1,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\209px-Toshiba_HD-A1_motherboard_20081026.jpg",
                            ImageUrl = "\\Images\\Toshiba_HD-A1_motherboard_20081026.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Toshiba HD-A1 motherboard 20081026",
                            Price = 10.00m
                        },
                        new
                        {
                            HardwareId = 2,
                            CategoryId = 1,
                            Description = "Pellentesque nec dolor sed ante dictum pretium. Ut aliquam augue sem, a rutrum elit fermentum vel. Sed interdum ligula tincidunt erat ornare hendrerit. Fusce sed semper est. In rhoncus luctus laoreet. Mauris venenatis pellentesque mi quis aliquam.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\320px-Intel_CPU_Core_i7_6700K_Skylake_perspective.jpg",
                            ImageUrl = "\\Images\\800px-Intel_CPU_Core_i7_6700K_Skylake_perspective.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Intel CPU Core i7 6700K Skylake perspective",
                            Price = 50.00m
                        },
                        new
                        {
                            HardwareId = 3,
                            CategoryId = 1,
                            Description = "Phasellus at ex vitae tortor laoreet viverra sed sed leo. Nulla congue ex id pretium consequat. Integer quis eleifend tellus. Proin id dapibus urna, et efficitur metus. Pellentesque accumsan gravida nulla ut cursus. Integer sit amet fringilla eros. Duis lacinia tincidunt ultrices.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\Early_Apple_Macintosh_with_keyboard_and_mouse_in_museum_thumbnail.jpg",
                            ImageUrl = "\\Images\\Early_Apple_Macintosh_with_keyboard_and_mouse_in_museum.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Early Apple Macintosh with keyboard and mouse",
                            Price = 85.00m
                        },
                        new
                        {
                            HardwareId = 4,
                            CategoryId = 1,
                            Description = "Praesent ornare velit tempus ornare bibendum. Donec gravida mi sed tincidunt pharetra. Sed ut purus vel nisi tincidunt fermentum sit amet sed orci. Sed consequat nisi id urna imperdiet ullamcorper. Phasellus bibendum lobortis risus, eget placerat justo sollicitudin et.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\320px-D-Link_DES-1024R91906.jpg",
                            ImageUrl = "\\Images\\D-Link_DES-1024R91906.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "D-Link DES-1024R+-91906",
                            Price = 100.00m
                        },
                        new
                        {
                            HardwareId = 5,
                            CategoryId = 1,
                            Description = "Sed et turpis efficitur, dictum massa eget, rutrum sapien. Praesent faucibus elit ac dictum consectetur. Mauris sagittis at est vel finibus. Nam at nisi eros. Etiam massa erat, fermentum lobortis pellentesque et, blandit eget turpis. Ut fermentum leo non nisl ullamcorper scelerisque. Maecenas feugiat nunc eros, sed convallis ex dapibus id. Proin vitae dolor ut est dictum condimentum. Morbi ut rutrum lectus, quis suscipit libero. Vestibulum aliquam neque ut augue vestibulum lacinia.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\320px-Vertex_2_Solid_State_Drive.jpg",
                            ImageUrl = "\\Images\\Vertex_2_Solid_State_Drive.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Vertex 2 Solid State Drive by OCZ top oblique PNr°0307",
                            Price = 65.00m
                        },
                        new
                        {
                            HardwareId = 6,
                            CategoryId = 2,
                            Description = "Quisque posuere vehicula libero eu porttitor. Sed et nunc nunc. Nulla elit tellus, interdum a neque ac, eleifend rutrum lorem. Mauris rhoncus, lorem nec posuere maximus, mi justo rhoncus neque, ut vestibulum felis ex non arcu. Aenean non mi sem. Pellentesque a congue quam.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\180px-Marshall_JCM800_amplifier.jpg",
                            ImageUrl = "\\Images\\Marshall_JCM800_amplifier.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Marshall JCM800 amplifier",
                            Price = 195.00m
                        },
                        new
                        {
                            HardwareId = 7,
                            CategoryId = 2,
                            Description = "At erat pellentesque adipiscing commodo elit at imperdiet. Diam vulputate ut pharetra sit. Cras tincidunt lobortis feugiat vivamus at. In nibh mauris cursus mattis molestie a iaculis at erat. Purus sit amet luctus venenatis lectus magna fringilla urna. Morbi tristique senectus et netus. Phasellus egestas tellus rutrum tellus pellentesque eu tincidunt tortor. Amet tellus cras adipiscing enim eu. Nunc sed blandit libero volutpat sed cras ornare arcu dui.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\320px-Headphones_1.jpg",
                            ImageUrl = "\\Images\\Headphones_1.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Circumaural headphones",
                            Price = 25.00m
                        },
                        new
                        {
                            HardwareId = 8,
                            CategoryId = 2,
                            Description = "Quisque non bibendum lectus. Proin tempor pulvinar lobortis. Proin auctor lorem vitae felis volutpat feugiat. Cras egestas diam a risus elementum, at semper turpis placerat. Sed molestie vulputate tellus. Mauris et massa elementum, lobortis velit nec, consequat risus. Nullam vel mi vitae nunc mattis ullamcorper.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\320px-R.A.Moog_minimoog_2.jpg",
                            ImageUrl = "\\Images\\R.A.Moog_minimoog_2.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Minimoog sympthesiser",
                            Price = 135.00m
                        },
                        new
                        {
                            HardwareId = 9,
                            CategoryId = 2,
                            Description = "Donec et dapibus erat, vitae tempus mauris. Duis cursus viverra metus, volutpat consequat quam rutrum nec. Nam massa ante, iaculis quis nunc sit amet, suscipit tristique massa. Aliquam posuere rutrum felis, vitae condimentum lectus lobortis eget. Aenean dignissim tempor ex, id tempus augue mattis et. Vestibulum ac fermentum risus, ac vulputate odio.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\320px-Turntables_and_mixer.jpg",
                            ImageUrl = "\\Images\\Turntables_and_mixer.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Turntables and mixer",
                            Price = 170.00m
                        },
                        new
                        {
                            HardwareId = 10,
                            CategoryId = 2,
                            Description = "Fusce lacinia augue eget felis rutrum, fringilla condimentum tellus mattis. Donec vitae sapien sit amet ligula molestie sagittis. In dignissim lacus in risus lobortis, quis varius est gravida. Integer in massa imperdiet, mattis turpis sed, laoreet risus. In a enim condimentum, facilisis diam vitae, eleifend mauris.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\320px-Vox_Tone_Bender.jpg",
                            ImageUrl = "\\Images\\800px-Vox_Tone_Bender.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Vox Tone Bender",
                            Price = 65.00m
                        },
                        new
                        {
                            HardwareId = 11,
                            CategoryId = 3,
                            Description = "Turpis egestas integer eget aliquet nibh. Viverra justo nec ultrices dui. Cum sociis natoque penatibus et magnis dis parturient montes nascetur. Tincidunt dui ut ornare lectus. Vitae nunc sed velit dignissim sodales ut eu. Diam phasellus vestibulum lorem sed risus. Volutpat ac tincidunt vitae semper quis lectus nulla. Enim neque volutpat ac tincidunt vitae semper quis. Sit amet consectetur adipiscing elit ut aliquam purus sit. Etiam erat velit scelerisque in dictum non consectetur. At lectus urna duis convallis convallis.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\EthernetCableGreenThumbnail.jpg",
                            ImageUrl = "\\Images\\EthernetCableGreen.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Ethernet Cable Green",
                            Price = 15.00m
                        },
                        new
                        {
                            HardwareId = 12,
                            CategoryId = 3,
                            Description = "Orci dapibus ultrices in iaculis. Nec nam aliquam sem et tortor consequat. Neque convallis a cras semper auctor neque vitae. Augue neque gravida in fermentum et sollicitudin. Odio aenean sed adipiscing diam donec adipiscing tristique risus nec. Turpis egestas integer eget aliquet nibh praesent tristique magna sit. ",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\HDMI_to_Micro_thumbnail.jpg",
                            ImageUrl = "\\Images\\HDMI_to_Micro.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Ethernet Cable Green",
                            Price = 10.00m
                        },
                        new
                        {
                            HardwareId = 13,
                            CategoryId = 3,
                            Description = "Mauris rhoncus aenean vel elit scelerisque mauris. Rutrum tellus pellentesque eu tincidunt tortor aliquam nulla facilisi. Scelerisque fermentum dui faucibus in ornare. Quis lectus nulla at volutpat. Ipsum consequat nisl vel pretium.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\320px-Power_cord_(817840840).jpg",
                            ImageUrl = "\\Images\\800px-Power_cord_(817840840).jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Power cord",
                            Price = 10.00m
                        },
                        new
                        {
                            HardwareId = 14,
                            CategoryId = 3,
                            Description = "In vitae turpis massa sed elementum. Elementum nibh tellus molestie nunc non. Ultrices eros in cursus turpis massa. At erat pellentesque adipiscing commodo. Cras adipiscing enim eu turpis egestas pretium aenean pharetra. Vivamus at augue eget arcu dictum varius duis at. Vitae justo eget magna fermentum iaculis eu non diam. Mattis enim ut tellus elementum sagittis vitae et leo. Sit amet risus nullam eget felis eget. Ipsum nunc aliquet bibendum enim facilisis gravida neque convallis a. Sem nulla pharetra diam sit.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\218px-Cable-ecran-VGA.jpg",
                            ImageUrl = "\\Images\\Cable-ecran-VGA.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "VGA Cable",
                            Price = 20.00m
                        },
                        new
                        {
                            HardwareId = 15,
                            CategoryId = 3,
                            Description = "Egestas fringilla phasellus faucibus scelerisque eleifend. Massa id neque aliquam vestibulum morbi blandit cursus risus at. Sem nulla pharetra diam sit amet nisl suscipit adipiscing. Vitae elementum curabitur vitae nunc sed. Nunc eget lorem dolor sed viverra ipsum nunc aliquet. Consectetur lorem donec massa sapien faucibus et molestie ac feugiat. ",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\320px-Serial_Cable_thumbnail.jpg",
                            ImageUrl = "\\Images\\Serial_Cable.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Serial Cable",
                            Price = 20.00m
                        });
                });

            modelBuilder.Entity("COSE71197_DL.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("County")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("OrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(7)")
                        .HasMaxLength(7);

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("TownOrCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("COSE71197_DL.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("HardwareId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("HardwareId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("COSE71197_DL.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("HardwareId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("HardwareId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("COSE71197_DL.Models.Hardware", b =>
                {
                    b.HasOne("COSE71197_DL.Models.Category", "Category")
                        .WithMany("Hardwares")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("COSE71197_DL.Models.OrderDetail", b =>
                {
                    b.HasOne("COSE71197_DL.Models.Hardware", "Hardware")
                        .WithMany()
                        .HasForeignKey("HardwareId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("COSE71197_DL.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("COSE71197_DL.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("COSE71197_DL.Models.Hardware", "Hardware")
                        .WithMany()
                        .HasForeignKey("HardwareId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
