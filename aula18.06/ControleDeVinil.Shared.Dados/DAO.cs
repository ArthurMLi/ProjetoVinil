using ControleDeVinil.Shared.Modelos;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace ControleDeVinil.Shared.Dados
{
    public class DAO<T> where T:class
    {
        private readonly Contexto context;

        public DAO(Contexto contexto)
        {
            this.context = contexto;
        }
        public IEnumerable<T> ObterTodos()
        {
            return this.context.Set<T>().ToList();
        }
        public void CriarNovoItem(T novoItem)
        {
            this.context.Set<T>().Add(novoItem);
            this.context.SaveChanges();
        }
        public void ExluirItem(T Item)
        {
            this.context.Set<T>().Remove(Item);
            this.context.SaveChanges();
        }
        public void AlterarItem(T ItemAAlterar)
        {
            this.context.Set<T>().Update(ItemAAlterar);
            this.context.SaveChanges();
        }

    }
}
