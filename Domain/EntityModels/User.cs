using Domain.Abstractions;

namespace Domain.EntityModels
{
    public class User : IdentityUser<int>, ArchivableEntity<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DisplayName { get; set; }
        public bool Inactive { get; set; }
        public int DeletedByUserId { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int CreatedByUserId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int UpdatedByUserId { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
