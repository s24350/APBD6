namespace APBD_Zadanie_6.Models
{
    public class Prescription
    {
        int id;

        public virtual Patient IdPatientNav { get; set; }

    }
}
