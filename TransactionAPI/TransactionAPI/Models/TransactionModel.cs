using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TransactionAPI.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
    }
    public class MyRequestModel
    {
        public string Value1 { get; set; }
        public string Value2 { get; set; }
    }
}