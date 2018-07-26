namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatingName : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name ='Pay as you go' WHERE DurationInMonths = 0");
            Sql("UPDATE MembershipTypes SET Name ='Monthly' WHERE DurationInMonths < 12 AND DurationInMonths > 0  ");
            Sql("UPDATE MembershipTypes SET Name ='Yearly' WHERE DurationInMonths >= 12 ");
        }
        
        public override void Down()
        {
        }
    }
}
