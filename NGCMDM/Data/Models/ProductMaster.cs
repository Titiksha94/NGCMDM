using Microsoft.EntityFrameworkCore.Metadata.Internal;
using static System.Net.Mime.MediaTypeNames;
using System.Net.NetworkInformation;
using System;
using System.ComponentModel.DataAnnotations;

namespace NGCMDM.Data.Models
{
    public class ProductMaster :BaseEntity
    {
        [Key]
        public Guid CamosGuid { get; set; }
        public string? Name { get; set; }
        public string? KnbName { get; set; }
        public string? Description { get; set; }
        public Boolean Product { get; set; }
        public string? StartClass { get; set; }
        public string? Type { get; set; }
        public string? ProductDataSheet { get; set; }
        public byte[]? Image { get; set; }
        public string? ImageType { get; set; }

        //public Guid ProductCompatibility { get; set; }


    }
}
