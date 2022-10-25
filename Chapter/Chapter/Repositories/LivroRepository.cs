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
        public Livro BuscarPorId(int id)
        {
            return _contexts.Livros.Find(id);
        }
        public void Cadastrar(Livro livro)
        {
            _contexts.Livros.Add(livro);

            _contexts.SaveChanges();
        }

        public void Deletar(int id)
        {
            Livro livro = _contexts.Livros.Find(id);

            _contexts.Livros.Remove(livro);

            _contexts.SaveChanges();
        }

        public void Atualizar(int id, Livro livro)
        {
            Livro livroBuscado = _contexts.Livros.Find(id); 

            if (livroBuscado != null)
            {
                livroBuscado.Titulo = livro.Titulo;
                livroBuscado.QuantidadePaginas = livro.QuantidadePaginas;
                livroBuscado.Disponivel = livro.Disponivel;
            }

            _contexts.Update(livroBuscado);

            _contexts.SaveChanges();
        }
    }
}
