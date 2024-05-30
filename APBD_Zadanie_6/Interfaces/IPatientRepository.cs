using APBD_Zadanie_6.DTO;
using Microsoft.AspNetCore.Mvc;

namespace APBD_Zadanie_6.Interfaces
{
    public interface IPatientRepository
    {
        public Task<IActionResult> GetPatientDataAsync(PatientDTO patientDTO);
    }
}
