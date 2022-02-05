// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

class Todolist
{
    string[] todo = new string[5];
    int i;
    public void Display()

       
    {
        Console.WriteLine("This Program is taking 5 To dos");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Kindly Enter your name and press enter :");
       string Myname =  Console.ReadLine();

        for (i = 0; i<todo.Length; i++)
        {


            Console.WriteLine("Kindly write you number "+  ( i+1) + " todo" );
            todo[i] = Console.ReadLine();

        }
        
  

        Console.WriteLine($"Hello { Myname} , your todo list are listed below :" );

        for (i = 0; i < todo.Length; i++)
        {
            Console.WriteLine(todo[i]);
        }
    }


    static void Main( string[] args)
    {

        Todolist todolist = new Todolist();
        todolist.Display();

        Console.WriteLine();

        Console.WriteLine("This is Lovely");
        Console.ReadKey();


    }





}