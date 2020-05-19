using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mean_crud.Models
{
    public class Employees
    {
       
        public ObjectId Id { get; set; }

        public string Name { get; set; }
        public string Position { get; set; }
        public string Office { get; set; }

        public int Salary { get; set; }
    }
}
