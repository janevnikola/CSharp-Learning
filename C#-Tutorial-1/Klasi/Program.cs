using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Tutorial_1{
     class Program{
        static void Main(string[] args){

            Book IceAndFire = new Book("The song of Ice and fire part 1",500,"George R.R. Martin");
            IceAndFire.pecatiKniga();
            IceAndFire.Author = "JK Rowling";
            Console.WriteLine("Avtorot na knigata e " + IceAndFire.Author);

            Console.ReadLine();//dokolku ja nemavme ovaa linija kod, koga ke kliknevme start celo vreme ke se crashnuvase
          //bidejki programata se izvrsuva mnogu brzo, no ne ni e potrebna
                               //ova Console.ReadLine funkcija ke go runnuva prozorceto t.e console se dodeka ne se pritisne nekoe kopce
         
        }
    }
}
