using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaAPI.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public DateTime BirthDay { get; set; }
        public ICollection<Boletim>Boletins { get; set; }
        public ICollection<ClassStudent>Classes { get; set; }

    }
}