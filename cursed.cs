using System;

class Program
{
     static void Main(string[] args)
     {
          try{throw new Exception("Hello!");}catch(Exception e){Action<Exception>a=(ex)=>{foreach(char b in ex.Message){Console.Write(b.ToString());}Console.WriteLine();for(int i = 0; i > 1;i++){if(true){Console.ReadLine();}}};a.Invoke(e);}
     }
}