﻿using APBD_Zadanie_6.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APBD_Zadanie_6.Configuration
{
    public class PrescriptionConfig : IEntityTypeConfiguration<Prescription>
    {

        public void Configure(EntityTypeBuilder<Prescription> builder)
        {
            builder.HasKey(e => new
            {
                e.IdPrescription
            }).HasName("PrescriptionMedicamend_PK");

            builder.ToTable(nameof(Prescription));

            //property itd.
            builder.Property(e => e.Date);
            builder.Property(e => e.DueDate);

            builder.HasOne(e => e.IdPatientNav)
                .WithMany(e => e.Prescriptions)
                .HasForeignKey(e => e.IdPatient)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("Patient_FK");

            builder.HasOne(e => e.IdDoctorNav)
                .WithMany(e => e.Prescriptions)
                .HasForeignKey(e => e.IdDoctor)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("Doctor_FK");

            var prescription = new List<Prescription>();

            prescription.Add(new Prescription
            {
                IdPrescription = 1,
                Date = DateTime.Now.AddDays(-10),
                DueDate = DateTime.Now.AddDays(-110),
                IdPatient = 1,
                IdDoctor = 1
            });
            
            prescription.Add(new Prescription
            {
                IdPrescription = 2,
                Date = DateTime.Now.AddDays(-20),
                DueDate = DateTime.Now.AddDays(-120),
                IdPatient = 8,
                IdDoctor = 3
            });

            prescription.Add(new Prescription
            {
                IdPrescription = 3,
                Date = DateTime.Now.AddDays(-30),
                DueDate = DateTime.Now.AddDays(-130),
                IdPatient = 5,
                IdDoctor = 1
            });

            prescription.Add(new Prescription
            {
                IdPrescription = 4,
                Date = DateTime.Now.AddDays(-40),
                DueDate = DateTime.Now.AddDays(-140),
                IdPatient = 6,
                IdDoctor = 3
            });

            prescription.Add(new Prescription
            {
                IdPrescription = 5,
                Date = DateTime.Now.AddDays(-50),
                DueDate = DateTime.Now.AddDays(-150),
                IdPatient = 4,
                IdDoctor = 6
            });
        }

    }
}
