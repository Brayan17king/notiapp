using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class BlockchainRepository : GenericRepository<Blockchain> , IBlockchain
{
    private readonly NotiAppContext _context;

    public BlockchainRepository(NotiAppContext context) : base(context)
    {
        _context = context;
    }

    public override async Task<IEnumerable<Blockchain>> GetAllAsync()
    {
        return await _context.Blockchains
        .ToListAsync();
    }
    public override async Task<(int totalRegistros, IEnumerable<Blockchain> registros)> GetAllAsync( //Sobrecarga de metodos
        int pageIndex,
        int pageSize,
        string search
    )
    {
        var query = _context.Blockchains as IQueryable<Blockchain>;
        if (!string.IsNullOrEmpty(search))
        {
            query = query.Where(p => p.HasGenerado.ToLower().Contains(search));
        }
        query = query.OrderBy(p => p.Id);
        var totalRegistros = await query.CountAsync();
        var registros = await query
            .Skip((pageIndex - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
        return (totalRegistros, registros);
    }
}