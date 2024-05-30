﻿// <auto-generated />
using System;
using APBD_Zadanie_6.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APBD_Zadanie_6.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240530144500_InitialMig")]
    partial class InitialMig
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("APBD_Zadanie_6.Models.Doctor", b =>
                {
                    b.Property<int>("IdDoctor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdDoctor"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdDoctor")
                        .HasName("Doctor_PK");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            IdDoctor = 1,
                            Email = "SampleDoctor@gmail.com",
                            FirstName = "Sample",
                            LastName = "Doctor"
                        },
                        new
                        {
                            IdDoctor = 2,
                            Email = "JakubBiologist@gmail.com",
                            FirstName = "Jakub",
                            LastName = "Biologist"
                        },
                        new
                        {
                            IdDoctor = 3,
                            Email = "MichalPediatrician@gmail.com",
                            FirstName = "Michal",
                            LastName = "Pediatrician"
                        },
                        new
                        {
                            IdDoctor = 4,
                            Email = "SergioPsychiatrist@gmail.com",
                            FirstName = "Sergio",
                            LastName = "Psychiatrist"
                        },
                        new
                        {
                            IdDoctor = 5,
                            Email = "PabloAnesthesiologist@gmail.com",
                            FirstName = "Pablo",
                            LastName = "Anesthesiologist"
                        },
                        new
                        {
                            IdDoctor = 6,
                            Email = "AzucarDiabetes@gmail.com",
                            FirstName = "Azucar",
                            LastName = "Diabetes"
                        });
                });

            modelBuilder.Entity("APBD_Zadanie_6.Models.Medicament", b =>
                {
                    b.Property<int>("IdMedicament")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMedicament"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdMedicament")
                        .HasName("IdMedicament_PK");

                    b.ToTable("Medicaments");

                    b.HasData(
                        new
                        {
                            IdMedicament = 1,
                            Description = "Painkiller, 200mg 3 times a day.",
                            Name = "Ibuprofène",
                            Type = "Anti inflamatory pills"
                        },
                        new
                        {
                            IdMedicament = 2,
                            Description = "From 10 to 1000 times a day.",
                            Name = "Happyness",
                            Type = "Anti sadness pills"
                        },
                        new
                        {
                            IdMedicament = 3,
                            Description = "CAN HARM YOUR HEALTH.",
                            Name = "Sadness",
                            Type = "Anti happyness pills"
                        });
                });

            modelBuilder.Entity("APBD_Zadanie_6.Models.Patient", b =>
                {
                    b.Property<int>("IdPatient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPatient"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdPatient")
                        .HasName("IdPatient_PK");

                    b.ToTable("Patients");

                    b.HasData(
                        new
                        {
                            IdPatient = 1,
                            BirthDate = new DateTime(1999, 5, 30, 16, 45, 0, 322, DateTimeKind.Local).AddTicks(4894),
                            FirstName = "Jakub",
                            LastName = "Nowak"
                        },
                        new
                        {
                            IdPatient = 2,
                            BirthDate = new DateTime(2003, 5, 30, 16, 45, 0, 322, DateTimeKind.Local).AddTicks(4946),
                            FirstName = "Michal",
                            LastName = "Kowalski"
                        },
                        new
                        {
                            IdPatient = 3,
                            BirthDate = new DateTime(1997, 5, 30, 16, 45, 0, 322, DateTimeKind.Local).AddTicks(4950),
                            FirstName = "Patient",
                            LastName = "Patientowich"
                        },
                        new
                        {
                            IdPatient = 4,
                            BirthDate = new DateTime(2002, 5, 30, 16, 45, 0, 322, DateTimeKind.Local).AddTicks(4953),
                            FirstName = "Sergio",
                            LastName = "Kotowich"
                        },
                        new
                        {
                            IdPatient = 5,
                            BirthDate = new DateTime(1974, 5, 30, 16, 45, 0, 322, DateTimeKind.Local).AddTicks(4956),
                            FirstName = "Ala",
                            LastName = "Peronska"
                        },
                        new
                        {
                            IdPatient = 6,
                            BirthDate = new DateTime(1995, 5, 30, 16, 45, 0, 322, DateTimeKind.Local).AddTicks(4961),
                            FirstName = "Kot",
                            LastName = "Zygmund"
                        },
                        new
                        {
                            IdPatient = 7,
                            BirthDate = new DateTime(1970, 5, 30, 16, 45, 0, 322, DateTimeKind.Local).AddTicks(4963),
                            FirstName = "Natiel",
                            LastName = "Patient"
                        },
                        new
                        {
                            IdPatient = 8,
                            BirthDate = new DateTime(1957, 5, 30, 16, 45, 0, 322, DateTimeKind.Local).AddTicks(4966),
                            FirstName = "Jas",
                            LastName = "Profase"
                        });
                });

            modelBuilder.Entity("APBD_Zadanie_6.Models.Prescription", b =>
                {
                    b.Property<int>("IdPrescription")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPrescription"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdDoctor")
                        .HasColumnType("int");

                    b.Property<int>("IdPatient")
                        .HasColumnType("int");

                    b.HasKey("IdPrescription")
                        .HasName("Prescription_PK");

                    b.HasIndex("IdDoctor");

                    b.HasIndex("IdPatient");

                    b.ToTable("Prescription", (string)null);

                    b.HasData(
                        new
                        {
                            IdPrescription = 1,
                            Date = new DateTime(2024, 5, 20, 16, 45, 0, 323, DateTimeKind.Local).AddTicks(6666),
                            DueDate = new DateTime(2024, 9, 7, 16, 45, 0, 323, DateTimeKind.Local).AddTicks(6685),
                            IdDoctor = 1,
                            IdPatient = 1
                        },
                        new
                        {
                            IdPrescription = 2,
                            Date = new DateTime(2024, 5, 10, 16, 45, 0, 323, DateTimeKind.Local).AddTicks(6738),
                            DueDate = new DateTime(2024, 8, 28, 16, 45, 0, 323, DateTimeKind.Local).AddTicks(6740),
                            IdDoctor = 3,
                            IdPatient = 8
                        },
                        new
                        {
                            IdPrescription = 3,
                            Date = new DateTime(2024, 4, 30, 16, 45, 0, 323, DateTimeKind.Local).AddTicks(6743),
                            DueDate = new DateTime(2024, 8, 18, 16, 45, 0, 323, DateTimeKind.Local).AddTicks(6745),
                            IdDoctor = 1,
                            IdPatient = 5
                        });
                });

            modelBuilder.Entity("APBD_Zadanie_6.Models.PrescriptionMedicament", b =>
                {
                    b.Property<int>("IdMedicament")
                        .HasColumnType("int");

                    b.Property<int>("IdPrescription")
                        .HasColumnType("int");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Dose")
                        .HasColumnType("int");

                    b.HasKey("IdMedicament", "IdPrescription")
                        .HasName("PrescriptionMedicamend_PK");

                    b.HasIndex("IdPrescription");

                    b.ToTable("Prescription_Medicament", (string)null);

                    b.HasData(
                        new
                        {
                            IdMedicament = 1,
                            IdPrescription = 1,
                            Details = "2 pills in am and pm",
                            Dose = 200
                        },
                        new
                        {
                            IdMedicament = 2,
                            IdPrescription = 1,
                            Details = "1 pill in am and pm",
                            Dose = 250
                        },
                        new
                        {
                            IdMedicament = 2,
                            IdPrescription = 2,
                            Details = "3 pills in am",
                            Dose = 250
                        },
                        new
                        {
                            IdMedicament = 3,
                            IdPrescription = 3,
                            Details = "1,5 pills in pm",
                            Dose = 250
                        });
                });

            modelBuilder.Entity("APBD_Zadanie_6.Models.Prescription", b =>
                {
                    b.HasOne("APBD_Zadanie_6.Models.Doctor", "IdDoctorNav")
                        .WithMany("Prescriptions")
                        .HasForeignKey("IdDoctor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("Prescription_Doctor_FK");

                    b.HasOne("APBD_Zadanie_6.Models.Patient", "IdPatientNav")
                        .WithMany("Prescriptions")
                        .HasForeignKey("IdPatient")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("Prescription_Patient_FK");

                    b.Navigation("IdDoctorNav");

                    b.Navigation("IdPatientNav");
                });

            modelBuilder.Entity("APBD_Zadanie_6.Models.PrescriptionMedicament", b =>
                {
                    b.HasOne("APBD_Zadanie_6.Models.Medicament", "IdMedicamentNav")
                        .WithMany("PrescriptionMedicaments")
                        .HasForeignKey("IdMedicament")
                        .IsRequired()
                        .HasConstraintName("Medicament_Prescription_FK");

                    b.HasOne("APBD_Zadanie_6.Models.Prescription", "IdPrescriptionNav")
                        .WithMany("PrescriptionMedicaments")
                        .HasForeignKey("IdPrescription")
                        .IsRequired()
                        .HasConstraintName("Prescription_Medicament_FK");

                    b.Navigation("IdMedicamentNav");

                    b.Navigation("IdPrescriptionNav");
                });

            modelBuilder.Entity("APBD_Zadanie_6.Models.Doctor", b =>
                {
                    b.Navigation("Prescriptions");
                });

            modelBuilder.Entity("APBD_Zadanie_6.Models.Medicament", b =>
                {
                    b.Navigation("PrescriptionMedicaments");
                });

            modelBuilder.Entity("APBD_Zadanie_6.Models.Patient", b =>
                {
                    b.Navigation("Prescriptions");
                });

            modelBuilder.Entity("APBD_Zadanie_6.Models.Prescription", b =>
                {
                    b.Navigation("PrescriptionMedicaments");
                });
#pragma warning restore 612, 618
        }
    }
}
