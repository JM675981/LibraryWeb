using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryWeb.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    BookID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Count = table.Column<int>(type: "int", nullable: false),
                    AddedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastEditUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.BookID);
                });

            migrationBuilder.CreateTable(
                name: "Loan",
                columns: table => new
                {
                    LoanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    DateLoaned = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsLoaned = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loan", x => x.LoanID);
                    table.ForeignKey(
                        name: "FK_Loan_Book_BookID",
                        column: x => x.BookID,
                        principalTable: "Book",
                        principalColumn: "BookID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", "693e9bd9-ff93-43c5-9716-f3249a56361e", "User", null },
                    { "2", "607d2f42-0a96-440e-bba2-eb9f336ececa", "Librarian", null },
                    { "3", "cadf916f-fe6c-4463-a9b0-8ccbbaaec989", "Admin", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "38b276e9-b56f-404f-9571-86c49ab67ac7", 0, "6c433734-fd38-4ac9-b330-358b5ca6818e", "Alucard@Bellm.ont", true, true, null, "ALUCARD@BELLM.ONT", "ALUCARD@BELLM.ONT", "AQAAAAEAACcQAAAAEKaGJBa5r1CrNOhfTmGGm5yRJUXkEV54S5IKQ80pRIuOV5o+E0wmp+sbhBqWaol86w==", null, false, "523bda9b-6b4f-43fd-acf3-4a5b20b196df", false, "Alucard@Bellm.ont" },
                    { "ba9c50d2-92ad-448a-aff3-a9ec499b44f0", 0, "af825618-1d53-4a6a-80b2-2adc9e183955", "Richter@Bellm.ont", true, true, null, "RICHTER@BELLM.ONT", "RICHTER@BELLM.ONT", "AQAAAAEAACcQAAAAEHRUP5p/bTu7xSfgmUsTiev430/spNa/WjMsqoEhmeu9FFIwGlnrbSag8cM/kkG7yQ==", null, false, "606a22bc-5b4a-4b73-a0bb-95399dc183a9", false, "Richter@Bellm.ont" },
                    { "e2eaf6fb-be20-4b9b-a071-c17566a4a6f8", 0, "9a83ea55-f3e5-40a1-9a1e-d19e20f2fd05", "Dracula@Bellm.ont", true, true, null, "DRACULA@BELLM.ONT", "DRACULA@BELLM.ONT", "AQAAAAEAACcQAAAAECJnq9R8xvlsep3yiu19ZEesdditrQk/QyegDkQX9ZzDXBLS8A95Dri75heqZBC0BQ==", null, false, "b84ddbd9-48c0-42cb-8185-9a854c31294d", false, "Dracula@Bellm.ont" }
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookID", "AddedUser", "BookDescription", "BookTitle", "Count", "EditDate", "LastEditUser" },
                values: new object[,]
                {
                    { 1, "Richter@Bellm.ont", "The professor investigates the mystery of the golden apple", "Professor Layton and the Curious Village", 1, new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, "Richter@Bellm.ont", "The professor tries to solve the mystery of a box that kills any who opens it", "Professor Layton and the Diabolical Box", 1, new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, "Richter@Bellm.ont", "The professor gets a mysterious letter from a person claiming to be from the future", "Professor Layton and the Unwound Future", 1, new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "38b276e9-b56f-404f-9571-86c49ab67ac7" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2", "ba9c50d2-92ad-448a-aff3-a9ec499b44f0" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3", "e2eaf6fb-be20-4b9b-a071-c17566a4a6f8" });

            migrationBuilder.CreateIndex(
                name: "IX_Loan_BookID",
                table: "Loan",
                column: "BookID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Loan");

            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "38b276e9-b56f-404f-9571-86c49ab67ac7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "ba9c50d2-92ad-448a-aff3-a9ec499b44f0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "e2eaf6fb-be20-4b9b-a071-c17566a4a6f8" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38b276e9-b56f-404f-9571-86c49ab67ac7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ba9c50d2-92ad-448a-aff3-a9ec499b44f0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2eaf6fb-be20-4b9b-a071-c17566a4a6f8");
        }
    }
}
