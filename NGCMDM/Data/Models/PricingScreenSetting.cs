using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NGCMDM.Data.Models
{
    public class PricingScreenSetting : BaseEntity
    {

        [Key]
        public Guid CamosGuid { get; set; }
        public bool IsTotalSumVisible { get; set; }
        public bool IsDeltaPricingActive { get; set; }
        public Guid? SalesOrgRelID { get; set; }

        [ForeignKey("SalesOrgRelID")]
        public SalesOrg? SalesOrg { get; set; }

    }
}
