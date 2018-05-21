using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ChampionsLegends.Models {
    public class AppBD: DbContext {

        public AppBD() : base ("AppBD") { }

        public virtual DbSet<Abilities> Abilities { get; set; }
        public virtual DbSet<Champions> Champions { get; set; }
        //public virtual DbSet<FotosSkns> FotosSkns { get; set; }
        public virtual DbSet<Skins> Skins { get; set; }

    }
}