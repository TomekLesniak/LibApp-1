using Microsoft.EntityFrameworkCore.Migrations;

namespace LibApp.Data.Migrations
{
    public partial class SetNameOfMembershipTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE MembershipTypes set Name = 'Pay as You go' where Id = 1");
            migrationBuilder.Sql("UPDATE MembershipTypes set Name = 'Monthly' where Id = 2");
            migrationBuilder.Sql("UPDATE MembershipTypes set Name = 'Quarterly' where Id = 3");
            migrationBuilder.Sql("UPDATE MembershipTypes set Name = 'Yearly' where Id = 4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
