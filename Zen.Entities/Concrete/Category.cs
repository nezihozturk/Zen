using System;
using System.Collections.Generic;
using System.Text;
using Zen.Core.Entities;

namespace Zen.Entities.Concrete
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Description { get; set; }

    }
}
