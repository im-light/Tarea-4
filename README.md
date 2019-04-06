# Tarea4

1. Considera el siguiente fragmento de programa:
```c sharp
using System;

namespace tarea4
{
    class A
    {
        public int a;
        public A()
        {
        a = 10;
        }
        public virtual string Display()
        {
            return a.ToString();
        }
    }
    class B:A
    {
        public int b;
        public B():base()
        {
            b = 15;
        }
        public override string Display()
        {
            return b.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A objA = new A();

            B objB = new B();

            Console.WriteLine(objA.Display()); ////  (1 )

            Console. WriteLine(objB.Display()); ////  ( 2)
        }
    }
}
```
#####1.1. ¿Qué valores imprimen las lineas (1) y (2) ?


en la linea (1) 10


un la linea (2) 10

#####1.2.  Redefine el método Display en el espacio indicado, una vez redefinido el método, ¿qué valores imprimen las lineas (1) y (2)?


en la linea (1) 10


un la linea (2) 15

#####1.3. ¿Que palabra debes agregar en la linea (public _______ string Display()) al definir A.Display()?

virtual

---
2. Considera el siguiente fragmento de programa:
``` c sharp
using System;

using System.Collections.Generic;

 ________ class Musico

    {

    public string nombre;

    public Musico (string n)

        {

         nombre = n;

        }

   public abstract (A) void Afina();  (B)

   public (C) string Display()

      { 

       return nombre;

      }

   }

class Bajista; Musico

  {

    public string instrumento;

    public Bajista (string n, string i ) ......

    .........

    public _________ Afina()

      {

      ________________

      }

 }

class Guitarrista ____________

     {

     public instrumento;

      // Falta el constructor y otras cosas??

 

     }

 

class Program

 {

  public static Main()

   {

  Musico musico = new Musico("Django"); (D)

  Bajista b = new Bajista("Flea");

  Guitarrista g = new Guitarrista("Santana");

  List<Musico> musicos = ____________________

  musicos.Add( b);

  musicos.Add(g);

 

  foreach ( _____in musicos______)

        ____________________

 // (m as IAfina).Afina()

 Console.ReadKey();

  

 }

}

```
2.1. Completa el programa.

#####2.2. Hay un error en uno de los puntos (A)(B)(C)(D). ¿Cuál es y por qué?


En el punto (D) por que no se puede crear una instancia de una clase abstracta, en este caso de la clase abstracta Musico

#####2.3. ¿Qué método se debe implementar obligatoriamente en ambas clases y por qué?


todos los metodos que contenga en al clase base donde sea heredado tiene que ser implementado.

#####2.4. ¿Por qué no se ponen las llaves en (B)?, ¿Cuando si se pondrían?


un metodo abstracto No tiene cuerpo, puede llevar cuando no es abstracto

#####2.5. ¿Qué pasa si el método Afina() lo hacemos virtual en lugar de abstract?


podriamos modificarlo sus atributos en todas las clases heredadas

3. Implementa el programa utilizando interfaces en lugar de herencia.
``` c sharp


```


