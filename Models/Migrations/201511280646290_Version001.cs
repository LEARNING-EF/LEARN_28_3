namespace Models.Migrations
{
	using System.Data.Entity.Migrations;

	public partial class Version001 : DbMigration
	{
		public override void Up()
		{
			AddColumn("dbo.People", "SomeProperty", c => c.String());

			//AddColumn("dbo.People", "SomeRequiredProperty", c => c.String(defaultValue: "Hello", defaultValueSql: "Hello"));
		}

		public override void Down()
		{
			DropColumn("dbo.People", "SomeProperty");
		}
	}
}
