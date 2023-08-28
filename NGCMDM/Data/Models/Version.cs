using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NGCMDM.Data.Models
{
    public class Version : BaseEntity
    {
        [Key]
        public Guid CamosGuid { get; set; }
        public string? Note { get; set; }
        public string? VersionName { get; set; }
        public Boolean BetaTesting { get; set; }
        public short VersionHigh { get; set; }
        public short VersionLow { get; set; }
        public short VersionPatch { get; set; }
        public Guid? CPRelID { get; set; }
        public Guid? ProductMasterRelID { get; set; }

        [ForeignKey("CPRelID")]
        public ChangePeriod? ChangePeriod { get; set; }

        [ForeignKey("ProductMasterRelID")]
        public ProductMaster? ProductMaster { get; set; }

    }
}
