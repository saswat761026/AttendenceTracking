namespace Tracking.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AttendenceTracking : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CmRecords",
                c => new
                    {
                        Mid = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        PhoneNo = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Gender = c.String(nullable: false),
                        Photograph = c.Binary(),
                    })
                .PrimaryKey(t => t.Mid);
            
            CreateTable(
                "dbo.DefaultersCounts",
                c => new
                    {
                        Count_Id = c.Int(nullable: false, identity: true),
                        Mid = c.String(nullable: false),
                        LateSwipe = c.Int(nullable: false),
                        NotSwipe = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Count_Id);
            
            CreateTable(
                "dbo.GlcSwipes",
                c => new
                    {
                        Swipe_id = c.Int(nullable: false, identity: true),
                        Mid = c.String(nullable: false),
                        Location = c.String(nullable: false),
                        I_O = c.String(nullable: false),
                        Datetime = c.DateTime(nullable: false),
                        Swipetype = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Swipe_id);
            
            CreateTable(
                "dbo.LeadDetails",
                c => new
                    {
                        LeadDetail_Id = c.Int(nullable: false, identity: true),
                        Mid = c.String(nullable: false),
                        LeadName = c.String(nullable: false),
                        LeadEmail = c.String(nullable: false),
                        AllocatedSpace = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.LeadDetail_Id);
            
            CreateTable(
                "dbo.LoginCredentials",
                c => new
                    {
                        Serial_Id = c.Int(nullable: false, identity: true),
                        Mid = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Serial_Id);
            
            CreateTable(
                "dbo.Residences",
                c => new
                    {
                        Residence_id = c.Int(nullable: false, identity: true),
                        Mid = c.String(nullable: false),
                        Blockname = c.String(nullable: false),
                        Floorname = c.String(nullable: false),
                        Unitname = c.String(nullable: false),
                        Roomname = c.String(nullable: false),
                        Bedname = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Residence_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Residences");
            DropTable("dbo.LoginCredentials");
            DropTable("dbo.LeadDetails");
            DropTable("dbo.GlcSwipes");
            DropTable("dbo.DefaultersCounts");
            DropTable("dbo.CmRecords");
        }
    }
}
