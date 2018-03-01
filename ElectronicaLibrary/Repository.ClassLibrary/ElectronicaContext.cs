using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Electronica.Entity;
namespace Electronica.Repository
{
 
        public class ElectronicaContext : DbContext
        {
            public ElectronicaContext() : base("ElectronicaDB")
            {
             Database.SetInitializer<ElectronicaContext>(new DropCreateDatabaseIfModelChanges<ElectronicaContext>());           
            }
            public virtual DbSet<Member> Members { get; set; }
            public virtual DbSet<Event> Events { get; set; }
            public virtual DbSet<Enrollment> Enrollments { get; set; }
            public virtual DbSet<Topic> Topics { get; set; }
            public virtual DbSet<Location> Locations { get; set; }
            public virtual DbSet<Promo> Promos { get; set; }
            public virtual DbSet<Admin> Admins { get; set; }
            public virtual DbSet<Login> Logins { get; set; }
            public virtual DbSet<Skill> Skills { get; set; }
            public virtual DbSet<SpeakerProfile> SpeakerProfiles { get; set; }
            public virtual DbSet<SpeakerSkillMap> SpeakerSkillMaps { get; set; }
            public virtual DbSet<Prerequisite> Prerequisites { get; set; }

        }
    }
