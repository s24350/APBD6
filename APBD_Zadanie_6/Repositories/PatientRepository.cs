using APBD_Zadanie_6.DTO;
using APBD_Zadanie_6.Interfaces;
using APBD_Zadanie_6.Models;
using Microsoft.AspNetCore.Mvc;

namespace APBD_Zadanie_6.Repositories
{
    public class PatientRepository : IPatientRepository
    {

        private readonly Context _context;

        public PatientRepository(Context context)
        {
            _context = context;
        }
        public Task<IActionResult> GetPatientDataAsync(PatientDTO patientDTO)
        {

            throw new NotImplementedException();
        }
    }
}
