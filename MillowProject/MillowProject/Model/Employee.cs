using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MillowProject.Model
{
    public class Employee
    {
        [Key]
        public int CandidateId { get; set; }

        public string CandidateName { get; set; }

        public string College { get; set; }

        public string PhoneNo { get; set; }

    }
}
