using Microsoft.EntityFrameworkCore;
using NewYearsResolutionShared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewYearsResolutionAPI.DataAccess
{
    public class ResolutionsDbContext:DbContext
    {
        public ResolutionsDbContext(DbContextOptions<ResolutionsDbContext> options) : base(options)
        {

        }

        public DbSet<Resolution> Resolutions { get; set; }
        public DbSet<LoggedMetric> Entries { get; set; }
    }
}
