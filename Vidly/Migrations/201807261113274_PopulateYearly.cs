namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateYearly : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name ='Yearly' WHERE DurationInMonths > 12 OR DurationInMonths = 12 ");
        }
        
        public override void Down()
        {
        }
    }
}
