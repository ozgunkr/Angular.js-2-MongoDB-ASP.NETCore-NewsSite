using KlikHaber.DataAccess;
using KlikHaber.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockupProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ArticleRepository articles = new ArticleRepository();
            Article article = new Article { Id = 4, Category = "Ekonomi", Title = "Barcelona yenildi", Body = "Test Body" };
            articles.Add(article);
        }
    }
}
