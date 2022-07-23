﻿// <auto-generated />
using System;
using DDona.JaReclamouHoje.Infra.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DDona.JaReclamouHoje.Infra.Migrations
{
    [DbContext(typeof(ReclamacoesDBContext))]
    [Migration("20220723001246_complemento_com_pessoa")]
    partial class complemento_com_pessoa
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DDona.JaReclamouHoje.Dominio.Entities.Assunto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DataAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("Id");

                    b.ToTable("Assunto");
                });

            modelBuilder.Entity("DDona.JaReclamouHoje.Dominio.Entities.Complemento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DataAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<Guid>("PessoaQueComplementouId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ReclamacaoOriginalId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PessoaQueComplementouId");

                    b.HasIndex("ReclamacaoOriginalId");

                    b.ToTable("Complemento");
                });

            modelBuilder.Entity("DDona.JaReclamouHoje.Dominio.Entities.Pessoa", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DataAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("NomeDeUsuario")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("Id");

                    b.ToTable("Pessoa");
                });

            modelBuilder.Entity("DDona.JaReclamouHoje.Dominio.Entities.Reclamacao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AssuntoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("DataAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasMaxLength(1000)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<Guid>("PessoaId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AssuntoId");

                    b.HasIndex("PessoaId");

                    b.ToTable("Reclamacao");
                });

            modelBuilder.Entity("DDona.JaReclamouHoje.Dominio.Entities.Complemento", b =>
                {
                    b.HasOne("DDona.JaReclamouHoje.Dominio.Entities.Pessoa", "PessoaQueComplementou")
                        .WithMany("Complementos")
                        .HasForeignKey("PessoaQueComplementouId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DDona.JaReclamouHoje.Dominio.Entities.Reclamacao", "ReclamacaoOriginal")
                        .WithMany("Complementos")
                        .HasForeignKey("ReclamacaoOriginalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PessoaQueComplementou");

                    b.Navigation("ReclamacaoOriginal");
                });

            modelBuilder.Entity("DDona.JaReclamouHoje.Dominio.Entities.Reclamacao", b =>
                {
                    b.HasOne("DDona.JaReclamouHoje.Dominio.Entities.Assunto", "Assunto")
                        .WithMany("Reclamacoes")
                        .HasForeignKey("AssuntoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DDona.JaReclamouHoje.Dominio.Entities.Pessoa", "Pessoa")
                        .WithMany("Reclamacoes")
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Assunto");

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("DDona.JaReclamouHoje.Dominio.Entities.Assunto", b =>
                {
                    b.Navigation("Reclamacoes");
                });

            modelBuilder.Entity("DDona.JaReclamouHoje.Dominio.Entities.Pessoa", b =>
                {
                    b.Navigation("Complementos");

                    b.Navigation("Reclamacoes");
                });

            modelBuilder.Entity("DDona.JaReclamouHoje.Dominio.Entities.Reclamacao", b =>
                {
                    b.Navigation("Complementos");
                });
#pragma warning restore 612, 618
        }
    }
}
