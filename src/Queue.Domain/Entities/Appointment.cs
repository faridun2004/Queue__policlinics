using Queue.Domain.BaseEntities;
using Queue.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Domain.Entities
{
    public class Appointment: BaseEntity
    {
        [ForeignKey(nameof(Patient))]
        public Guid PatientId { get; set; }
        [ForeignKey(nameof(DoctorType))]
        public Guid DoctorTypeId { get; set; }
        [ForeignKey(nameof(Clinic))]
        public Guid ClinicId { get; set; }  

        public DateTime AppointmentDate {  get; set; }
        public AppointmentStatus AppointmentStatus {  get; set; }
    }
}
