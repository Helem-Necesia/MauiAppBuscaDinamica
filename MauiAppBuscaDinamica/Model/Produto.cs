using SQLite;

namespace MauiAppBuscaDinamica.Model
{
   public class Produto
    {
        [PrimaryKey, AutoIncrement]
        public int CodProduto { get; set; }
        public string Descrição { get; set; }
        public double Quantidade { get; set; }
        public double Preço { get; set; }
        public double Total { get => Quantidade * Preço; }
    }
}
