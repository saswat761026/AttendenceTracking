using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracking.Entities;
using System.Data.Entity;

namespace Tracking.DataAccessLayer.DbContext
{
    class TrackingDbContext:System.Data.Entity.DbContext 
    {
        public TrackingDbContext() : base("name = AttendenceTrackingDb")
        {

        }

        public virtual DbSet<Tracking.Entities.GlcSwipe> glcswipes { get; set; }
        public virtual DbSet<Tracking.Entities.CmRecords> cmrecords { get; set; }
        public virtual DbSet<Tracking.Entities.DefaultersCount> defaulterscount { get; set; }
        public virtual DbSet<Tracking.Entities.LeadDetails> leaddetails { get; set; }
        public virtual DbSet<Tracking.Entities.LoginCredentials> logincredentials { get; set; }
        public virtual DbSet<Tracking.Entities.Residence> residence { get; set; }

    }
}
