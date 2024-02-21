using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciadorDeTarefa.Migrations
{
    /// <inheritdoc />
    public partial class newBanco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "categoria_tarefas",
                columns: table => new
                {
                    id_categoria_tarefa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    enum_categoria_tarefa = table.Column<int>(type: "int", nullable: false),
                    categoria_tarefa_descricao = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_categoria_tarefas", x => x.id_categoria_tarefa);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "pessoa",
                columns: table => new
                {
                    id_pessoa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    pessoa_nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pessoa_sex = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cpf = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    data_nascimento = table.Column<DateOnly>(type: "date", nullable: false),
                    telefone = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_pessoa", x => x.id_pessoa);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "prioridade_tarefa",
                columns: table => new
                {
                    id_prioridade_tarefa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    enum_prioridade_enum = table.Column<int>(type: "int", nullable: false),
                    prioridade_descriscao = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_prioridade_tarefa", x => x.id_prioridade_tarefa);
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
                    categoria_tarefaid_categoria_tarefa = table.Column<int>(type: "int", nullable: false),
                    prioridade_tarefa_id_prioridade_tarefa = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    tarefa_concluida = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tarefa", x => x.tarefa_id);
                    table.ForeignKey(
                        name: "fk_tarefa_categoria_tarefas_categoria_tarefaid_categoria_tarefa",
                        column: x => x.categoria_tarefaid_categoria_tarefa,
                        principalTable: "categoria_tarefas",
                        principalColumn: "id_categoria_tarefa",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_tarefa_pessoa_responsavel_tarefa_id_pessoa",
                        column: x => x.responsavel_tarefa_id_pessoa,
                        principalTable: "pessoa",
                        principalColumn: "id_pessoa",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_tarefa_prioridade_tarefa_prioridade_tarefa_id_prioridade_tar",
                        column: x => x.prioridade_tarefa_id_prioridade_tarefa,
                        principalTable: "prioridade_tarefa",
                        principalColumn: "id_prioridade_tarefa",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "ix_tarefa_categoria_tarefaid_categoria_tarefa",
                table: "tarefa",
                column: "categoria_tarefaid_categoria_tarefa");

            migrationBuilder.CreateIndex(
                name: "ix_tarefa_prioridade_tarefa_id_prioridade_tarefa",
                table: "tarefa",
                column: "prioridade_tarefa_id_prioridade_tarefa");

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
                name: "categoria_tarefas");

            migrationBuilder.DropTable(
                name: "pessoa");

            migrationBuilder.DropTable(
                name: "prioridade_tarefa");
        }
    }
}
