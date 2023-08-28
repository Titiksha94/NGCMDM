using System.ComponentModel.DataAnnotations;

namespace NGCMDM.Data.Models
{
    public class UserSetting : BaseEntity
    {
        [Key]
        public Guid Guid { get; set; }
        public string? Language { get; set; }
        public bool ShowLockIcons { get; set; }
        public bool ShowTechnicalNames { get; set; }
        public byte[]? Avatar { get; set; }
        public bool ShowAbbreviations { get; set; }
    }
}
