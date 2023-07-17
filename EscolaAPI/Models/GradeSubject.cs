using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaAPI.Models
{
    public class GradeSubject
    {
        public int Id { get; set; }

        public int SubjectId { get; set; }
        public Subject Subject{ get; set; }
        
        public int BoletimId { get; set; }
        public Boletim Boletim { get; set; }
    }
}