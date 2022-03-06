using LinkedList;
using System;
using System.Collections.Generic;

namespace LinkedListSolu
{
    class Program
    {
        static void Main(string[] args)
        {
            //int Choice,data,p;

            Console.WriteLine("Welcome to Linked List operation");

            LinkList list = new LinkList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
        }
    }
}