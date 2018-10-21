using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;

namespace Hola.Models
{
    public class HolaContext : IdentityDbContext
    {
        static HolaContext()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<HolaContext>());
        }
        public HolaContext() : base("DefaultConnection"){}
        public DbSet<Language> Languages { get; set; }
        public DbSet<Word> Words { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<User_Words> User_Words { get; set; }

        #region LegacyCode
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<User_Words>()
        //        .HasRequired(uw => uw.ApplicationUser)
        //        .WithMany(/*c => c.User_Words.*/)
        //        .HasForeignKey(uw => new { uw.ApplicationUserID, uw.LanguageID, uw.Level, uw.WordID });

        //    modelBuilder.Entity<User_Words>()
        //        .HasKey(uw => new { uw.ApplicationUserID, uw.LanguageID, uw.Level, uw.WordID });

        //    modelBuilder.Entity<Word>()
        //        .HasRequired(w => w.Language)
        //        .WithMany(l => l.Words)
        //        .HasForeignKey(w => new { w.LanguageID, w.Level, w.WordID });

        //    modelBuilder.Entity<Word>()
        //        .HasKey(w => new { w.LanguageID, w.Level, w.WordID });

        //    modelBuilder.Entity<Word>()
        //        .HasRequired(c => c.Language)
        //        .WithMany()
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<User_Words>()
        //        .HasRequired(c => c.Word)
        //        .WithMany()
        //        .WillCascadeOnDelete(false);


        //    modelBuilder.Entity<ApplicationUser>()
        //        .HasRequired(t => t.User_Words)
        //        .WithRequiredPrincipal(t => t);

        //    //modelBuilder.Entity<ApplicationUser>()
        //    //    .HasOptional(x => x.);
        //    //.WithMany(x => x.ApplicationUser);
        //}
        #endregion

        public System.Data.Entity.DbSet<Hola.Models.ApplicationUser> IdentityUsers { get; set; }
    }
}