using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoUmParaUm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonagemId",
                table: "Armas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 1,
                column: "PersonagemId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 2,
                column: "PersonagemId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 3,
                column: "PersonagemId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 4,
                column: "PersonagemId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 5,
                column: "PersonagemId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 6,
                column: "PersonagemId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 7,
                column: "PersonagemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 86, 102, 171, 58, 145, 136, 244, 204, 218, 127, 159, 86, 39, 41, 215, 237, 51, 199, 216, 230, 173, 202, 96, 89, 208, 255, 127, 46, 65, 132, 194, 137, 10, 102, 106, 115, 198, 227, 92, 91, 146, 53, 212, 248, 75, 156, 21, 235, 86, 212, 236, 53, 62, 58, 152, 109, 182, 29, 184, 175, 136, 165, 173, 224 }, new byte[] { 30, 77, 56, 79, 94, 172, 83, 216, 23, 210, 154, 25, 63, 34, 99, 102, 55, 174, 86, 253, 111, 39, 221, 127, 30, 195, 152, 41, 189, 167, 134, 54, 147, 130, 230, 117, 62, 40, 236, 18, 77, 150, 67, 3, 222, 211, 146, 6, 47, 13, 34, 62, 225, 153, 188, 13, 42, 78, 82, 229, 250, 175, 7, 236, 208, 178, 85, 202, 144, 189, 36, 131, 36, 224, 3, 89, 11, 37, 134, 228, 5, 86, 188, 44, 11, 80, 86, 151, 53, 6, 45, 158, 92, 222, 171, 151, 134, 115, 76, 240, 224, 51, 237, 4, 23, 74, 159, 211, 111, 78, 162, 225, 121, 2, 146, 146, 200, 186, 198, 163, 177, 9, 79, 116, 92, 196, 178, 128 } });

            migrationBuilder.CreateIndex(
                name: "IX_Armas_PersonagemId",
                table: "Armas",
                column: "PersonagemId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Armas_Personagens_PersonagemId",
                table: "Armas",
                column: "PersonagemId",
                principalTable: "Personagens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Armas_Personagens_PersonagemId",
                table: "Armas");

            migrationBuilder.DropIndex(
                name: "IX_Armas_PersonagemId",
                table: "Armas");

            migrationBuilder.DropColumn(
                name: "PersonagemId",
                table: "Armas");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 213, 21, 131, 178, 62, 245, 78, 179, 92, 133, 94, 48, 218, 44, 160, 223, 38, 111, 57, 106, 61, 75, 4, 66, 203, 87, 193, 23, 251, 141, 193, 200, 86, 20, 54, 91, 90, 85, 198, 134, 169, 172, 184, 219, 56, 112, 98, 134, 152, 224, 126, 243, 212, 231, 53, 129, 33, 129, 86, 120, 163, 166, 60, 144 }, new byte[] { 127, 230, 124, 224, 112, 132, 240, 137, 220, 18, 204, 147, 171, 151, 93, 65, 235, 83, 210, 24, 239, 143, 228, 44, 126, 220, 193, 118, 51, 57, 18, 173, 208, 151, 156, 251, 28, 102, 34, 34, 52, 97, 199, 52, 126, 189, 204, 38, 178, 73, 130, 158, 107, 103, 191, 30, 194, 70, 233, 204, 183, 99, 12, 216, 5, 220, 221, 222, 30, 146, 109, 76, 147, 25, 157, 6, 102, 85, 254, 238, 7, 217, 143, 3, 255, 130, 96, 5, 24, 20, 49, 9, 187, 73, 141, 211, 104, 197, 233, 135, 150, 31, 168, 40, 73, 137, 253, 107, 66, 190, 175, 89, 201, 100, 150, 165, 57, 98, 165, 227, 169, 32, 104, 209, 208, 42, 58, 31 } });
        }
    }
}
