using eTickets.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
    public interface IProducersService
    {
        Task<IEnumerable<Producer>> GetAllAsync();
        Task<Producer> GetByIdAsync(int id);
        Task AddAsync(Producer producer);
        Producer Update(int id, Producer newProducer);
        void Delete(int id);
    }
}
