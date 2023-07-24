using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Tutorial_1{
     class Program{
       
        static void Main(string[] args){

            Console.Write("Vnesi go prviot broj: ");
            int broj1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Vnesi go vtoriot broj: ");
            int broj2 = Convert.ToInt32(Console.ReadLine());

            //Kalkulacija
            Console.WriteLine("broj1 + broj2 = " + (broj1 + broj2));
            Console.WriteLine("broj1 - broj2 = " + (broj1 - broj2));
            Console.WriteLine("broj1 * broj2 = " + (broj1*broj2));
            Console.WriteLine("broj1 / broj2 = " + Convert.ToDouble(broj1/broj2));
            Console.WriteLine("broj1 % broj2 = " + Convert.ToDouble(broj1 % broj2));

            Console.ReadLine();//dokolku ja nemavme ovaa linija kod, koga ke kliknevme start celo vreme ke se crashnuvase
          //bidejki programata se izvrsuva mnogu brzo, no ne ni e potrebna
                               //ova Console.ReadLine funkcija ke go runnuva prozorceto t.e console se dodeka ne se pritisne nekoe kopce
         
        }
    }
}
