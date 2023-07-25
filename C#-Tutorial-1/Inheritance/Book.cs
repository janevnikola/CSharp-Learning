using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Tutorial_1
{
     class Book{

        private string BookName;
        private int BookPage;
        private string author;

        public string Author { 
            get
            {
                return author;
            }

            set
            {
                this.author = value;
            }
        
        
        }

        public Book()
        {

        }
        public Book(string newBookName,  int newBookPage, string newBookAuthor)
        {
            this.BookName = newBookName;
            this.BookPage = newBookPage;
            this.author = newBookAuthor;
            
        }


        public virtual void kolkuStranici()//virtual znaci deka ovaa funkcija moze da bide prepokriena t.e. overriden
        {
            Console.WriteLine("Knigata ima " + BookPage);
        }

        public void pecatiKniga()
        {
            Console.WriteLine("Imeto na knigata e: " + BookName + ", knigata e od " + author + " i ima " + BookPage + " stranici");
        }


    }
}
