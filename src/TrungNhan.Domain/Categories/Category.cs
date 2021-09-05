using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace TrungNhan.Categories
{
    public class Category : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public CategoryType Type { get; set; }
    }
}
