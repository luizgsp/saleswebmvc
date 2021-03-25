using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Services.Exceptions;

namespace SalesWebMvc.Services
{
    public class CustomerService
    {
        private readonly SalesWebMvcContext _context;

        public CustomerService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<Customer>> FindAllAsync()
        {
            return await _context.Customer.OrderBy(x => x.Name).ToListAsync();
        }

        public async Task<Customer> FindByIdAsync(int id)
        {
            return await _context.Customer.FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task InsertAsync(Customer obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.Customer.FindAsync(id);
                _context.Customer.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                throw new IntegrityException(e.Message);
            }
        }

        public async Task UpdateAsync(Customer obj)
        {
            bool hasAny = await _context.Customer.AnyAsync(x => x.Id == obj.Id);
            if (!hasAny)
            {
                throw new NotFoundException("Id not found");
            }
            try
            {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}
