﻿using System;
using System.Collections.Generic;

namespace KodiaksApi.Data.DbModels
{
    public partial class Member
    {
        public Member()
        {
            Bills = new HashSet<Bill>();
            Incomes = new HashSet<Income>();
        }

        public long MemberId { get; set; }
        public long UserId { get; set; }
        public string FullName { get; set; }
        public string NickName { get; set; }
        public int ShirtNumber { get; set; }
        public short BtsideId { get; set; }
        public string PhotoUrl { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public string CellPhoneNumber { get; set; }

        public virtual BattingThrowingSide Btside { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Bill> Bills { get; set; }
        public virtual ICollection<Income> Incomes { get; set; }
    }
}
