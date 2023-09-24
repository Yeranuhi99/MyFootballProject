﻿using MyFootballProject.Data.Entities;

namespace MyFootballProject.Data.Repositories.Interfaces
{
    public interface IPresidentRepository
    {
        void Add(President President);
        President GetById(int id);
        List<President> GetAll();
        void Delete(President President);
        void SaveChanges();
    }
}
