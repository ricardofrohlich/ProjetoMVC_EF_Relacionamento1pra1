using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Relacionamento1pra1.Migrations
{
    /// <inheritdoc />
    public partial class mudando : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enderecos_Pessoass_EnderecoId",
                table: "Enderecos");

            migrationBuilder.AlterColumn<int>(
                name: "EnderecoId",
                table: "Enderecos",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.CreateIndex(
                name: "IX_Enderecos_PessoaId",
                table: "Enderecos",
                column: "PessoaId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Enderecos_Pessoass_PessoaId",
                table: "Enderecos",
                column: "PessoaId",
                principalTable: "Pessoass",
                principalColumn: "PessoaId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enderecos_Pessoass_PessoaId",
                table: "Enderecos");

            migrationBuilder.DropIndex(
                name: "IX_Enderecos_PessoaId",
                table: "Enderecos");

            migrationBuilder.AlterColumn<int>(
                name: "EnderecoId",
                table: "Enderecos",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddForeignKey(
                name: "FK_Enderecos_Pessoass_EnderecoId",
                table: "Enderecos",
                column: "EnderecoId",
                principalTable: "Pessoass",
                principalColumn: "PessoaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
