using TekhnikaSite.Models;

namespace TekhnikaSite.Interfaces
{
    public interface ITrackRepository
    {
        Task<IEnumerable<Truck>> GetAll();
        Task<Truck> GetByIdAsync(int id);
        bool Add(Truck truck);
        bool Uupdate(Truck truck);
        bool Delete(Truck truck);
        bool Save();

    }
}
