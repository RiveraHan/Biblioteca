using System;
using Biblioteca.data.context;

namespace Biblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create data base");
            LibraryDb db = new LibraryDb();

            db.Database.EnsureCreated();

            Console.WriteLine("Data base created");
            Console.ReadKey();
        }
    }
}
