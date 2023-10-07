using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class AddTableUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_PERSONAGENS_Usuario_UsuarioId",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario");

            migrationBuilder.RenameTable(
                name: "Usuario",
                newName: "TB_USUARIOS");

            migrationBuilder.AlterColumn<string>(
                name: "Perfil",
                table: "TB_USUARIOS",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Jogador",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_USUARIOS",
                table: "TB_USUARIOS",
                column: "Id");

            migrationBuilder.InsertData(
                table: "TB_USUARIOS",
                columns: new[] { "Id", "DataAcesso", "Email", "Foto", "Latitude", "Longitude", "PasswordHash", "PasswordSalt", "Perfil", "Username" },
                values: new object[] { 1, null, "seuEmail@gmail.com", null, -23.520024100000001, -46.596497999999997, new byte[] { 233, 120, 20, 7, 121, 248, 126, 83, 115, 130, 106, 58, 179, 182, 61, 227, 233, 140, 126, 103, 23, 224, 59, 17, 47, 32, 114, 221, 231, 187, 196, 76, 225, 10, 176, 165, 188, 227, 255, 32, 61, 244, 7, 193, 5, 158, 189, 240, 153, 185, 166, 229, 62, 19, 27, 177, 40, 43, 62, 134, 35, 248, 54, 60 }, new byte[] { 244, 46, 37, 255, 142, 203, 162, 126, 119, 83, 176, 250, 173, 168, 236, 52, 61, 232, 200, 46, 67, 102, 106, 79, 169, 162, 21, 197, 45, 62, 251, 102, 90, 12, 149, 133, 161, 133, 17, 70, 108, 235, 12, 218, 32, 127, 129, 250, 198, 185, 154, 76, 99, 81, 228, 194, 138, 114, 101, 204, 18, 94, 207, 148, 55, 197, 25, 16, 48, 50, 23, 91, 12, 213, 233, 229, 68, 143, 207, 29, 110, 77, 244, 178, 92, 227, 179, 65, 105, 208, 204, 148, 212, 214, 243, 236, 195, 113, 215, 38, 161, 240, 105, 11, 38, 1, 41, 16, 126, 42, 137, 37, 12, 128, 179, 235, 27, 43, 82, 95, 69, 88, 6, 108, 226, 131, 37, 50 }, "Admin", "UsuarioAdmin" });

            migrationBuilder.AddForeignKey(
                name: "FK_TB_PERSONAGENS_TB_USUARIOS_UsuarioId",
                table: "TB_PERSONAGENS",
                column: "UsuarioId",
                principalTable: "TB_USUARIOS",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_PERSONAGENS_TB_USUARIOS_UsuarioId",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_USUARIOS",
                table: "TB_USUARIOS");

            migrationBuilder.DeleteData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.RenameTable(
                name: "TB_USUARIOS",
                newName: "Usuario");

            migrationBuilder.AlterColumn<string>(
                name: "Perfil",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Jogador");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_PERSONAGENS_Usuario_UsuarioId",
                table: "TB_PERSONAGENS",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id");
        }
    }
}
