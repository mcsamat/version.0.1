﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using version._0._1.Models;

namespace version._0._1.Data
{
    public class version_0_1_2Context : DbContext
    {
        public version_0_1_2Context (DbContextOptions<version_0_1_2Context> options)
            : base(options)
        {
        }

        public DbSet<version._0._1.Models.Trans> Trans { get; set; }
    }
}
