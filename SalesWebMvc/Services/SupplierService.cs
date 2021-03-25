using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Services.Exceptions;

namespace SalesWebMvc.Services
{
    public class SupplierService
    {
        private readonly SalesWebMvcContext _context;

        public SupplierService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<Supplier>> FindAllAsync()
        {
            return await _context.Supplier.OrderBy(x => x.Name).ToListAsync();
        }

        public async Task<Supplier> FindByIdAsync(int id)
        {
            return await _context.Supplier.FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task InsertAsync(Supplier obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.Supplier.FindAsync(id);
                _context.Supplier.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                throw new IntegrityException(e.Message);
            }
        }

        public async Task UpdateAsync(Supplier obj)
        {
            bool hasAny = await _context.Supplier.AnyAsync(x => x.Id == obj.Id);
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
