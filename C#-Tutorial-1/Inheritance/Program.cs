using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Tutorial_1{
     class Program{
        static void Main(string[] args){

            Page page26 = new Page("Chapter 2",26,"Song of Ice and Fire",28,"George R.R Martin");

            page26.pecatiStrana();
           page26.kolkuStranici();
            Console.ReadLine();//dokolku ja nemavme ovaa linija kod, koga ke kliknevme start celo vreme ke se crashnuvase
          //bidejki programata se izvrsuva mnogu brzo, no ne ni e potrebna
                               //ova Console.ReadLine funkcija ke go runnuva prozorceto t.e console se dodeka ne se pritisne nekoe kopce
         
        }
    }
}
