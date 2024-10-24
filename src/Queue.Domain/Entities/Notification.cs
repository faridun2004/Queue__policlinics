using Queue.Domain.BaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Domain.Entities
{
    public class Notification: User
    {
        [ForeignKey(nameof(Patient))]
        public Guid PattientId { get; set; }
        public string? Message { get; set; }
        public bool? IsRead { get; set; }
        public DateTime SentAt { get; set; }

        public virtual Patient? Patient { get; set; }
    }
}
