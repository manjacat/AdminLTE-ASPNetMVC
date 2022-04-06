using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminLTE_ASPNetMVC.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }

        public static Student GetSample(int Id)
        {
            return new Student
            {
                ID = Id,
                FirstName = "Rylai",
                LastName = "CrestFall",
                Address = "22, Jalan Ipoh, 30100 Ipoh, Perak",
                Email = "rylai@gmail.com",
                Telephone = "012-44903248"
            };
        }

        public static List<Student> GetSampleList()
        {
            List<Student> students = new List<Student>();
            students.Add(GetSample(1));
            students.Add(GetSample(2));
            students.Add(GetSample(3));
            students.Add(GetSample(4));
            return students;
        }
    }
}