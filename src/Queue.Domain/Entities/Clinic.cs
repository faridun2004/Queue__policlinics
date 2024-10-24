using Queue.Domain.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Domain.Entities
{
    public class Clinic: BaseEntity
    {
        public string? Name {  get; set; }
        public string? Country {  get; set; }
        public string? City { get; set; }
        public string? Street { get; set; }
        public string? PhoneNumber { get; set; }     
        public string? ClinicType { get; set; }
    }                   
}
