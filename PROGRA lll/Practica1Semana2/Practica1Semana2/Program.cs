using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1Semana2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caballo miCaballo = new Caballo("Manuel");
            Humano miHumano = new Humano("Marvin");
            Gorila miGorila = new Gorila("Makumba");
            Ballena miBallena = new Ballena("Waly");
            Cocodrilo miCocodrilo = new Cocodrilo("Louis");

            Mamiferos[] almacenAnimales = new Mamiferos[3];
            almacenAnimales[0] = miCaballo;
            almacenAnimales[1] = miHumano;
            almacenAnimales[2] = miGorila;
            almacenAnimales[3] = miBallena;
            almacenAnimales[4] = miCocodrilo;   

            for (int i = 0; i < 3; i++)
            {
                almacenAnimales[i].pensar();
            }

        }

    }


    class Mamiferos
    {
        public Mamiferos(String nombre)
        {
           string nombreServivo = nombre;
        }
        public void respirar()
        {
            Console.WriteLine("Soy capaz de respirar");

        }
        public void pensar()
        {
            Console.WriteLine("Pensamiento basico instintivos");
        }
        public void cuidarCrias()
        {
            Console.WriteLine("Cuidar las crias");
        }
        public void getNombre()
        {
            Console.WriteLine("El nombre del ser vivo es:");
        }
    }


    interface IAnimalesTerrestres
    {
        int numeroPatas();
    }
    public override void getNombre()
    {
        Console.WriteLine("El nombre del ser vivo es:" + );
    }
    class Reptil
    {
        public Reptil(string nombre)
        {
            string nombreRapti = nombre;
        }
    }

  public class Ballena : Mamiferos
    {
        public Ballena(String nombreBallena ) : base (nombreBallena)    
        {

        }
        public void Nadar()
        {
            Console.WriteLine("Soy una ballena y pueda nadar");
        }
    }
    public class Humano : Mamiferos
    {
        public Humano(String nombreHumano) : base(nombreHumano)
        {

        }
        public void Pensar()
        {
            Console.WriteLine("Soy un humano y puedo pensar ");
        }
    }
    public class Caballo : Mamiferos
    {
        public Caballo(String nombreCaballo) : base(nombreCaballo)
        {

        }
        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar ");
        }
        public int numeroPatas()
        {
            return 4;
        }
    }
  
                                 
}
