using APBD_Zadanie_6.DTO;

namespace APBD_Zadanie_6.Interfaces
{
    public interface IPrescriptionRepository
    {
        public Task<int> AddPrescriptionAsync(PrescriptionRequestDTO requestDTO);
    }
}
