using System;
using first;
using second;


namespace first
{
    class abc
    {
        public void function()
        {
            Console.WriteLine("first name space ");
        }
    }
}
namespace second
{
    class def
    {
        public void function()
        {
            Console.WriteLine("second name space ");
        }
    }
}


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        abc ob = new abc();
        def obj = new def();
        obj.function();
        ob.function();
        Console.ReadKey();



    }
}