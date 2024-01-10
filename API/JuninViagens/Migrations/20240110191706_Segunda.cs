using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JuninViagens.Migrations
{
    /// <inheritdoc />
    public partial class Segunda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "clientes",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "cepCli", "enderecoCli", "nomeCli" },
                values: new object[] { "85960000", "Rua Amilton 13", "Junio Henrique" });

            migrationBuilder.InsertData(
                table: "clientes",
                columns: new[] { "id", "EmailCli", "cepCli", "enderecoCli", "nomeCli" },
                values: new object[,]
                {
                    { 2, "anaclara@gmail", "85960000", "Rua das Flores 130", "Ana Clara" },
                    { 3, "mduarda@gmail", "85960000", "Rua XV de Novembro 4545", "Maria Eduarda" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "clientes",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "clientes",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "clientes",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "cepCli", "enderecoCli", "nomeCli" },
                values: new object[] { "454545", "rua amilton 13", "Junio" });
        }
    }
}
