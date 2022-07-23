using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DDona.JaReclamouHoje.Infra.Migrations
{
    public partial class novas_tabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pessoa",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    NomeDeUsuario = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reclamacao",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PessoaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AssuntoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reclamacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reclamacao_Assunto_AssuntoId",
                        column: x => x.AssuntoId,
                        principalTable: "Assunto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reclamacao_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Complemento",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReclamacaoOriginalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Complemento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Complemento_Reclamacao_ReclamacaoOriginalId",
                        column: x => x.ReclamacaoOriginalId,
                        principalTable: "Reclamacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Complemento_ReclamacaoOriginalId",
                table: "Complemento",
                column: "ReclamacaoOriginalId");

            migrationBuilder.CreateIndex(
                name: "IX_Reclamacao_AssuntoId",
                table: "Reclamacao",
                column: "AssuntoId");

            migrationBuilder.CreateIndex(
                name: "IX_Reclamacao_PessoaId",
                table: "Reclamacao",
                column: "PessoaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Complemento");

            migrationBuilder.DropTable(
                name: "Reclamacao");

            migrationBuilder.DropTable(
                name: "Pessoa");
        }
    }
}
