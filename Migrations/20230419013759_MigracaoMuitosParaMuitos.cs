using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoMuitosParaMuitos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Derrotas",
                table: "Personagens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Disputas",
                table: "Personagens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vitorias",
                table: "Personagens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Habilidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dano = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habilidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonagemHabilidades",
                columns: table => new
                {
                    PersonagemId = table.Column<int>(type: "int", nullable: false),
                    HabilidadeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonagemHabilidades", x => new { x.PersonagemId, x.HabilidadeId });
                    table.ForeignKey(
                        name: "FK_PersonagemHabilidades_Habilidades_HabilidadeId",
                        column: x => x.HabilidadeId,
                        principalTable: "Habilidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonagemHabilidades_Personagens_PersonagemId",
                        column: x => x.PersonagemId,
                        principalTable: "Personagens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Habilidades",
                columns: new[] { "Id", "Dano", "Nome" },
                values: new object[,]
                {
                    { 1, 39, "Adormecer" },
                    { 2, 41, "Congelar" },
                    { 3, 37, "Hipnotizar" }
                });

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 77, 247, 220, 189, 34, 245, 65, 243, 251, 229, 156, 20, 189, 70, 23, 136, 95, 157, 217, 111, 136, 39, 221, 51, 62, 227, 51, 2, 189, 148, 31, 251, 181, 101, 149, 250, 188, 107, 149, 37, 85, 241, 190, 27, 234, 83, 169, 38, 104, 7, 148, 187, 209, 208, 168, 62, 231, 38, 13, 66, 188, 227, 97, 131 }, new byte[] { 186, 8, 210, 166, 234, 83, 75, 85, 73, 116, 3, 172, 149, 73, 56, 235, 25, 225, 31, 93, 27, 62, 54, 238, 230, 207, 23, 51, 71, 241, 189, 150, 143, 143, 17, 83, 191, 190, 218, 233, 151, 169, 237, 106, 149, 249, 41, 53, 123, 255, 212, 189, 132, 76, 32, 111, 20, 48, 220, 84, 195, 87, 20, 63, 80, 88, 236, 131, 111, 46, 37, 72, 240, 68, 157, 93, 83, 192, 160, 43, 39, 71, 192, 29, 180, 96, 199, 200, 49, 153, 82, 39, 48, 172, 221, 72, 80, 222, 190, 34, 249, 153, 183, 95, 9, 58, 103, 113, 170, 124, 162, 48, 31, 236, 236, 194, 10, 63, 253, 145, 176, 72, 79, 82, 167, 37, 95, 139 } });

            migrationBuilder.InsertData(
                table: "PersonagemHabilidades",
                columns: new[] { "HabilidadeId", "PersonagemId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 3 },
                    { 3, 4 },
                    { 1, 5 },
                    { 2, 6 },
                    { 3, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonagemHabilidades_HabilidadeId",
                table: "PersonagemHabilidades",
                column: "HabilidadeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonagemHabilidades");

            migrationBuilder.DropTable(
                name: "Habilidades");

            migrationBuilder.DropColumn(
                name: "Derrotas",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "Disputas",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "Vitorias",
                table: "Personagens");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 86, 102, 171, 58, 145, 136, 244, 204, 218, 127, 159, 86, 39, 41, 215, 237, 51, 199, 216, 230, 173, 202, 96, 89, 208, 255, 127, 46, 65, 132, 194, 137, 10, 102, 106, 115, 198, 227, 92, 91, 146, 53, 212, 248, 75, 156, 21, 235, 86, 212, 236, 53, 62, 58, 152, 109, 182, 29, 184, 175, 136, 165, 173, 224 }, new byte[] { 30, 77, 56, 79, 94, 172, 83, 216, 23, 210, 154, 25, 63, 34, 99, 102, 55, 174, 86, 253, 111, 39, 221, 127, 30, 195, 152, 41, 189, 167, 134, 54, 147, 130, 230, 117, 62, 40, 236, 18, 77, 150, 67, 3, 222, 211, 146, 6, 47, 13, 34, 62, 225, 153, 188, 13, 42, 78, 82, 229, 250, 175, 7, 236, 208, 178, 85, 202, 144, 189, 36, 131, 36, 224, 3, 89, 11, 37, 134, 228, 5, 86, 188, 44, 11, 80, 86, 151, 53, 6, 45, 158, 92, 222, 171, 151, 134, 115, 76, 240, 224, 51, 237, 4, 23, 74, 159, 211, 111, 78, 162, 225, 121, 2, 146, 146, 200, 186, 198, 163, 177, 9, 79, 116, 92, 196, 178, 128 } });
        }
    }
}
