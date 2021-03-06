﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Week15_WardrobeProject_04192016.Models
{
    public class Week15_WardrobeProject_04192016Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Week15_WardrobeProject_04192016Context() : base("name=Week15_WardrobeProject_04192016Context")
        {
        }

        public System.Data.Entity.DbSet<Week15_WardrobeProject_04192016.Models.Accessory> Accessories { get; set; }

        public System.Data.Entity.DbSet<Week15_WardrobeProject_04192016.Models.Bottom> Bottoms { get; set; }

        public System.Data.Entity.DbSet<Week15_WardrobeProject_04192016.Models.Shoe> Shoes { get; set; }

        public System.Data.Entity.DbSet<Week15_WardrobeProject_04192016.Models.Top> Tops { get; set; }
    }
}
