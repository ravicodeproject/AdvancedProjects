using System;
using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class Employee
    {
        [Key] // The entity type 'Employee' requires a primary key to be defined.
        public int Eid { get; set; }

        // public int Eid { get; set; }
        public string Efirstname { get; set; }
        public string Elastname { get; set; }
        public int Eage { get; set; }
        public string Egender { get; set; }
        public DateTime Edateofbirth { get; set; }
        public string Eemail { get; set; }
        public string Elanguages { get; set; }
        //public string[] Elanguages { get; set; }
        public string Eskills { get; set; }
        //public string[] Eskills { get; set; }
        public string Ereligion { get; set; }
        public string Enationality { get; set; }
        public string Ecaste { get; set; }
    }
}