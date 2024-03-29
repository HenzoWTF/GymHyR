using GymHyR.DAL;
using Library.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GymHyR.Services
{
    public class TipoMembresiasServices
    {
        private readonly Context _context;

        public TipoMembresiasServices(Context context)
        {
            _context = context;
        }

        public async Task<List<TipoMembresias>> GetList(Expression<Func<TipoMembresias, bool>> criterio)
        {
            return await _context.TipoMembresias
                .AsNoTracking()
                .Where(criterio)
                .ToListAsync();
        }
        public async Task<TipoMembresias?> Buscar(int tipoMembresiaId)
        {
            return await _context.TipoMembresias
                .Where(t => t.TipoMembresiaId == tipoMembresiaId)
                .AsNoTracking()
                .FirstOrDefaultAsync();
        }

    }
}
