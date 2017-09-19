using Microsoft.EntityFrameworkCore;
using Mvc02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc02.Data {
    public class SubjectDb : DbContext {

        public SubjectDb(DbContextOptions<SubjectDb> options) : base(options) {
            //
        }
        public DbSet<Subject> Subjects { get; set; }

    }
}
