using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Tutorial_1{
     class Program{
       
        static void SayHi(string ime){//definirame void funkcija koja sto pecati samo zdravo nikola

            if (ime.Contains("Nikola"))
            {
                Console.WriteLine("Dobredojdovte " + ime);
            }
            else
            {
                Console.WriteLine("Tvoeto ime ne e Nikola");
            }
        }



        static void Main(string[] args){
            Console.Write("Vnesi ime: ");
            string ime = Console.ReadLine();

            SayHi(ime);//povik na funkcijata
            Console.ReadLine();//dokolku ja nemavme ovaa linija kod, koga ke kliknevme start celo vreme ke se crashnuvase
          //bidejki programata se izvrsuva mnogu brzo, no ne ni e potrebna
                               //ova Console.ReadLine funkcija ke go runnuva prozorceto t.e console se dodeka ne se pritisne nekoe kopce
         
        }
    }
}
