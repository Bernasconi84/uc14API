using Microsoft.EntityFrameworkCore;
using Chapter.Models;

namespace Chapter.Contexts
{
    public class ChapterContexts:DbContext
    {
        public ChapterContexts()
        {

        }
        public ChapterContexts(DbContextOptions<ChapterContexts>options) :base(options)
        {

        }

        //vamos utilizar esse método para configurar o banco de dados
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //cada provedor tem sua sintaxe para especificação
                 optionsBuilder.UseSqlServer("Data Source = DESKTOP-6NSHU44\\SQLEXPRESS ; initial catalog = Chapter ; Integrated Security = true");
            }
        }

        //DbSet representa as entidades que serão utilizadas nas operações de leitura, criação, atualização e exclusão
        public DbSet<Models.Livro> Livros { get; set; }


    }
}
