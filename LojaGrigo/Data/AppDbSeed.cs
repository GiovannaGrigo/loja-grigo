using LojaGrigo.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LojaGrigo.Data;

public class AppDbSeed
{
    public AppDbSeed(ModelBuilder builder)
    {
        List<Categoria> categorias = new() {
            new() { Id = 1, Nome = "Uniforme de Jogo"},
            new() { Id = 2, Nome = "Treino e Viagem"},
            new() { Id = 3, Nome = "Linha Torcedor"},
            new() { Id = 4, Nome = "Polos"},
        };
        builder.Entity<Categoria>().HasData(categorias);

        List<Produto> produtos = new() {
            new() {
                Id = 1,
                CategoriaId = 1,
                Nome = "Camisa 1 - 24/25",
                Descricao = "O uniforme 1 - 24/25 é verde com detalhes em branco, destacando o escudo do clube no peito. Possui design moderno e confortável, com tecnologia para garantir desempenho e respirabilidade.",    
                ValorCusto = 200.00m,
                ValorVenda = 399.90m,
                QtdeEstoque = 50,
                Destaque = true
            },
            new() {
                Id = 2,
                CategoriaId = 1,
                Nome = "Camisa 2 - 24/25",
                Descricao = "O uniforme 2 - 24/25 é branco com detalhes em verde, destacando o escudo do clube no peito. Possui design moderno e confortável, com tecnologia para garantir desempenho e respirabilidade.",
                ValorCusto = 180.00m,
                ValorVenda = 349.99m,
                QtdeEstoque = 60,
                Destaque = true
            },
            new () {
                Id = 3,
                CategoriaId = 1,
                Nome = "Camisa 3 - 24/25",
                Descricao = "O uniforme 3 - 24/25 é dourado com detalhes em verde, destacando o escudo do clube no peito. Possui design moderno e confortável, com tecnologia para garantir desempenho e respirabilidade.",
                ValorCusto = 250.00m,
                ValorVenda = 499.90m,
                QtdeEstoque = 40,
                Destaque = false
            },
            new () {
                Id = 4,
                CategoriaId = 1,
                Nome = "Camisa Goleiro 1 - 24/25",
                Descricao = "O uniforme 1 de goleiro 24/25 é azul com listras em um tom mais claro de azul, destacando o escudo do clube no peito. Possui design moderno e confortável, com tecnologia para garantir desempenho e respirabilidade.",
                ValorCusto = 150.00m,
                ValorVenda = 299.99m,
                QtdeEstoque = 30,
                Destaque = true
            },
            new () {
                Id = 5,
                CategoriaId = 1,
                Nome = "Camisa 1 - 25/26",
                Descricao = "O uniforme 1 - 25/26 é verde com detalhes em branco, destacando o escudo do clube no peito. Possui design moderno e confortável, com tecnologia para garantir desempenho e respirabilidade.",
                ValorCusto = 240.00m,
                ValorVenda = 499.99m,
                QtdeEstoque = 70,
                Destaque = true
            },
            new () {
                Id = 6,
                CategoriaId = 1,
                Nome = "Camisa 2 - 25/26",
                Descricao = "O uniforme 2 - 25/26 é branco com as mangas em verde, destacando o escudo do clube no peito. Possui design moderno e confortável, com tecnologia para garantir desempenho e respirabilidade.",
                ValorCusto = 240.00m,
                ValorVenda = 499.99m,
                QtdeEstoque = 65,
                Destaque = true
            },
            new () {
                Id = 7,
                CategoriaId = 1,
                Nome = "Camisa Goleiro 1 - 25/26",
                Descricao = "O uniforme 1 de goleiro - 25/26 é azul claro com detalhes em um tom de azul mais escuro, destacando o escudo do clube no peito. Possui design moderno e confortável, com tecnologia para garantir desempenho e respirabilidade.",
                ValorCusto = 240.00m,
                ValorVenda = 499.99m,
                QtdeEstoque = 50,
                Destaque = false
            },
            new () {
                Id = 8,
                CategoriaId = 2,
                Nome = "Camisa Treino e Viagem - 24/25",
                Descricao = "A camisa de treino é verde limão com detalhes em verde escuro, destacando o escudo do clube no peito. Possui design moderno e confortável, com tecnologia para garantir desempenho e respirabilidade.",
                ValorCusto = 150.00m,
                ValorVenda = 279.90m,
                QtdeEstoque = 80,
                Destaque = false
            },
            new () {
                Id = 9,
                CategoriaId = 2,
                Nome = "Jaqueta Treino - 24/25",
                Descricao = "A jaqueta de treino é azul com detalhes em um tom de azul mais escuro, destacando o escudo do clube no peito. Possui design moderno e confortável, com tecnologia para garantir desempenho e respirabilidade.",
                ValorCusto = 500.00m,
                ValorVenda = 949.99m,
                QtdeEstoque = 25,
                Destaque = true
            },
            new () {
                Id = 10,
                CategoriaId = 3,
                Nome = "Camisa Motorsport",
                Descricao = "A camiseta Motorsport traz um design moderno e arrojado, com detalhes que combinam estilo e performance. Inspirada no universo das competições automobilísticas, ela une a tradição do clube à energia do esporte a motor.",
                ValorCusto = 200.00m,
                ValorVenda = 399.99m,
                QtdeEstoque = 40,
                Destaque = true
            },
            new () {
                Id = 11,
                CategoriaId = 3,
                Nome = "Camisa Football",
                Descricao = "A camiseta Football é inspirada no estilo do futebol americano, com um design robusto e detalhes marcantes. Ela mistura a identidade do clube com a estética das ligas norte-americanas, trazendo um toque esportivo e moderno.",
                ValorCusto = 80.00m,
                ValorVenda = 159.90m,
                QtdeEstoque = 90,
                Destaque = false
            },
            new () {
                Id = 12,
                CategoriaId = 3,
                Nome = "Regata Basket Palestra",
                Descricao = "A camisa regata Basket é inspirada no basquete, com um design urbano e esportivo. Com detalhes que lembram a estética das quadras, ela combina estilo e praticidade, sendo perfeita para os fãs do clube e do esporte.",
                ValorCusto = 100.00m,
                ValorVenda = 169.99m,
                QtdeEstoque = 70,
                Destaque = false
            },
            new () {
                Id = 13,
                CategoriaId = 4,
                Nome = "Polo Treino - 22/23",
                Descricao = "A camisa polo de treino - 22/23, na cor azul, traz um design sofisticado e moderno, com detalhes sutis que valorizam a identidade do clube. Ideal para quem busca um estilo casual e elegante, ela une conforto e tradição de forma discreta e refinada.",
                ValorCusto = 70.00m,
                ValorVenda = 149.99m,
                QtdeEstoque = 100,
                Destaque = false
            },
            new () {
                Id = 14,
                CategoriaId = 4,
                Nome = "Polo Viagem - 20/21",
                Descricao = "A camisa polo de viagem - 20/21 apresenta um design elegante e confortável, ideal para os momentos de deslocamento dos jogadores. Com detalhes em verde e o escudo do clube, ela combina estilo casual com a tradição alviverde.",
                ValorCusto = 150.00m,
                ValorVenda = 249.90m,
                QtdeEstoque = 50,
                Destaque = true
            },
            new () {
                Id = 15,
                CategoriaId = 4,
                Nome = "Polo Casual - 24/25",
                Descricao = "A camisa polo casual - 24/25 combina sofisticação e descontração, com um design moderno e detalhes que refletem a identidade do clube. Perfeita para ocasiões casuais, ela traz o estilo clássico da polo com um toque contemporãneo, ideal para os torcedores alviverdes.",
                ValorCusto = 200.00m,
                ValorVenda = 349.90m,
                QtdeEstoque = 60,
                Destaque = true
            },
        };
        builder.Entity<Produto>().HasData(produtos);

        List<ProdutoFoto> fotos = new() {
            new() {Id = 1, ProdutoId = 1, Foto = "/img/produtos/Uniforme de Jogo/Camisa1F.webp"},
            new() {Id = 2, ProdutoId = 1, Foto = "/img/produtos/Uniforme de Jogo/Camisa1T.webp"},
            new() {Id = 3, ProdutoId = 2, Foto = "/img/produtos/Uniforme de Jogo/Camisa2F.png"},
            new() {Id = 4, ProdutoId = 2, Foto = "/img/produtos/Uniforme de Jogo/Camisa2T.webp"},
            new() {Id = 5, ProdutoId = 3, Foto = "/img/produtos/Uniforme de Jogo/Camisa3F.webp"},
            new() {Id = 6, ProdutoId = 3, Foto = "/img/produtos/Uniforme de Jogo/Camisa3T.webp"},
            new() {Id = 7, ProdutoId = 4, Foto = "/img/produtos/Uniforme de Jogo/Goleiro1F.webp"},
            new() {Id = 8, ProdutoId = 4, Foto = "/img/produtos/Uniforme de Jogo/Goleiro1T.webp"},
            new() {Id = 9, ProdutoId = 5, Foto = "/img/produtos/Uniforme de Jogo/Camisa25F.png"},
            new() {Id = 10, ProdutoId = 5, Foto = "/img/produtos/Uniforme de Jogo/Camisa25T.png"},
            new() {Id = 11, ProdutoId = 6, Foto = "/img/produtos/Uniforme de Jogo/2Camisa25F.png"},
            new() {Id = 12, ProdutoId = 6, Foto = "/img/produtos/Uniforme de Jogo/2Camisa25T.png"},
            new() {Id = 13, ProdutoId = 7, Foto = "/img/produtos/Uniforme de Jogo/GK25F.png"},
            new() {Id = 14, ProdutoId = 7, Foto = "/img/produtos/Uniforme de Jogo/GK25T.png"},
            new() {Id = 15, ProdutoId = 8, Foto = "/img/produtos/Treino e Viagem/CamisaTreinoF.webp"},
            new() {Id = 16, ProdutoId = 8, Foto = "/img/produtos/Treino e Viagem/CamisaTreinoT.webp"},
            new() {Id = 17, ProdutoId = 9, Foto = "/img/produtos/Treino e Viagem/JaquetaTreino.png"},
            new() {Id = 18, ProdutoId = 10, Foto = "/img/produtos/Linha Torcedor/Motorsport.webp"},
            new() {Id = 19, ProdutoId = 11, Foto = "/img/produtos/Linha Torcedor/FootballF.webp"},
            new() {Id = 20, ProdutoId = 11, Foto = "/img/produtos/Linha Torcedor/FootballT.webp"},
            new() {Id = 21, ProdutoId = 12, Foto = "/img/produtos/Linha Torcedor/RegataF.webp"},
            new() {Id = 22, ProdutoId = 12, Foto = "/img/produtos/Linha Torcedor/RegataF.webp"},
            new() {Id = 23, ProdutoId = 13, Foto = "/img/produtos/Polos/PoloTreinoF.png"},
            new() {Id = 24, ProdutoId = 13, Foto = "/img/produtos/Polos/PoloTreinoT.png"},
            new() {Id = 25, ProdutoId = 14, Foto = "/img/produtos/Polos/PoloViagemF.webp"},
            new() {Id = 26, ProdutoId = 14, Foto = "/img/produtos/Polos/PoloViagemT.webp"},
            new() {Id = 27, ProdutoId = 15, Foto = "/img/produtos/Polos/PoloCasualF.png"},
            new() {Id = 28, ProdutoId = 15, Foto = "/img/produtos/Polos/PoloCasualT.webp"}
        };
        builder.Entity<ProdutoFoto>().HasData(fotos);

        #region Populate Roles - Perfis de Usuário
        List<IdentityRole> roles = new()
        {
            new IdentityRole() {
                Id = "0b44ca04-f6b0-4a8f-a953-1f2330d30894",
                Name = "Administrador",
                NormalizedName = "ADMINISTRADOR"
            },
            new IdentityRole() {
                Id = "bec71b05-8f3d-4849-88bb-0e8d518d2de8",
                Name = "Funcionário",
                NormalizedName = "FUNCIONÁRIO"
            },
            new IdentityRole() {
                Id = "ddf093a6-6cb5-4ff7-9a64-83da34aee005",
                Name = "Cliente",
                NormalizedName = "CLIENTE"
            },
        };
        builder.Entity<IdentityRole>().HasData(roles);
        #endregion

        #region Populate Usuário
        List<Usuario> usuarios = new() {
            new Usuario(){
                Id = "ddf093a6-6cb5-4ff7-9a64-83da34aee005",          
                Email = "giovanna1grigo@gmail.com",
                NormalizedEmail = "GIOVANNA1GRIGO@GMAIL.COM",
                UserName = "GihGrigo",
                NormalizedUserName = "GIHGRIGO",
                LockoutEnabled = true,
                EmailConfirmed = true,
                Nome = "Giovanna Grigolato",
                DataNascimento = DateTime.Parse("14/12/2006"),
                Foto = "/img/giovanna.webp"
            }
        };
        foreach (var user in usuarios)
        {
            PasswordHasher<IdentityUser> pass = new();
            user.PasswordHash = pass.HashPassword(user, "123456");
        }
        builder.Entity<Usuario>().HasData(usuarios);
        #endregion

        #region Populate UserRole - Usuário com Perfil
        List<IdentityUserRole<string>> userRoles = new()
        {
            new IdentityUserRole<string>() {
                UserId = usuarios[0].Id,
                RoleId = roles[0].Id
            },
            new IdentityUserRole<string>() {
                UserId = usuarios[0].Id,
                RoleId = roles[1].Id
            },
            new IdentityUserRole<string>() {
                UserId = usuarios[0].Id,
                RoleId = roles[2].Id
            }
        };
        builder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        #endregion
    }
}
