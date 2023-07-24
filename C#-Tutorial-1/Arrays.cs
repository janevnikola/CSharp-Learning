using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Tutorial_1{
     class Program{
       
        static void Main(string[] args){

            int[] niza = new int[5];//deklariranje na nizata


            for(int i = 0; i < niza.Length; i++)//input na vrednosti vo nizata
            {
                niza[i] =Convert.ToInt32(Console.ReadLine());
            }

            for(int i = 0; i < niza.Length; i++)
            {
                Console.Write(niza[i]);//pecatenje
            }

            Console.ReadLine();//dokolku ja nemavme ovaa linija kod, koga ke kliknevme start celo vreme ke se crashnuvase
          //bidejki programata se izvrsuva mnogu brzo, no ne ni e potrebna
                               //ova Console.ReadLine funkcija ke go runnuva prozorceto t.e console se dodeka ne se pritisne nekoe kopce
         
        }
    }
}
