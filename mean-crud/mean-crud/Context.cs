using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mean_crud.Models;

namespace mean_crud
{
    public class Context
    {
        private readonly IMongoDatabase database;

        public Context()
        {
            database = new MongoClient("mongodb://localhost:27017").GetDatabase("mean-crud");
        }

        public IMongoCollection<Employees> Employees
        {
            get
            {
                return database.GetCollection<Employees>("Employees");
            }
        }
    }
}
