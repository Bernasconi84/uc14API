using Chapter.Contexts;
using Chapter.Models;

namespace Chapter.Repositories
{
    public class LivroRepository
    {
        private readonly ChapterContexts _contexts;

        public LivroRepository(ChapterContexts contexts)
        {
            _contexts = contexts;
        }
        public List<Livro> Listar()
        {
            return _contexts.Livros.ToList();
        }
    }
}
