﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ecommerce.Entity
{
    public enum EnumOrderState
    {
        [Display(Name = "Waiting")]
        Waiting,
        [Display(Name = "Completed")]
        Completed
    }
}