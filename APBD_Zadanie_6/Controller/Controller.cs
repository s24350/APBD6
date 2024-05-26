using APBD_Zadanie_6.Models;
using Microsoft.AspNetCore.Mvc;

namespace APBD_Zadanie_6.Controller
{
    public class Controller : ControllerBase
    {

        [HttpPost]
        public Task<IActionResult> AddPrescritption([FromBody] PrescriptionRequestDTO request)
        {
            return Ok(request);
        }
    }
}
