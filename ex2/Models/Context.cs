﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ex2.Models
{
    public class Context
    {
        public DbSet<UserAccount> userAccounts { set; get; }
    }
}