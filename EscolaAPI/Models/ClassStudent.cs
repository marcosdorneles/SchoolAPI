using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaAPI.Models
{
    public class ClassStudent
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int ClassId { get; set; }
        public Class Class { get; set; }

    }
}