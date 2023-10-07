using RpgApi.Models;
using RpgApi.Models.Enuns;
using Microsoft.EntityFrameworkCore;
using RpgApi.Utils;

namespace RpgApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){

        }
        
        public DbSet<Personagem> TB_PERSONAGENS {get; set;}
        public DbSet<Armas> TB_ARMAS {get; set;}
        public DbSet<Usuario> TB_USUARIOS {get; set; }

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
            new Armas() { Id = 1, Nome = "Espada", Dano = 15, PersonagemId = 1},
            new Armas() { Id = 2, Nome = "Espada Pesada", Dano = 25, PersonagemId = 2},
            new Armas() { Id = 3, Nome = "Machado", Dano = 20, PersonagemId = 3},
            new Armas() { Id = 4, Nome = "Machado Pesado", Dano = 30, PersonagemId = 4},
            new Armas() { Id = 5, Nome = "Massa", Dano = 17, PersonagemId = 5},
            new Armas() { Id = 6, Nome = "Massa Pesada", Dano = 28, PersonagemId = 6},
            new Armas() { Id = 7, Nome = "Adaga", Dano = 10, PersonagemId = 7}
            //SEM ATRIBUIÇÃO DE PERSONAGENS BANCO DEFINI COMO ID 1, ERRO POR SER PK E REPITIR ID
            // new Armas() { Id = 8, Nome = "Garras", Dano = 8 },
            // new Armas() { Id = 9, Nome = "Cajado", Dano = 15 },
            // new Armas() { Id = 10, Nome = "Talismã", Dano = 15},
            // new Armas() { Id = 11, Nome = "Arco", Dano = 10},
            // new Armas() { Id = 12, Nome = "Besta", Dano = 13},
            // new Armas() { Id = 13, Nome = "Arco Composto", Dano = 15},
            // new Armas() { Id = 14, Nome = "Lança", Dano = 14},
            // new Armas() { Id = 15, Nome = "Escudo", Dano = 5}
            );

            // modelBuilder.Entity<PersonagemHabilidade>().HasData
            //Início da criação do usuário padrão.
            Usuario user = new Usuario();
            Criptografia.CriarPasswordHash("123456", out byte[] hash, out byte[]salt);
            user.Id = 1;
            user.Username = "UsuarioAdmin";
            user.PasswordString = string.Empty;
            user.PasswordHash = hash;
            user.PasswordSalt = salt;
            user.Perfil = "Admin";
            user.Email = "seuEmail@gmail.com";
            user.Latitude = -23.5200241;
            user.Longitude = -46.596498;
            
            //Fim da criação do usuário padrão.
            modelBuilder.Entity<Usuario>().HasData(user);            

            //Define que se o Perfil não for informado, o valor padrão será jogador
            modelBuilder.Entity<Usuario>().Property(u => u.Perfil).HasDefaultValue("Jogador");
        }
    }
}