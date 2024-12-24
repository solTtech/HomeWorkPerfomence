using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task1._3
{
    internal class Book
    {
        Title title = null;
        Author author = null;
        Content content = null;

        void InitialiBook()
        {
            this.title = new Title();
            this.author = new Author();
            this.content = new Content();
        }
        public Book(string title)
        {
            InitialiBook();
            this.title.Title1 = title;
        }

        public void Show()
        {
            this.title.Show();
            this.author.Show();
            this.content.Show();
        }

        public string Author
        {
            set
            {
                this.author.Author1 = value;
            }
        }

        public string Content
        {
            set
            {
                this.content.Content1 = value;
            }
        }
    }
}
