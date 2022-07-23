using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DDona.JaReclamouHoje.Infra.Migrations
{
    public partial class complemento_com_pessoa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "PessoaQueComplementouId",
                table: "Complemento",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Complemento_PessoaQueComplementouId",
                table: "Complemento",
                column: "PessoaQueComplementouId");

            migrationBuilder.AddForeignKey(
                name: "FK_Complemento_Pessoa_PessoaQueComplementouId",
                table: "Complemento",
                column: "PessoaQueComplementouId",
                principalTable: "Pessoa",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Complemento_Pessoa_PessoaQueComplementouId",
                table: "Complemento");

            migrationBuilder.DropIndex(
                name: "IX_Complemento_PessoaQueComplementouId",
                table: "Complemento");

            migrationBuilder.DropColumn(
                name: "PessoaQueComplementouId",
                table: "Complemento");
        }
    }
}
