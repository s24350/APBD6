using APBD_Zadanie_6.Models;
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


        }

    }
}
