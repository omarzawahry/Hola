namespace Hola.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialContent : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Languages",
                c => new
                    {
                        LanguageID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Icon = c.String(),
                    })
                .PrimaryKey(t => t.LanguageID);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        LanguageID = c.Int(nullable: false),
                        Level = c.Int(nullable: false),
                        QuestionID = c.Int(nullable: false),
                        QuestionText = c.String(nullable: false),
                        QuestionEnglish = c.String(nullable: false),
                        QuestionImagePath = c.String(),
                        QuestionVoicePath = c.String(),
                        CorrectAnswer = c.String(nullable: false),
                        CorrectAnswerImagePath = c.String(),
                        CorrectAnswerVoicePath = c.String(),
                        ChoiceA = c.String(nullable: false),
                        ChoiceAVoicePath = c.String(),
                        ChoiceB = c.String(nullable: false),
                        ChoiceBVoicePath = c.String(),
                        ChoiceC = c.String(nullable: false),
                        ChoiceCVoicePath = c.String(),
                        ChoiceD = c.String(nullable: false),
                        ChoiceDVoicePath = c.String()
                    })
                .PrimaryKey(t => new { t.LanguageID, t.Level, t.QuestionID })
                .ForeignKey("dbo.Languages", t => t.LanguageID, cascadeDelete: true)
                .Index(t => t.LanguageID);
            
            CreateTable(
                "dbo.Words",
                c => new
                    {
                        LanguageID = c.Int(nullable: false),
                        Level = c.Int(nullable: false),
                        WordID = c.Int(nullable: false),
                        WordText = c.String(nullable: false),
                        WordEnglish = c.String(nullable: false),
                        ImagePath = c.String(),
                        VoicePath = c.String(),
                    })
                .PrimaryKey(t => new { t.LanguageID, t.Level, t.WordID })
                .ForeignKey("dbo.Languages", t => t.LanguageID, cascadeDelete: true)
                .Index(t => t.LanguageID);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.User_Words",
                c => new
                    {
                        ApplicationUserID = c.String(nullable: false, maxLength: 128),
                        LanguageID = c.Int(nullable: false),
                        Level = c.Int(nullable: false),
                        WordID = c.Int(nullable: false),
                        Mastery = c.Int(nullable: false),
                        LastVisited = c.DateTime(storeType: "date"),
                    })
                .PrimaryKey(t => new { t.ApplicationUserID, t.LanguageID, t.Level, t.WordID })
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUserID, cascadeDelete: true)
                .ForeignKey("dbo.Words", t => new { t.LanguageID, t.Level, t.WordID }, cascadeDelete: true)
                .Index(t => t.ApplicationUserID)
                .Index(t => new { t.LanguageID, t.Level, t.WordID });
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        DateOfBirth = c.DateTime(),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.User_Words", new[] { "LanguageID", "Level", "WordID" }, "dbo.Words");
            DropForeignKey("dbo.User_Words", "ApplicationUserID", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Words", "LanguageID", "dbo.Languages");
            DropForeignKey("dbo.Questions", "LanguageID", "dbo.Languages");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.User_Words", new[] { "LanguageID", "Level", "WordID" });
            DropIndex("dbo.User_Words", new[] { "ApplicationUserID" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Words", new[] { "LanguageID" });
            DropIndex("dbo.Questions", new[] { "LanguageID" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.User_Words");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Words");
            DropTable("dbo.Questions");
            DropTable("dbo.Languages");
        }
    }
}
