﻿// <auto-generated />
using System;
using Desafio.API.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Desafio.API.Migrations
{
    [DbContext(typeof(ContextoAPI))]
    [Migration("20200306030915_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2");

            modelBuilder.Entity("Desafio.Entidades.Entidades.Pessoa", b =>
                {
                    b.Property<Guid>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("CPF")
                        .HasColumnType("TEXT")
                        .HasMaxLength(11);

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT")
                        .HasMaxLength(150);

                    b.Property<string>("UF")
                        .HasColumnType("TEXT")
                        .HasMaxLength(2);

                    b.HasKey("Codigo");

                    b.ToTable("Pessoas");
                });
#pragma warning restore 612, 618
        }
    }
}
