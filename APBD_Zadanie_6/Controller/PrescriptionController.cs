using APBD_Zadanie_6.DTO;
using APBD_Zadanie_6.Interfaces;
using APBD_Zadanie_6.Models;
using Microsoft.AspNetCore.Mvc;

namespace APBD_Zadanie_6.Controller
{
    [ApiController]
    [Route("api/prescription")]
    public class PrescriptionController : ControllerBase
    {
        private readonly IPrescriptionRepository _prescriptionRepository;

        public PrescriptionController(IPrescriptionRepository prescriptionRepository)
        {
            _prescriptionRepository = prescriptionRepository;
        }

        [HttpPost]
        public async Task<IActionResult> AddPrescritption([FromBody] PrescriptionRequestDTO request)
        {
            return Ok(await _prescriptionRepository.AddPrescriptionAsync(request));
        }
    }
}
