﻿// <auto-generated />
using JuninViagens.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JuninViagens.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("JuninViagens.Model.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("EmailCli")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("cepCli")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("enderecoCli")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("nomeCli")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("clientes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EmailCli = "junio@gmail",
                            cepCli = "85960000",
                            enderecoCli = "Rua Amilton 13",
                            nomeCli = "Junio Henrique"
                        },
                        new
                        {
                            Id = 2,
                            EmailCli = "anaclara@gmail",
                            cepCli = "85960000",
                            enderecoCli = "Rua das Flores 130",
                            nomeCli = "Ana Clara"
                        },
                        new
                        {
                            Id = 3,
                            EmailCli = "mduarda@gmail",
                            cepCli = "85960000",
                            enderecoCli = "Rua XV de Novembro 4545",
                            nomeCli = "Maria Eduarda"
                        },
                        new
                        {
                            Id = 4,
                            EmailCli = "carlosfernando@gmail",
                            cepCli = "85960000",
                            enderecoCli = "Rua Santana 4545",
                            nomeCli = "Carlos Fernando"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}