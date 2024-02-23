using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciadorDeTarefa.Migrations
{
    /// <inheritdoc />
    public partial class correcao_tabelas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_tarefa_categoria_tarefas_categoria_tarefaid_categoria_tarefa",
                table: "tarefa");

            migrationBuilder.DropForeignKey(
                name: "fk_tarefa_prioridade_tarefa_prioridade_tarefa_id_prioridade_tar",
                table: "tarefa");

            migrationBuilder.DropTable(
                name: "categoria_tarefas");

            migrationBuilder.DropTable(
                name: "prioridade_tarefa");

            migrationBuilder.DropIndex(
                name: "ix_tarefa_categoria_tarefaid_categoria_tarefa",
                table: "tarefa");

            migrationBuilder.DropIndex(
                name: "ix_tarefa_prioridade_tarefa_id_prioridade_tarefa",
                table: "tarefa");

            migrationBuilder.DropColumn(
                name: "pessoa_sex",
                table: "pessoa");

            migrationBuilder.RenameColumn(
                name: "prioridade_tarefa_id_prioridade_tarefa",
                table: "tarefa",
                newName: "enum_prioridade_enum");

            migrationBuilder.RenameColumn(
                name: "categoria_tarefaid_categoria_tarefa",
                table: "tarefa",
                newName: "enum_categoria_tarefa");

            migrationBuilder.AddColumn<string>(
                name: "categoria_tarefa_descricao",
                table: "tarefa",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "prioridade_descriscao",
                table: "tarefa",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "categoria_tarefa_descricao",
                table: "tarefa");

            migrationBuilder.DropColumn(
                name: "prioridade_descriscao",
                table: "tarefa");

            migrationBuilder.RenameColumn(
                name: "enum_prioridade_enum",
                table: "tarefa",
                newName: "prioridade_tarefa_id_prioridade_tarefa");

            migrationBuilder.RenameColumn(
                name: "enum_categoria_tarefa",
                table: "tarefa",
                newName: "categoria_tarefaid_categoria_tarefa");

            migrationBuilder.AddColumn<string>(
                name: "pessoa_sex",
                table: "pessoa",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "categoria_tarefas",
                columns: table => new
                {
                    id_categoria_tarefa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    categoria_tarefa_descricao = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    enum_categoria_tarefa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_categoria_tarefas", x => x.id_categoria_tarefa);
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

            migrationBuilder.CreateIndex(
                name: "ix_tarefa_categoria_tarefaid_categoria_tarefa",
                table: "tarefa",
                column: "categoria_tarefaid_categoria_tarefa");

            migrationBuilder.CreateIndex(
                name: "ix_tarefa_prioridade_tarefa_id_prioridade_tarefa",
                table: "tarefa",
                column: "prioridade_tarefa_id_prioridade_tarefa");

            migrationBuilder.AddForeignKey(
                name: "fk_tarefa_categoria_tarefas_categoria_tarefaid_categoria_tarefa",
                table: "tarefa",
                column: "categoria_tarefaid_categoria_tarefa",
                principalTable: "categoria_tarefas",
                principalColumn: "id_categoria_tarefa",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_tarefa_prioridade_tarefa_prioridade_tarefa_id_prioridade_tar",
                table: "tarefa",
                column: "prioridade_tarefa_id_prioridade_tarefa",
                principalTable: "prioridade_tarefa",
                principalColumn: "id_prioridade_tarefa",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
