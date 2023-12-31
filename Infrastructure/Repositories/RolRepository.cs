using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;
public class RolRepository : GenericRepository<Rol>, IRol
{
    private readonly NotiAppContext _context;

    public RolRepository(NotiAppContext context) : base(context)
    {
        _context = context;
    }

    public override async Task<IEnumerable<Rol>> GetAllAsync()
    {
        return await _context.Roles
        .Include(a => a.RolvsMaestros)
        .Include(a => a.GenericovsSubmodulos)
        .ToListAsync();
    }
    public override async Task<(int totalRegistros, IEnumerable<Rol> registros)> GetAllAsync( //Sobrecarga de metodos
        int pageIndex,
        int pageSize,
        string search
    )
    {
        var query = _context.Roles as IQueryable<Rol>;
        if (!string.IsNullOrEmpty(search))
        {
            query = query.Where(p => p.NombreRol.ToLower().Contains(search));
        }
        query = query.OrderBy(p => p.Id);
        var totalRegistros = await query.CountAsync();
        var registros = await query
            .Include(a => a.RolvsMaestros)
            .Include(a => a.GenericovsSubmodulos)
            .Skip((pageIndex - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
        return (totalRegistros, registros);
    }
}
