using System;

namespace Otus.Teaching.PromoCodeFactory.Core.Domain.Administration
{
    public class Role
        : BaseEntity
    {

        public const int NameMaxLength = 100;
        public const int DescriptionMaxLength = 300;

        public string Name { get; set; }

        public string Description { get; set; }
    }
}