using System.Text.Json.Serialization;

namespace Domain.Abstractions
{
    public interface IOwnerBaseEntity<T> : IEntity<T>
    {
        public T CreatedByUserId { get; set; }
        public DateTime? CreatedDate { get; set; }

        public T UpdatedByUserId { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
