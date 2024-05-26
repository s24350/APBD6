namespace APBD_Zadanie_6.DTO
{
    public class PatientDTO
    {
        public int idPatient { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; } 

        public DateTime birthDate { get; set; }

        //DO POPRAWY
        public IEnumerable<PatientDTO> Patients { get; set; }
    }
}
