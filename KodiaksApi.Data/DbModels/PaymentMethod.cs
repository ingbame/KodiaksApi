using System;
using System.Collections.Generic;

namespace KodiaksApi.Data.DbModels
{
    public partial class PaymentMethod
    {
        public PaymentMethod()
        {
            Movements = new HashSet<Movement>();
        }

        public short MethodId { get; set; }
        public string MethodDesc { get; set; }

        public virtual ICollection<Movement> Movements { get; set; }
    }
}
