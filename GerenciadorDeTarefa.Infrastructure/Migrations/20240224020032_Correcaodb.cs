using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciadorDeTarefa.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Correcaodb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "pessoa",
                columns: table => new
                {
                    id_pessoa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    pessoa_nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cpf = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    data_nascimento = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    telefone = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_pessoa", x => x.id_pessoa);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tarefa",
                columns: table => new
                {
                    tarefa_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    responsavel_tarefa_id_pessoa = table.Column<int>(type: "int", nullable: false),
                    tarefa_descriscao = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    data_inicio = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    data_conclusao_esperada = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    data_conclusao = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    enum_categoria_tarefa = table.Column<int>(type: "int", nullable: false),
                    categoria_tarefa_descricao = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    enum_prioridade_enum = table.Column<int>(type: "int", nullable: false),
                    prioridade_descriscao = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    status = table.Column<int>(type: "int", nullable: false),
                    tarefa_concluida = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tarefa", x => x.tarefa_id);
                    table.ForeignKey(
                        name: "fk_tarefa_pessoa_responsavel_tarefa_id_pessoa",
                        column: x => x.responsavel_tarefa_id_pessoa,
                        principalTable: "pessoa",
                        principalColumn: "id_pessoa",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "ix_tarefa_responsavel_tarefa_id_pessoa",
                table: "tarefa",
                column: "responsavel_tarefa_id_pessoa");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tarefa");

            migrationBuilder.DropTable(
                name: "pessoa");
        }
    }
}
