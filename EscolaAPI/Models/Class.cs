using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaAPI.Models
{
    public class Class
    {
        public int Id { get; set; }
        public string subject {get; set;}
        public string Name { get; set;}
        public ICollection<ClassStudent>Students { get; set; }
    }
}