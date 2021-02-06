namespace SocialMedia.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class trial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reply", "Comment_CommentId", c => c.Int());
            CreateIndex("dbo.Reply", "Comment_CommentId");
            AddForeignKey("dbo.Reply", "Comment_CommentId", "dbo.Comment", "CommentId");
            DropTable("dbo.User");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Email = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.Reply", "Comment_CommentId", "dbo.Comment");
            DropIndex("dbo.Reply", new[] { "Comment_CommentId" });
            DropColumn("dbo.Reply", "Comment_CommentId");
        }
    }
}
