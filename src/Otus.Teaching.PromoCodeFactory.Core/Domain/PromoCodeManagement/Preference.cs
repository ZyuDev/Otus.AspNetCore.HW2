using System;

namespace Otus.Teaching.PromoCodeFactory.Core.Domain.PromoCodeManagement
{
    public class Preference
        :BaseEntity
    {

        public const int NameMaxLength = 100;

        public string Name { get; set; }
    }
}