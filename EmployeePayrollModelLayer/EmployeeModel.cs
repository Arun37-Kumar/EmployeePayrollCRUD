using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePayrollModelLayer
{
    public class EmployeeModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Profile { get; set; }
        public string Gender { get; set; }
        public string Department { get; set; }
        public string Salary { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }

    }
}
