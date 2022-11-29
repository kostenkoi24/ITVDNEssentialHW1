using System;
using System.Collections.Generic;
using System.Text;

namespace Homework1_3
{
    class Book
    {

        
        Title title = null;
        Author author = null;
        Content content = null;

        void InitializeBook()
        {
            this.title = new Title();
            this.author = new Author();
            this.content = new Content();
        }

        public Book(string title)
        {
            InitializeBook();
            this.title.Text = title;

        }

        public void Show()
        {
            this.title.Show();
            this.author.Show();
            this.content.Show();
        }

        public string Title
        {
            set
            {
                this.title.Text = value;
            }
        }

        public string Author
        {
            set
            {
                this.author.AuthorName = value;
            }
        }

        public string Content
        {
            set
            {
                this.content.ContentText = value;
            }
        }



    }
}
