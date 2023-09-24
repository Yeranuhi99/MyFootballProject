﻿using MyFootballProject.Data.Entities;

namespace MyFootballProject.Data.Repositories.Interfaces
{
    public interface IStadiumRepository
    {
        void Add(Stadium Stadium);
        Stadium GetById(int id);
        List<Stadium> GetAll();
        void Delete(Stadium Stadium);
        void SaveChanges();
    }
}
