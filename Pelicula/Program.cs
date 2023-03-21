using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {
        //Campos
        
         private string titulo; 
         private Int16 año;
         private string pais;
         private string director;   
         private List<Actor> actores = new List<Actor>();      
        

        //Constructores
        public Pelicula()
        {
        }
        public Pelicula (string titulo, Int16 año)
        {
            this.titulo=titulo;
            this.año= año;
        }

        //Métodos

        //get
        public string GetTitulo()
        {
            return titulo;
        }
        //set
        public void SetTitulo(string Titulo)
        {
            titulo=Titulo;
        }
        //get
        public Int16  GetAño()
        {
            return año;
        }
        //set
        public void SetAño(Int16 Año)
        {
            año=Año;
        }
        public string GetPais()
        {
          return pais;
        }
        //set
        public void SetPaís(string pai)
        {
          pais=pai;
          }
          //get
       public string GetDirector()
      {
        return director;}

          //set
        public void SetDirector(string direcet)
        { 
          director=direcet;
          }
        public void Imprime()
        {
          Console.WriteLine($"{titulo} ({año})");

        }
          public void AgregaActor(Actor actor)
        {
           actores.Add(actor);
        }
        public void ImprimeActores()
        {
          foreach(Actor personas in actores)
          
          {
              Console.WriteLine($"{personas.GetNombre()} ({personas.GetAño()})");
          }          
        }
    }

    public class Actor
    {
        //Propiedades
        string nombre;
        Int16 año;

        //Constructores
        public Actor()
        {
        }
        public Actor (string nombre, Int16 año)
        {
            this.nombre= nombre;
            this.año=año;
        }
  

        //Métodos 

         public string GetNombre()
        {
          return nombre;
        }
        public void SetNombre(string nom)
        {
          nombre= nom;
        }

         public Int16 GetAño()
        {
          return año;
        }
        public void SetAño(Int16 year)
        {
          año= year;
        }
    }

    // Puedes probar tu código en Main() pero lo importante
    // es que pase las pruebas

    class Program
    {


        static void Main(string[] args)
        {
            Pelicula p1 = new Pelicula();
            Pelicula p2 = new Pelicula();
            p1.SetTitulo("La La Land");
            p1.SetAño(2016);
            Console.WriteLine("{0}({1})", p1.GetTitulo(), p1.GetAño());
            p1.Imprime();

            //Actor

              p1.AgregaActor(new Actor("Ryan Gosling", 1980));
              p1.AgregaActor(new Actor("Emma Stone", 1988));
              p1.ImprimeActores(); 

            List<Pelicula> peliculas = new List<Pelicula>();
            peliculas.Add(new Pelicula("Kimetsu no yaiba: Mugen Ressha-hen",2020));
            peliculas.Add(new Pelicula ("One Piece Film: Red",2022));
            peliculas.Add(new Pelicula ("Fate/Stay Night: Heaven's Feel - III",2020));
            peliculas.Add(new Pelicula ("Avengers: Endgame",2019));
            peliculas.Add(new Pelicula ("La tumba de las luciérnagas",1988));

            foreach(Pelicula pelicula in peliculas)
            {
                pelicula.Imprime();
            }

            Console.WriteLine("Hello");
        }
    }
}
