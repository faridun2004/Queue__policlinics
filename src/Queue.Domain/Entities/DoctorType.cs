using Queue.Domain.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Domain.Entities
{
    public class DoctorType: BaseEntity
    {
        public string? TypeName {  get; set; }
        public string? Description { get; set; }
    }
}
