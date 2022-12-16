using DataModels.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using DataModels.DataProviders.Ef.Core.Repositories;

namespace DataModels
{
    public class DataManager
    {
        public IApplicationRep App { get; }
        public IComputerRep Computer { get; }
        public IGameRep Game { get; }
        public IGenreRep Genre { get; }
        public ILoginLogRep LoginLog { get; }
        public IRateRep Rate { get; }
        public IUserRep User { get; }
        public IZoneRep Zone { get; }

        //public DbContext? Context { get; }

        private DataManager(IApplicationRep app, IComputerRep computer, IGameRep game, IGenreRep genre, ILoginLogRep loginLog, IRateRep rate, IUserRep user, IZoneRep zone)
        {
            App = app;
            Computer = computer;
            Game = game;
            Genre = genre;
            LoginLog = loginLog;
            Rate = rate;
            User = user;
            Zone = zone;
        }

        public static DataManager Get(DataProvider dataProviders)
        {
            switch (dataProviders)
            {
                case DataProvider.Json:
                case DataProvider.Txt:
                case DataProvider.Oracle:
                case DataProvider.Sqlite:
                    var sqlite = new DataProviders.Ef.Contexts.SqlServerDbContext();
                    sqlite.Database.EnsureCreated();
                    return new DataManager
                    (
                        new EfApplication(sqlite),
                        new EfComputer(sqlite),
                        new EfGame(sqlite),
                        new EfGenre(sqlite),
                        new EfLoginLog(sqlite),
                        new EfRate(sqlite),
                        new EfUser(sqlite),
                        new EfZone(sqlite)
                    );
                case DataProvider.MySql:
                    throw new NotSupportedException("Поставщики данных находятся в стадии разработки");
                case DataProvider.SqlServer:
                    var context = new DataProviders.Ef.Contexts.SqlServerDbContext();
                    context.Database.EnsureCreated();
                    return new DataManager
                    (
                        new EfApplication(context),
                        new EfComputer(context),
                        new EfGame(context),
                        new EfGenre(context),
                        new EfLoginLog(context),
                        new EfRate(context),
                        new EfUser(context),
                        new EfZone(context)
                    );
                default:
                    throw new NotSupportedException("Поставщики данных неизвестен");
            }
        }
    }
}
