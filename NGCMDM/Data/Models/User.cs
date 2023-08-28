using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NGCMDM.Data.Models
{

    public class User : BaseEntity
    {
        [Key]
        public Guid Guid { get; set; }
        public Guid? SettingsID { get; set; }

        [ForeignKey("SettingsID")]
        public UserSetting? UserSettings { get; set; }
        public string? UserName { get; set; }
        public string? Prename { get; set; }
        public string? Surname { get; set; }
        public string? Email { get; set; }
        public string? State { get; set; }
        public string? SalesOrg { get; set; }
    }
}
