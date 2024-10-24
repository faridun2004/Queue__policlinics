using Queue.Domain.BaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Domain.Entities
{
    public class PatientQueue: BaseEntity
    {
        [ForeignKey(nameof(Doctor))]
        public Guid DoctorId {  get; set; }
        [ForeignKey(nameof(Patient))]
        public Guid PatientId { get; set; }
        [ForeignKey(nameof(Clinic))]
        public Guid ClinicId { get; set; }
        public int QueueNumber {  get; set; }


        public virtual Doctor? Doctor { get; set; }
        public virtual Patient? Patient { get; set; }
        public virtual Clinic? Clinic { get; set; }
    }
}
