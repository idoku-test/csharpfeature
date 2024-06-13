using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading.Tasks.Extensions;
class Program
{
    static void Main(){
       
    }

    static async Task MainAsync(){
         var msgs=new List<string>();
        foreach (var msg in msgs)
        {
            await SomeMethodAsync(); 
            //do something
        }

        async ValueTask<string> SomeMethodAsync(){
            await Task.Delay(1);
            return "Hello";
        }
    }
}