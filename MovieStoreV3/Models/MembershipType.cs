﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieStoreV3.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }

        public short SignupFee { get; set; }

        public byte DurationInMonths { get; set; }

        public byte DiscountRate { get; set; }
    }
}