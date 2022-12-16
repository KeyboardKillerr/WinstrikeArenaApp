using DataModels.DataProviders.Ef.Core;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels.DataProviders.Ef.Contexts
{
    public class SqlServerDbContext : DataContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Data Source = dbsrv\mam2022; Initial Catalog = KuznetsovKP2; Integrated Security = True;");
        }
    }
}
