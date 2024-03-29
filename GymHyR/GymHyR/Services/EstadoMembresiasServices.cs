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
    public class EstadoMembresiasServices
    {
        private readonly Context _context;

        public EstadoMembresiasServices(Context context)
        {
            _context = context;
        }

        public async Task<List<EstadoMembresias>> GetList(Expression<Func<EstadoMembresias, bool>> criterio)
        {
            return await _context.EstadoMembresias
                .AsNoTracking()
                .Where(criterio)
                .ToListAsync();
        }

        public async Task<EstadoMembresias?> Buscar(int estadoMembresiaId)
        {
            return await _context.EstadoMembresias
                .Where(e => e.EstadoMembresiaId == estadoMembresiaId)
                .AsNoTracking()
                .FirstOrDefaultAsync();
        }
    }
}
