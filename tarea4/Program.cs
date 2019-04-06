using System;
using System.Collections.Generic;
namespace tarea4
{
    abstract class Musico
    {
        public string nombre;
        public Musico (string n)
        {
            nombre = n;
        }
        public abstract void Afina(); 
        public virtual string Display()
        {
            return nombre;
        }
    }
    class Bajista: Musico
    {
        public string bajo;
        public Bajista (string n, string bajo ):base(n)
        {
            this.bajo = bajo;
        }
        public override void Afina()
        {
            Console.WriteLine("Nombre: {0}, instrumento que afina: {1}",nombre,bajo);
        }
        public override string Display()
        { 
            return string.Format("Hola soy {0} y toco el {1}",nombre,bajo);
        }
    }
    class Guitarrista : Musico
    {
        public string guitarra;
        public Guitarrista (string n, string guitarra ):base(n)
        {
            this.guitarra = guitarra;
        }
        public override void Afina()
        {
            Console.WriteLine("Nombre: {0}, instrumento que toca: {1}",nombre,guitarra);
        }
        public override string Display()
        { 
            return string.Format("Hola soy {0} y toco la {1}",nombre,guitarra);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bajista b = new Bajista("Flea","Bajo");
            Guitarrista g = new Guitarrista("Santana","guitarra");
            List<Musico> musicos = new List<Musico>();
            musicos.Add(b);
            musicos.Add(g);
            musicos.Add(new Guitarrista("Django","Segunda Guitarra"));
            foreach (Musico mu in musicos)
            {
                mu.Afina();
            }
        }
    }
}
