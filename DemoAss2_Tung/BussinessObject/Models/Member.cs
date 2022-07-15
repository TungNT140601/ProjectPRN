using System;
using System.Collections.Generic;

namespace BussinessObject.Models
{
    public partial class Member
    {
        public Member()
        {
            TblOrders = new HashSet<TblOrder>();
        }

        public int MemberId { get; set; }
        public string Email { get; set; } = null!;
        public string Companyname { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string Password { get; set; } = null!;

        public virtual ICollection<TblOrder> TblOrders { get; set; }
    }
}
