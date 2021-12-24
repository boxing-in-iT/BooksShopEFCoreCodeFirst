using Microsoft.EntityFrameworkCore.Migrations;

namespace BooksShop.DAL.Migrations
{
    public partial class hashPasswords1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b333929-f974-444e-a8d3-68f50a0459c0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b4fe4ee-1ee6-4856-a30a-6d82961e0196", "AQAAAAEAACcQAAAAEJTx9VLktkPws6sjMgpDJr6rB3NHirE2XPAcGn/Au7AkMe1LeoIGJ1sDy5OhX/W1tw==", "d05403bc-bdf2-49b4-90a3-7337efb4a1ac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "61dfb9e3-1c27-424a-9963-9586ca110220",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30400dd7-f2cc-4f4e-8c0e-d458589cdb08", "AQAAAAEAACcQAAAAEGeVGKlN+XaW6Tisuto97avC+MSES0TkhjBLVNYs8RfQqLtKnBi5RRmU022z/BAPDw==", "5c6a9c30-9f10-4330-b00a-07fba3386802" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a36b02e1-81a9-47f4-89b6-d33c4f40ed5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe2c5ca5-08dc-4c7c-afb8-f3c6d14f3aa0", "AQAAAAEAACcQAAAAEGuJKbZDDRiwEIv9bZVHLQRYCFCz+n7z5vy3Wwgzvs01A/62fKrTklLCLXW/sLwRxQ==", "843557ae-7268-4da5-adad-b87768e3f99e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b333929-f974-444e-a8d3-68f50a0459c0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b7b142b-8c53-4758-add3-0946e2e3f192", "AQAAAAEAACcQAAAAEGMAaPeAx2pweEAwzZQ8fzVHBlNsk8tbRB9R2NNCKHlgvxeNcX6cwMKATip23SlGYw==", "d35f5d7a-bdc5-4ff9-b3e3-af5fa25dd698" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "61dfb9e3-1c27-424a-9963-9586ca110220",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e684d644-0070-47e1-b59d-bc0182d6d6d6", "Password2", "56a6e829-5536-479e-b00b-09eb313952fe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a36b02e1-81a9-47f4-89b6-d33c4f40ed5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6ccc5b6-fe31-484b-9a50-9cb9b72934bf", "AQAAAAEAACcQAAAAEPPThESa/6dV7YayZEuUFRP3L6anPXpanbFOFX8bJatLJ+B2FKRBoM6vgXCbFaTEog==", "f6634c40-ee07-45f6-8dd0-4bae7f160ccb" });
        }
    }
}
