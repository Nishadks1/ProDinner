﻿using System.Data.Entity;

namespace Omu.ProDinner.Data
{
    public interface IDbContextFactory
    {
        DbContext GetContext();
    }

    public class DbContextFactory : IDbContextFactory
    {
        private readonly DbContext dbContext;
        public DbContextFactory()
        {
            dbContext = new Db();
        }

        public DbContext GetContext()
        {
            return dbContext;
        }
    }
}