using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;
public class HiloRespuestaNotificacionRepository : GenericRepository<HiloRespuestaNotificacion>, IHiloRespuestaNotificacion
{
    private readonly NotiAppContext _context;

    public HiloRespuestaNotificacionRepository(NotiAppContext context) : base(context)
    {
        _context = context;
    }

    public override async Task<IEnumerable<HiloRespuestaNotificacion>> GetAllAsync()
    {
        return await _context.HiloRespuestaNotificaciones
        .Include(a => a.ModuloNotificaciones)
        .Include(a => a.Blockchains)
        .ToListAsync();
    }
    public override async Task<(int totalRegistros, IEnumerable<HiloRespuestaNotificacion> registros)> GetAllAsync( //Sobrecarga de metodos
        int pageIndex,
        int pageSize,
        string search
    )
    {
        var query = _context.HiloRespuestaNotificaciones as IQueryable<HiloRespuestaNotificacion>;
        if (!string.IsNullOrEmpty(search))
        {
            query = query.Where(p => p.NombreTipo.ToLower().Contains(search));
        }
        query = query.OrderBy(p => p.Id);
        var totalRegistros = await query.CountAsync();
        var registros = await query
            .Include(a => a.ModuloNotificaciones)
            .Include(a => a.Blockchains)
            .Skip((pageIndex - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
        return (totalRegistros, registros);
    }
}
