using APBD_Zadanie_6.DTO;
using APBD_Zadanie_6.Models;
using APBD_Zadanie_6.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace APBD_Zadanie_6.Repositories
{
    public class PrescriptionRepository : IPrescriptionRepository
    {
        private readonly Context _context;

        public PrescriptionRepository(Context context)
        {
            _context = context;
        }
        public async Task<int> AddPrescriptionAsync(PrescriptionRequestDTO requestDTO)
        {
            //Jeśli pacjent przekazany w żądaniu nie istnieje, wstawiamy
            //nowego pacjenta do tabeli Pacjent.

            bool patientExists = await _context.Patients.AnyAsync(e => e.IdPatient == requestDTO.Patient.idPatient);

            Patient wantedPatient;

            if (!patientExists)
            {
                wantedPatient = new Patient
                {
                    //IdPatient = requestDTO.Patient.idPatient,
                    FirstName = requestDTO.Patient.FirstName,
                    LastName = requestDTO.Patient.LastName,
                };

                await _context.Patients.AddAsync(wantedPatient);
                await _context.SaveChangesAsync();
            }
            else
            {
                wantedPatient = await _context.Patients.FirstOrDefaultAsync(r => r.IdPatient == requestDTO.Patient.idPatient);
            }
            
            //Jeśli lek podany na recepcie nie istnieje, zwracamy błąd.
            foreach (var singleMedicament in requestDTO.Medicaments)
            {
                bool medicamentsExists = await _context.Medicaments.AnyAsync(e => e.IdMedicament == singleMedicament.IdMedicament);
                if (!medicamentsExists)
                {
                    throw new Exception("No such medicament!");
                }
            }
            // Recepta może obejmować maksymalnie 10 leków
            bool notGreaterThan10 = requestDTO.Medicaments.Count() <= 10;
            if (!notGreaterThan10) {
                throw new Exception("Too much medicaments!");
            }
            //Musimy sprawdzić czy DueData>=Date
            bool dateRelationIsOk = requestDTO.Date <= requestDTO.DueDate;
            if (!dateRelationIsOk)
            {
                throw new Exception("Wrong dates!");
            }

            Random r = new Random();

            Prescription prescriptionToAdd = new Prescription
            {
                //IdPrescription = await _context.Prescriptions.Select(r => r.IdPrescription).MaxAsync() + 1,
                Date = requestDTO.Date,
                DueDate = requestDTO.DueDate,
                IdPatient = wantedPatient.IdPatient,
                IdDoctor = r.Next(1, await _context.Doctors.Select(d => d.IdDoctor).MaxAsync()+1),
            };
            await _context.Prescriptions.AddAsync(prescriptionToAdd);
            await _context.SaveChangesAsync();

            foreach (var singleMedicament in requestDTO.Medicaments)
            {
                PrescriptionMedicament pmToAdd = new PrescriptionMedicament
                {
                    IdMedicament = singleMedicament.IdMedicament,
                    IdPrescription = prescriptionToAdd.IdPrescription,
                    Dose = singleMedicament.Dose,
                    Details = "details"
                };
                await _context.PrescriptionMedicaments.AddAsync(pmToAdd);
                await _context.SaveChangesAsync();
            }
            return 0;
        }
    }
}
