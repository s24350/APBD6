using APBD_Zadanie_6.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace APBD_Zadanie_6.Configuration
{
    public class PrescriptionMedicamentConfig : IEntityTypeConfiguration<PrescriptionMedicament>
    {
        public void Configure(EntityTypeBuilder<PrescriptionMedicament> builder)
        {
            builder.HasKey(e => new
            {
                e.IdMedicament,
                e.IdPrescription
            }).HasName("PrescriptionMedicamend_PK");

            builder.ToTable("Prescription_Medicament");

            builder.Property(e => e.Dose); //konkretne pole w tabeli
            builder.Property(e => e.Details).HasMaxLength(100).IsRequired(); //ograniczenia, wymagania pol

            builder.HasOne(e => e.IdMedicamentNav)
                .WithMany(e => e.PrescriptionMedicaments)
                .HasForeignKey(e => e.IdMedicament)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Medicament_Prescription_FK"); //ustawienie klucza obcego

            builder.HasOne(e => e.IdPrescriptionNav) //to jest ta klasa co wskazuje na liste
                .WithMany(e => e.PrescriptionMedicaments) //to jest lista
                .HasForeignKey(e => e.IdPrescription) //
                .OnDelete(DeleteBehavior.ClientSetNull) //na usuniecie to co
                .HasConstraintName("Prescription_Medicament_FK");

            // adding data

            var list = new List<PrescriptionMedicament>();

            list.Add(new PrescriptionMedicament
            {
                IdMedicament = 1,
                IdPrescription = 1,
                Dose = 200,
                Details = "2 pills in am and pm"
            });

            list.Add(new PrescriptionMedicament
            {
                IdMedicament = 2,
                IdPrescription = 1,
                Dose = 250,
                Details = "2 pills in am and pm"
            });

            list.Add(new PrescriptionMedicament
            {
                IdMedicament = 2,
                IdPrescription = 2,
                Dose = 250,
                Details = "2 pills in am and pm"
            });

            list.Add(new PrescriptionMedicament
            {
                IdMedicament = 3,
                IdPrescription = 3,
                Dose = 250,
                Details = "2 pills in am and pm"
            });

            builder.HasData(list);
        }
    }
}
