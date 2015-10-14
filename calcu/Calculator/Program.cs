using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        private static object answer;

        static void Main(string[] args)
        {
            int i = 0;
            var command = "";
            var lastCommand = 0;

            while (command != "quit")
            {
                var commandParser = new CommandParser();
                Console.Write("[{0}] ", i);
                command = Console.ReadLine();


                Console.WriteLine(commandParser.Parse(command));
                answer = (commandParser.Parse(command));
                i++;
                 

                
                if (command == "last")
                {
                    
                    Console.WriteLine(answer);
                }
   
        }
                
                //Console.ReadLine();
                
            }
        }
    }


