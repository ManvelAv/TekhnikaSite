using TekhnikaSite.Models;

namespace TekhnikaSite.Interfaces
{
    public interface ISandRepository
    {
        Task<IEnumerable<Sand>> GetAll();
        Task<Sand> GetByIdAsync(int id);
        bool Add(Sand sand);
        bool Update(Sand sand);
        bool Delete(Sand sand);
        bool Save();
    }
}
