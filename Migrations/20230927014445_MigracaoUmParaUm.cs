using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoUmParaUm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.AddColumn<int>(
                name: "PersonagemId",
                table: "TB_ARMAS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 1,
                column: "PersonagemId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 2,
                column: "PersonagemId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 3,
                column: "PersonagemId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 4,
                column: "PersonagemId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 5,
                column: "PersonagemId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 6,
                column: "PersonagemId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 7,
                column: "PersonagemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 224, 242, 106, 195, 159, 34, 220, 154, 152, 19, 213, 192, 150, 182, 113, 46, 12, 69, 42, 112, 110, 24, 75, 159, 168, 151, 157, 210, 59, 109, 48, 52, 136, 215, 49, 52, 61, 39, 211, 184, 70, 219, 33, 39, 128, 132, 65, 64, 50, 118, 186, 143, 181, 149, 18, 11, 105, 239, 140, 51, 119, 35, 150, 15 }, new byte[] { 237, 182, 193, 221, 68, 93, 244, 42, 250, 252, 181, 24, 165, 38, 65, 122, 7, 79, 109, 227, 0, 12, 60, 234, 97, 27, 229, 224, 124, 87, 106, 204, 57, 215, 127, 55, 76, 204, 243, 196, 120, 201, 128, 158, 129, 249, 161, 165, 34, 55, 5, 252, 129, 45, 188, 244, 208, 211, 51, 224, 115, 89, 181, 29, 235, 202, 108, 219, 57, 96, 57, 80, 55, 141, 120, 202, 109, 177, 33, 132, 64, 161, 191, 255, 181, 136, 252, 41, 75, 161, 88, 202, 87, 21, 207, 101, 86, 41, 16, 112, 71, 8, 132, 181, 45, 129, 87, 20, 146, 7, 180, 100, 24, 191, 227, 81, 162, 7, 242, 96, 198, 152, 162, 216, 223, 125, 186, 208 } });

            migrationBuilder.CreateIndex(
                name: "IX_TB_ARMAS_PersonagemId",
                table: "TB_ARMAS",
                column: "PersonagemId",
                unique: true);

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

            migrationBuilder.DropIndex(
                name: "IX_TB_ARMAS_PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.DropColumn(
                name: "PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.InsertData(
                table: "TB_ARMAS",
                columns: new[] { "Id", "Dano", "Nome" },
                values: new object[,]
                {
                    { 8, 8, "Garras" },
                    { 9, 15, "Cajado" },
                    { 10, 15, "Talismã" },
                    { 11, 10, "Arco" },
                    { 12, 13, "Besta" },
                    { 13, 15, "Arco Composto" },
                    { 14, 14, "Lança" },
                    { 15, 5, "Escudo" }
                });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 39, 219, 117, 89, 38, 1, 121, 182, 104, 146, 103, 105, 28, 100, 136, 109, 163, 3, 16, 133, 24, 201, 24, 249, 147, 46, 71, 184, 120, 85, 189, 37, 150, 194, 108, 235, 110, 74, 194, 146, 39, 8, 84, 176, 255, 35, 203, 244, 132, 133, 96, 156, 214, 63, 171, 217, 132, 93, 70, 35, 174, 54, 193, 93 }, new byte[] { 247, 171, 105, 3, 11, 190, 56, 254, 57, 207, 58, 145, 25, 236, 83, 133, 96, 102, 228, 230, 218, 136, 64, 72, 72, 29, 40, 142, 30, 88, 252, 19, 55, 29, 237, 75, 116, 201, 220, 20, 11, 101, 147, 244, 70, 217, 229, 102, 181, 58, 97, 103, 189, 59, 48, 244, 28, 34, 102, 239, 34, 254, 208, 119, 160, 41, 84, 35, 236, 158, 111, 91, 199, 109, 225, 88, 234, 167, 246, 109, 142, 108, 252, 61, 7, 22, 40, 136, 60, 32, 108, 207, 24, 55, 123, 200, 3, 215, 203, 212, 95, 115, 234, 60, 225, 76, 244, 122, 79, 244, 138, 4, 113, 208, 190, 40, 184, 162, 26, 144, 181, 28, 85, 40, 73, 106, 210, 121 } });
        }
    }
}
