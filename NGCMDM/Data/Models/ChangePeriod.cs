using System.Xml.Linq;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Runtime.ConstrainedExecution;

namespace NGCMDM.Data.Models
{
    public class ChangePeriod : BaseEntity
    {
        [Key]
        public Guid Guid { get; set; } 
        public string? CPName { get; set; }

        [Column(TypeName = "Date")]
        public DateTime ValidFromDate { get; set; }

        [Column(TypeName = "Date")]
        public DateTime ValidToDate { get; set; }
        public string? Note { get; set; }
    }
}
