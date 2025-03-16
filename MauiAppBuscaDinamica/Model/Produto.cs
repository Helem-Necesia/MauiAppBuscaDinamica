using SQLite;

namespace MauiAppBuscaDinamica.Model
{
   public class Produto
    {
        [PrimaryKey, AutoIncrement]
        public int CodProduto { get; set; }
        public string Descrição { get; set; }
        public object Quantidade { get; internal set; }
        public object Preço { get; internal set; }
    }
}
