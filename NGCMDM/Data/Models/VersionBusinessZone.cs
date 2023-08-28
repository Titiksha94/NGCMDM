using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NGCMDM.Data.Models
{
    public class VersionBusinessZone :BaseEntity
    {
        [Key]
        public Guid CamosGuid { get; set; }
        public Guid VersionRelID { get; set; }
        public Guid BusinessZoneRelID { get; set; }

        [ForeignKey("VersionRelID")]
        public Version? Version { get; set; }

        [ForeignKey("BusinessZoneRelID")]
        public BusinessZone? BusinessZone { get; set; }
    }
}
