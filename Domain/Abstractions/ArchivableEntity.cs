using System.Text.Json.Serialization;

namespace Domain.Abstractions
{
    public interface ArchivableEntity<T> : IOwnerBaseEntity<T>
         where T : struct
    {
        public  T? DeletedByUserId { get; set; }
        public  DateTime? DeletedDate { get; set; }
    }
}
