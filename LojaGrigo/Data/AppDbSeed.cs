using LojaGrigo.Models;
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
                Descricao = "O uniforme 1 24/25 é verde com detalhes em branco, destacando o escudo do clube no peito. Possui design moderno e confort�vel, com tecnologia para garantir desempenho e respirabilidade.",    
                ValorCusto = 200.00m,
                ValorVenda = 399.90m,
                QtdeEstoque = 50,
                Destaque = true
            }
        };
        builder.Entity<Produto>().HasData(produtos);

        List<ProdutoFoto> fotos = new() {
            new() {Id = 1, ProdutoId = 1, Foto = "/img/produtos/Uniforme de Jogo/Camisa1F.webp"}
        };
        builder.Entity<ProdutoFoto>().HasData(fotos);
    }
}
