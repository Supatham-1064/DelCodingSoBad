using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Shop {
     static void Main(string[]args) {
        string Name,OwnName;
        long Number,Value;
        

        Console.WriteLine("Please input Name:");
        Name = Console.ReadLine();
        Console.WriteLine("Please input Number:");
        Number = long.Parse(Console.ReadLine());
        Console.WriteLine("Please input Owner Name:");
        OwnName = Console.ReadLine();
        Console.WriteLine("Registered Value:");
        Value = long.Parse(Console.ReadLine());

        

        Console.WriteLine("------Shop Information------");
        Console.WriteLine("Name :{0}",Name);
        Console.WriteLine("Number:{0}",Number);
        Console.WriteLine("Owner Name:{0}",OwnName);
        Console.WriteLine("Registered:{0}",Value);
        Console.WriteLine("----------------------------");

    }

    
   
}
 
 