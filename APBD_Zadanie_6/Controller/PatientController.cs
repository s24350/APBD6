using APBD_Zadanie_6.DTO;
using APBD_Zadanie_6.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace APBD_Zadanie_6.Controller
{
    public class PatientController : ControllerBase
    {
        private readonly IPatientRepository _patientRepository;

        public PatientController(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetClient([FromBody] PatientDTO patientDTO) { 
            var patient = await _patientRepository.GetPatientDataAsync(patientDTO);
            return Ok(patient);
        }
    }
}
