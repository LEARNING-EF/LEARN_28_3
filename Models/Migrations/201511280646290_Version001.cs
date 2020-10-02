namespace Models.Migrations
{
	using System.Data.Entity.Migrations;

	public partial class Version001 : DbMigration
	{
		public override void Up()
		{
			AddColumn("dbo.People", "SomeProperty", c => c.String());
		}

		public override void Down()
		{
			DropColumn("dbo.People", "SomeProperty");
		}
	}
}
