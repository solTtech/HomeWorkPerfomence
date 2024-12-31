using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._4
{
    internal class Store
    {
        private Article[] articles;

        public Store(int size)
        {
            articles = new Article[size];
        }

        public void AddArticle(int index, Article article)
        {
            if (index >= 0 && index < articles.Length)
            {
                articles[index] = article;
            }
        }

        public void DisplayArticleByIndex(int index)
        {
            if (index >= 0 && index < articles.Length && articles[index] != null)
            {
                articles[index].DisplayInfo();
            }
            else
            {
                Console.WriteLine("Article not found at the given index.");
            }
        }

        public void DisplayArticleByName(string name)
        {
            bool found = false;
            foreach (var article in articles)
            {
                if (article != null && article.ProductName.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    article.DisplayInfo();
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No article found with the given name.");
            }
        }
    }
}
