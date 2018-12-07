﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StoreApp.Models
{
    public class StoreAppContext : DbContext, IStoreAppContext
    {

        public StoreAppContext() : base("name=StoreAppContext")
        {
        }

        public DbSet<Product> Products { get; set; }

        public void MarkAsModified(Product item)
        {
            Entry(item).State = EntityState.Modified;
        }
    }
}
