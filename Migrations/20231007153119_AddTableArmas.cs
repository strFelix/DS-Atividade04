using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class AddTableArmas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Armas_TB_PERSONAGENS_PersonagemId",
                table: "Armas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Armas",
                table: "Armas");

            migrationBuilder.RenameTable(
                name: "Armas",
                newName: "TB_ARMAS");

            migrationBuilder.RenameIndex(
                name: "IX_Armas_PersonagemId",
                table: "TB_ARMAS",
                newName: "IX_TB_ARMAS_PersonagemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_ARMAS",
                table: "TB_ARMAS",
                column: "Id");

            migrationBuilder.InsertData(
                table: "TB_ARMAS",
                columns: new[] { "Id", "Dano", "Nome", "PersonagemId" },
                values: new object[,]
                {
                    { 1, 15, "Espada", 1 },
                    { 2, 25, "Espada Pesada", 2 },
                    { 3, 20, "Machado", 3 },
                    { 4, 30, "Machado Pesado", 4 },
                    { 5, 17, "Massa", 5 },
                    { 6, 28, "Massa Pesada", 6 },
                    { 7, 10, "Adaga", 7 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_TB_ARMAS_TB_PERSONAGENS_PersonagemId",
                table: "TB_ARMAS",
                column: "PersonagemId",
                principalTable: "TB_PERSONAGENS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_ARMAS_TB_PERSONAGENS_PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_ARMAS",
                table: "TB_ARMAS");

            migrationBuilder.DeleteData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.RenameTable(
                name: "TB_ARMAS",
                newName: "Armas");

            migrationBuilder.RenameIndex(
                name: "IX_TB_ARMAS_PersonagemId",
                table: "Armas",
                newName: "IX_Armas_PersonagemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Armas",
                table: "Armas",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Armas_TB_PERSONAGENS_PersonagemId",
                table: "Armas",
                column: "PersonagemId",
                principalTable: "TB_PERSONAGENS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
