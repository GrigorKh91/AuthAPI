using Domain.Abstractions;

namespace Domain.EntityModels
{
    public class Role : IdentityRole<int>, ArchivableEntity<int>
    {
        public string Description { get; set; }
        public bool IsPublic { get; set; } = false;
        public int Index { get; set; }
        public bool Inactive { get; set; }
        public string Key { get; set; }
        public int DeletedByUserId { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int CreatedByUserId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int UpdatedByUserId { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
