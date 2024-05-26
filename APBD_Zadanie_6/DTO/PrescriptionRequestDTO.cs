namespace APBD_Zadanie_6.DTO
{
    public class PrescriptionRequestDTO
    {
        public PatientDTO patient { get; set; }
        public DateTime Date { get; set; }
        public DateTime DueDate { get; set; }

    }
}
