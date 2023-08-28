using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NGCMDM.Data.Models
{
    public class VersionSalesOrg :BaseEntity
    {
        [Key]
        public Guid CamosGuid { get; set; }
        public Guid VersionRelID { get; set; }
        public Guid? SalesOrgRelID { get; set; }

        [ForeignKey("VersionRelID")]
        public Version? Version { get; set; }

        [ForeignKey("SalesOrgRelID")]
        public SalesOrg? SalesOrg { get; set; }

    }
}
