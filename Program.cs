using System;
using System.Collections.Generic;
using System.Linq;
using static Cafe.Messages;
namespace Cafe{
    class Program{
        static void Main(string[] args){        
        
            while (true){
                Console.WriteLine(WELCOME_MESSAGE);
                Cafe.ShowMenu();
                
                Console.Write(ORDER_MESSAGE);
                string input = Console.ReadLine() ?? string.Empty;
                if (input != null){
                    input = input.ToLower();
                }
                
                else{
                    input = string.Empty;
                }

                if (input == "yes"){
                    Console.WriteLine(MENU_MESSAGE);
                    string dishName = Console.ReadLine() ?? string.Empty;
                    Cafe.OrderDish(dishName);
                }
                
                else if (input == "no"){
                    Console.WriteLine(BYE_MESSAGE);
                    break;
                }
                
                else{
                    Console.WriteLine(INVALID_INPUT_MESSAGE);
                }
            }
        }
    }
}