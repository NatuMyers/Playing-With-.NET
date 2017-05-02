using System;
/* This statement tells the compiler that any types from the System namespace are in scope. 
Like other Object Oriented languages you may have used, C# uses namespaces to organize types
*/


namespace hwapp
// Namespaces They organize large code projects. 
// They are delimited by using the . operator.
// The using directive obviates the requirement to specify the name of the namespace for every class.
{
    class Program {
         static void Main(string[] args) {
            Console.WriteLine("Hello World!");

            /*
            If we list all the natural numbers below 10
            that are multiples of 3 or 5, we get 3, 5, 6 and 9.
            The sum of these multiples is 23.
            Find the sum of all the multiples of 3 or 5 below 1000. 
            */
            for (int i = 1; i <= 10; i++) {
                if (i % 3 == 0 || i % 5 == 0) {
                    Console.WriteLine(i);
                }
            }
        }
    }

}
