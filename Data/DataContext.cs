using RpgApi.Models;
using RpgApi.Models.Enuns;
using Microsoft.EntityFrameworkCore;

namespace RpgApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){

        }
        
        public DbSet<Personagem> TB_PERSONAGENS {get; set;}
        public DbSet<Armas> TB_ARMAS {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Personagem>().HasData(

            new Personagem() { Id = 1, Nome = "Frodo", PontosVida=100, Forca=17, Defesa=23, Inteligencia=33, Classe=ClasseEnum.Cavaleiro},
            new Personagem() { Id = 2, Nome = "Sam", PontosVida=100, Forca=15, Defesa=25, Inteligencia=30, Classe=ClasseEnum.Cavaleiro},
            new Personagem() { Id = 3, Nome = "Galadriel", PontosVida=100, Forca=18, Defesa=21, Inteligencia=35, Classe=ClasseEnum.Clerigo },
            new Personagem() { Id = 4, Nome = "Gandalf", PontosVida=100, Forca=18, Defesa=18, Inteligencia=37, Classe=ClasseEnum.Mago },
            new Personagem() { Id = 5, Nome = "Hobbit", PontosVida=100, Forca=20, Defesa=17, Inteligencia=31, Classe=ClasseEnum.Cavaleiro },
            new Personagem() { Id = 6, Nome = "Celeborn", PontosVida=100, Forca=21, Defesa=13, Inteligencia=34, Classe=ClasseEnum.Clerigo },
            new Personagem() { Id = 7, Nome = "Radagast", PontosVida=100, Forca=25, Defesa=11, Inteligencia=35, Classe=ClasseEnum.Mago }
            );

            modelBuilder.Entity<Armas>().HasData(
            new Armas() { Id = 1, Nome = "Arma1", Dano = 10},
            new Armas() { Id = 2, Nome = "Arma2", Dano = 20},
            new Armas() { Id = 3, Nome = "Arma3", Dano = 30},
            new Armas() { Id = 4, Nome = "Arma4", Dano = 40},
            new Armas() { Id = 5, Nome = "Arma5", Dano = 50},
            new Armas() { Id = 6, Nome = "Arma6", Dano = 60},
            new Armas() { Id = 7, Nome = "Arma7", Dano = 70}
            );
        }
    }
}