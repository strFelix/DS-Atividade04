﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RpgApi.Data;

#nullable disable

namespace RpgApi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230927005755_MigracaoUsuario")]
    partial class MigracaoUsuario
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RpgApi.Models.Armas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Dano")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TB_ARMAS");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Dano = 15,
                            Nome = "Espada"
                        },
                        new
                        {
                            Id = 2,
                            Dano = 25,
                            Nome = "Espada Pesada"
                        },
                        new
                        {
                            Id = 3,
                            Dano = 20,
                            Nome = "Machado"
                        },
                        new
                        {
                            Id = 4,
                            Dano = 30,
                            Nome = "Machado Pesado"
                        },
                        new
                        {
                            Id = 5,
                            Dano = 17,
                            Nome = "Massa"
                        },
                        new
                        {
                            Id = 6,
                            Dano = 28,
                            Nome = "Massa Pesada"
                        },
                        new
                        {
                            Id = 7,
                            Dano = 10,
                            Nome = "Adaga"
                        },
                        new
                        {
                            Id = 8,
                            Dano = 8,
                            Nome = "Garras"
                        },
                        new
                        {
                            Id = 9,
                            Dano = 15,
                            Nome = "Cajado"
                        },
                        new
                        {
                            Id = 10,
                            Dano = 15,
                            Nome = "Talismã"
                        },
                        new
                        {
                            Id = 11,
                            Dano = 10,
                            Nome = "Arco"
                        },
                        new
                        {
                            Id = 12,
                            Dano = 13,
                            Nome = "Besta"
                        },
                        new
                        {
                            Id = 13,
                            Dano = 15,
                            Nome = "Arco Composto"
                        },
                        new
                        {
                            Id = 14,
                            Dano = 14,
                            Nome = "Lança"
                        },
                        new
                        {
                            Id = 15,
                            Dano = 5,
                            Nome = "Escudo"
                        });
                });

            modelBuilder.Entity("RpgApi.Models.Personagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Classe")
                        .HasColumnType("int");

                    b.Property<int>("Defesa")
                        .HasColumnType("int");

                    b.Property<int>("Forca")
                        .HasColumnType("int");

                    b.Property<byte[]>("FotoPersonagem")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("Inteligencia")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PontosVida")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("TB_PERSONAGENS");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Classe = 1,
                            Defesa = 23,
                            Forca = 17,
                            Inteligencia = 33,
                            Nome = "Frodo",
                            PontosVida = 100
                        },
                        new
                        {
                            Id = 2,
                            Classe = 1,
                            Defesa = 25,
                            Forca = 15,
                            Inteligencia = 30,
                            Nome = "Sam",
                            PontosVida = 100
                        },
                        new
                        {
                            Id = 3,
                            Classe = 3,
                            Defesa = 21,
                            Forca = 18,
                            Inteligencia = 35,
                            Nome = "Galadriel",
                            PontosVida = 100
                        },
                        new
                        {
                            Id = 4,
                            Classe = 2,
                            Defesa = 18,
                            Forca = 18,
                            Inteligencia = 37,
                            Nome = "Gandalf",
                            PontosVida = 100
                        },
                        new
                        {
                            Id = 5,
                            Classe = 1,
                            Defesa = 17,
                            Forca = 20,
                            Inteligencia = 31,
                            Nome = "Hobbit",
                            PontosVida = 100
                        },
                        new
                        {
                            Id = 6,
                            Classe = 3,
                            Defesa = 13,
                            Forca = 21,
                            Inteligencia = 34,
                            Nome = "Celeborn",
                            PontosVida = 100
                        },
                        new
                        {
                            Id = 7,
                            Classe = 2,
                            Defesa = 11,
                            Forca = 25,
                            Inteligencia = 35,
                            Nome = "Radagast",
                            PontosVida = 100
                        });
                });

            modelBuilder.Entity("RpgApi.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DataAcesso")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Foto")
                        .HasColumnType("varbinary(max)");

                    b.Property<double?>("Latitude")
                        .HasColumnType("float");

                    b.Property<double?>("Longitude")
                        .HasColumnType("float");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Perfil")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("Jogador");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TB_USUARIOS");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "seuEmail@gmail.com",
                            Latitude = -23.520024100000001,
                            Longitude = -46.596497999999997,
                            PasswordHash = new byte[] { 39, 219, 117, 89, 38, 1, 121, 182, 104, 146, 103, 105, 28, 100, 136, 109, 163, 3, 16, 133, 24, 201, 24, 249, 147, 46, 71, 184, 120, 85, 189, 37, 150, 194, 108, 235, 110, 74, 194, 146, 39, 8, 84, 176, 255, 35, 203, 244, 132, 133, 96, 156, 214, 63, 171, 217, 132, 93, 70, 35, 174, 54, 193, 93 },
                            PasswordSalt = new byte[] { 247, 171, 105, 3, 11, 190, 56, 254, 57, 207, 58, 145, 25, 236, 83, 133, 96, 102, 228, 230, 218, 136, 64, 72, 72, 29, 40, 142, 30, 88, 252, 19, 55, 29, 237, 75, 116, 201, 220, 20, 11, 101, 147, 244, 70, 217, 229, 102, 181, 58, 97, 103, 189, 59, 48, 244, 28, 34, 102, 239, 34, 254, 208, 119, 160, 41, 84, 35, 236, 158, 111, 91, 199, 109, 225, 88, 234, 167, 246, 109, 142, 108, 252, 61, 7, 22, 40, 136, 60, 32, 108, 207, 24, 55, 123, 200, 3, 215, 203, 212, 95, 115, 234, 60, 225, 76, 244, 122, 79, 244, 138, 4, 113, 208, 190, 40, 184, 162, 26, 144, 181, 28, 85, 40, 73, 106, 210, 121 },
                            Perfil = "Admin",
                            Username = "UsuarioAdmin"
                        });
                });

            modelBuilder.Entity("RpgApi.Models.Personagem", b =>
                {
                    b.HasOne("RpgApi.Models.Usuario", "Usuario")
                        .WithMany("Personagens")
                        .HasForeignKey("UsuarioId");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("RpgApi.Models.Usuario", b =>
                {
                    b.Navigation("Personagens");
                });
#pragma warning restore 612, 618
        }
    }
}
