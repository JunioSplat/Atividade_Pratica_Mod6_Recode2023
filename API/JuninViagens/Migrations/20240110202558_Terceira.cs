using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JuninViagens.Migrations
{
    /// <inheritdoc />
    public partial class Terceira : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "clientes",
                columns: new[] { "id", "EmailCli", "cepCli", "enderecoCli", "nomeCli" },
                values: new object[] { 4, "carlosfernando@gmail", "85960000", "Rua Santana 4545", "Carlos Fernando" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "clientes",
                keyColumn: "id",
                keyValue: 4);
        }
    }
}
