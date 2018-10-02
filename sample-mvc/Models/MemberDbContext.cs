using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Data.Entity;

namespace sample_mvc.Models
{
    public class MemberDbContext:DbContext
    {
        public MemberDbContext()
        {
            Database.SetInitializer<DbContext>(null);
        }
        public DbSet<Member> Members { get; set; }
    }

}