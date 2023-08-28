using System.ComponentModel.DataAnnotations;

namespace NGCMDM.Data.Models
{
    public class BusinessZone : BaseEntity
    {
        [Key]
        public Guid CamosGuid { get; set; }
        public string? BusinessZoneName { get; set; }

    }
}
