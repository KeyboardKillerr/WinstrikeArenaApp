using DataModels.Entities;
using DataModels.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.DataProviders.Ef.Core.Repositories
{
    public class EfComputer : IComputerRep
    {
        protected readonly DataContext Context;
        public EfComputer(DataContext context) => Context = context;

        public IQueryable<Computer> Items => Context.Computers
            .Include(x => x.InstalledApps)
            .Include(x => x.InstalledGames)
            .Include(x => x.ZoneId);

        public async Task<int> DeleteAsync(Guid id)
        {
            var item = await Items.FirstOrDefaultAsync(x => x.Id == id);
            if (item != default)
            {
                Context.Remove(item);
                return await Context.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<Computer?> GetItemByIdAsync(Guid id)
        {
            return await Items.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<int> UpdateAsync(Computer table)
        {
            var item = await Items.FirstOrDefaultAsync(x => x.Id == table.Id);
            if (item != default) Context.Update(table);
            else await Context.AddAsync(table);
            return await Context.SaveChangesAsync();
        }
    }
}
