using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Domain
{
    public class Order : IIdentifier<int>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string CustomerId { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

    }

}
