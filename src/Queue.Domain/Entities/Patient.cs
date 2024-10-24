using Queue.Domain.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Domain.Entities
{
    public class Patient: User
    {
        public DateTime DateOfBirth { get; set; }


        public virtual ICollection<PatientQueue>? Queues { get; set; }
    }
}
