﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mokkiprojekti_ryhma10;

#nullable disable

namespace Mokkiprojekti_ryhma10.Migrations
{
    [DbContext(typeof(CottageContext))]
    partial class CottageContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.1");

            modelBuilder.Entity("Mokkiprojekti_ryhma10.Area", b =>
                {
                    b.Property<long>("AreaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("AreaId");

                    b.ToTable("Areas");
                });

            modelBuilder.Entity("Mokkiprojekti_ryhma10.Cottage", b =>
                {
                    b.Property<long>("CottageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("Amenities")
                        .HasColumnType("TEXT");

                    b.Property<long?>("AmountOfPeople")
                        .HasColumnType("INTEGER");

                    b.Property<long>("AreaId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CottageName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("PostId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.HasKey("CottageId");

                    b.HasIndex("AreaId");

                    b.HasIndex("PostId");

                    b.ToTable("Cottages");
                });

            modelBuilder.Entity("Mokkiprojekti_ryhma10.Customer", b =>
                {
                    b.Property<long>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Phonenumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("PostId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CustomerId");

                    b.HasIndex("PostId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Mokkiprojekti_ryhma10.Invoice", b =>
                {
                    b.Property<long>("InvoiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("ReservationId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Sum")
                        .HasColumnType("REAL");

                    b.Property<double>("Vat")
                        .HasColumnType("REAL");

                    b.HasKey("InvoiceId");

                    b.HasIndex("ReservationId");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("Mokkiprojekti_ryhma10.Post", b =>
                {
                    b.Property<string>("PostalCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("PostOffice")
                        .HasColumnType("TEXT");

                    b.HasKey("PostalCode");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("Mokkiprojekti_ryhma10.Reservation", b =>
                {
                    b.Property<long>("ReservationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ConfirmationDate")
                        .HasColumnType("TEXT");

                    b.Property<long>("CottageId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("CustomerId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ReservedDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ReservedEndDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ReservedStartDate")
                        .HasColumnType("TEXT");

                    b.HasKey("ReservationId");

                    b.HasIndex("CottageId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("Mokkiprojekti_ryhma10.ReservationService", b =>
                {
                    b.Property<long>("ReservationId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("ServiceId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("Amount")
                        .HasColumnType("INTEGER");

                    b.HasKey("ReservationId", "ServiceId");

                    b.HasIndex("ServiceId");

                    b.ToTable("ReservationServices");
                });

            modelBuilder.Entity("Mokkiprojekti_ryhma10.Service", b =>
                {
                    b.Property<long>("ServiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("AreaId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<long?>("Type")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Vat")
                        .HasColumnType("REAL");

                    b.HasKey("ServiceId");

                    b.HasIndex("AreaId");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("Mokkiprojekti_ryhma10.Cottage", b =>
                {
                    b.HasOne("Mokkiprojekti_ryhma10.Area", "Area")
                        .WithMany("Cottages")
                        .HasForeignKey("AreaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mokkiprojekti_ryhma10.Post", "Post")
                        .WithMany("Cottages")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Area");

                    b.Navigation("Post");
                });

            modelBuilder.Entity("Mokkiprojekti_ryhma10.Customer", b =>
                {
                    b.HasOne("Mokkiprojekti_ryhma10.Post", "Post")
                        .WithMany("Customers")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");
                });

            modelBuilder.Entity("Mokkiprojekti_ryhma10.Invoice", b =>
                {
                    b.HasOne("Mokkiprojekti_ryhma10.Reservation", "Reservation")
                        .WithMany("Invoices")
                        .HasForeignKey("ReservationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reservation");
                });

            modelBuilder.Entity("Mokkiprojekti_ryhma10.Reservation", b =>
                {
                    b.HasOne("Mokkiprojekti_ryhma10.Cottage", "Cottage")
                        .WithMany("Reservations")
                        .HasForeignKey("CottageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mokkiprojekti_ryhma10.Customer", "Customer")
                        .WithMany("Reservations")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cottage");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Mokkiprojekti_ryhma10.ReservationService", b =>
                {
                    b.HasOne("Mokkiprojekti_ryhma10.Reservation", "Reservation")
                        .WithMany("ReservationServices")
                        .HasForeignKey("ReservationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mokkiprojekti_ryhma10.Service", "Service")
                        .WithMany("ReservationServices")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reservation");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("Mokkiprojekti_ryhma10.Service", b =>
                {
                    b.HasOne("Mokkiprojekti_ryhma10.Area", "Area")
                        .WithMany("Services")
                        .HasForeignKey("AreaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Area");
                });

            modelBuilder.Entity("Mokkiprojekti_ryhma10.Area", b =>
                {
                    b.Navigation("Cottages");

                    b.Navigation("Services");
                });

            modelBuilder.Entity("Mokkiprojekti_ryhma10.Cottage", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("Mokkiprojekti_ryhma10.Customer", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("Mokkiprojekti_ryhma10.Post", b =>
                {
                    b.Navigation("Cottages");

                    b.Navigation("Customers");
                });

            modelBuilder.Entity("Mokkiprojekti_ryhma10.Reservation", b =>
                {
                    b.Navigation("Invoices");

                    b.Navigation("ReservationServices");
                });

            modelBuilder.Entity("Mokkiprojekti_ryhma10.Service", b =>
                {
                    b.Navigation("ReservationServices");
                });
#pragma warning restore 612, 618
        }
    }
}