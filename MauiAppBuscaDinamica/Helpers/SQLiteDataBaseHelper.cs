using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using MauiAppBuscaDinamica;
using MauiAppBuscaDinamica.Model;



namespace MauiAppBuscaDinamica.Helpers
{
   public class SQLiteDataBaseHelper
    {
        readonly SQLiteAsyncConnection _conn;

        public SQLiteDataBaseHelper (string caminho)
        {
           _conn = new SQLiteAsyncConnection(caminho);
           _conn.CreateTableAsync<Produto>().Wait();
         }

        public Task<int> Insert (Produto p)
        {
        return _conn.InsertAsync(p);
        }
        public Task<List<Produto>>  Update(Produto p)
        {
        string sql = "UPDATE produto SET Descrição=?, Quantidade=?, Preço=? WHERE CodProduto=?";
        return _conn.QueryAsync<Produto>(
            sql, p.Descrição, p.Quantidade, p.Preço, p.CodProduto);
        
        }
        public Task<int> Delete(int CodProduto)
        {
            return _conn.Table<Produto>().DeleteAsync(i => i.CodProduto == CodProduto);

        }
        public Task <List<Produto>> GetAll()
        {
            return _conn.Table<Produto>().ToListAsync();
        }
        public Task<List<Produto>> Search(string query)
        {
            string sql = "SELECT * FROM Produto WHERE descrição LIKE '%%'";
            return _conn.QueryAsync<Produto>(sql);
        }
    }
}
