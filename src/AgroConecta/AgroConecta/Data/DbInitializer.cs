using AgroConecta.Models;

namespace AgroConecta.Data
{
    public static class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            if (context.CategoriasForum.Any())
            {
                return; 
            }

            var categorias = new CategoriaForum[]
            {
            new CategoriaForum{ Nome = "Produção Agrícola", Desc = "Área exclusiva para cultivo e lavouras " },
            new CategoriaForum{ Nome = "Pecuária", Desc = "Área exclusiva para criação de animais" },
            new CategoriaForum{ Nome = "Tecnologia no Campo", Desc = "Área exclusiva para inovação agrícola" },
            new CategoriaForum{ Nome = "Mercado e Negócios", Desc = "Área exclusiva para comércio e gestão" },
            new CategoriaForum{ Nome = "Sustentabilidade", Desc = "Área exclusiva para práticas ambientais" },
            new CategoriaForum{ Nome = "Off-Tópico", Desc = "Área exclusiva para qualquer assunto que não exista uma área definida no fórum" },

            };

            context.CategoriasForum.AddRange(categorias);
            context.SaveChanges();
        }
    }
}
