using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MillowProject.Model
{
    public class Company
    {
        [Key]
        public int Id { get; set; }

        public string CompanyName { get; set; }
        public string Jobs { get; set; }

        public string PhoneNo { get; set; }

        public string employeeName {get;set; }
    }
}
