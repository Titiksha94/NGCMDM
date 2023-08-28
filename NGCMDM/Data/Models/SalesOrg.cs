using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NGCMDM.Data.Models
{
    public class SalesOrg : BaseEntity
    {
        [Key]
        public Guid CamosGuid { get; set; }       
        public string? BusinessZone { get; set; }
        public string? Name { get; set; }
        public string? SapNumber { get; set; }
        public Guid BusinessZoneRelID { get; set; }

        [ForeignKey("BusinessZoneRelID")]
        public BusinessZone? BusinessZoneRel { get; set; }

    }
}
