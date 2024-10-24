using Queue.Domain.BaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Domain.Entities
{
    public class Doctor: BaseEntity
    {
        public string? Name {  get; set; }
        public string? NumberPhone {  get; set; }
        [ForeignKey(nameof(DoctorType))]
        public Guid DoctorTypeId { get; set; }

        public Guid ClinicId { get; set; }

        public virtual Clinic? Clinic { get; set; } 
        public virtual ICollection<PatientQueue>? Queues { get; set; }
    }
}
