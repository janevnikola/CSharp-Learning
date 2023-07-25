using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Tutorial_1
{
     class Page : Book//nasleduvanje
    {
        private string title;
        private int pageNumber;

        public Page() { }
        public Page(string new_title, int new_pageNumber, string newBookName, int newBookPage, string newBookAuthor) :base(newBookName, newBookPage, newBookAuthor)
                                                                                                    //ovde konstruktorot se povikuva so base, a ne imeto na roditelskata klasa
        {
            title = new_title;
          pageNumber = new_pageNumber;
        }

        //override

        public override void kolkuStranici()
        {
            Console.WriteLine(pageNumber);
        }


      public  void pecatiStrana()
        {
            Console.WriteLine("Stranata ima naslov: " + title + " i e na strana " + pageNumber);
            base.pecatiKniga();
        }
    }
}
