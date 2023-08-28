namespace NGCMDM.Data.Models
{
    public abstract class BaseEntity
    {
        public DateTime DateNew { get; set; }
        public DateTime DateChanged { get; set; }
        public string? UserNew { get; set; }
        public string? UserChanged { get; set; }
        public bool Deleted { get; set; }
    }
}
