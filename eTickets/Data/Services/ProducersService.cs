using System.Collections.Generic;
using System.Threading.Tasks;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services
{
    public class ProducersService : IProducersService
    {
        private readonly AppDbContext _context;

        public ProducersService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Producer>> GetAllAsync()
        {
            var result = await _context.Producers.ToListAsync();
            return result;
        }
        public async Task AddAsync(Producer producer)
        {
            await _context.Producers.AddAsync(producer);
            await _context.SaveChangesAsync();
        }

        public Producer Update(int id, Producer newProducer)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Producer> GetByIdAsync(int id)
        {
            var result = await _context.Producers.FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }
    }
}
