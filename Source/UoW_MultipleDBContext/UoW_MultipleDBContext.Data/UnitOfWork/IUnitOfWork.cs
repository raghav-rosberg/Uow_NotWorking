﻿using System;
using System.Data.Entity;
using UoW_MultipleDBContext.Data.Infrastructure;
using UoW_MultipleDBContext.Data.Repositories.Interface;
using UoW_MultipleDBContext.Entity;

namespace UoW_MultipleDBContext.Data.UnitOfWork
{
    public interface IUnitOfWork<U> where U: DbContext, IDisposable
    {
        void Commit();
        DbContext GetDbContext();
    }
}
