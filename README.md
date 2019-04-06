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
1.1. ¿Qué valores imprimen las lineas (1) y (2) ?
en la linea (1) 10
un la linea (2) 10

1.2.  Redefine el método Display en el espacio indicado, una vez redefinido el método, ¿qué valores imprimen las lineas (1) y (2) ?.
en la linea (1) 10
un la linea (2) 15

1.3. ¿Que palabra debes agregar en la linea (public _______ string Display()) al definir A.Display()?
virtual
