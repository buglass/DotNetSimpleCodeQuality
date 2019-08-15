using System;

namespace DotNetSimpleCodeQuality
{
    class Program
    {
        static void Main(string[] args)
        {
            string opt = "";
            while(opt.ToUpper() != "Q")
            {
            Console.WriteLine("Choose your option");
            Console.WriteLine("1 - Add two numbers");
            Console.WriteLine("2 - Subtract two numbers");
            Console.WriteLine("3 - Add three numbers");
            Console.WriteLine("4 - Subtract three numbers");
            Console.WriteLine("5 - Measure my string");                
            opt = Console.ReadLine();
            string ione = "";
            string itwo="";
            string ithree = "";
                if(opt == "1")
                {
                    Console.WriteLine("Enter first number:");
                    ione=Console.ReadLine();
                    Console.WriteLine("Enter second number:");
                    itwo=Console.ReadLine();
                    Calculator c = new Calculator
                    {
                        firstnumber=int.Parse(ione),
                        secondnumber=int.Parse(itwo)
                    };
                    
                    c.add();
                    Console.WriteLine(c.result.ToString());
                }
                if(opt == "2")
                {
                    Console.WriteLine("Enter first number:");
                    ione=Console.ReadLine();
                    Console.WriteLine("Enter second number:");
                    itwo=Console.ReadLine();
                    Calculator c = new Calculator
                    {
                        firstnumber=int.Parse(ione),
                        secondnumber=int.Parse(itwo)
                    };
                    
                    c.subtract();
                    Console.WriteLine(c.result.ToString());
                }

                    if(opt == "3")
                    {
                        Console.WriteLine("Enter first number:");
                        ione=Console.ReadLine();
                        Console.WriteLine("Enter second number:");
                        itwo=Console.ReadLine();
                        Console.WriteLine("Enter third number:");
                        ithree=Console.ReadLine();                    
                        CalculateThreethings ctt = new CalculateThreethings
                        {
                            firstnumber=int.Parse(ione),
                            secondnumber=int.Parse(itwo),
                            thirdnumber=int.Parse(ithree)
                            
                        };
                        
                        ctt.add();
                        Console.WriteLine(ctt.result.ToString());
                    }

                    if(opt == "4")
                    {
                        Console.WriteLine("Enter first number:");
                        ione=Console.ReadLine();
                        Console.WriteLine("Enter second number:");
                        itwo=Console.ReadLine();
                    Console.WriteLine("Enter third number:");
                    ithree=Console.ReadLine();                    
                    CalculateThreethings ctt = new CalculateThreethings
                    {
                        firstnumber=int.Parse(ione),
                        secondnumber=int.Parse(itwo),
                        thirdnumber=int.Parse(ithree)
                        
                    };
                        
                        ctt.subtract();
                        Console.WriteLine(ctt.result.ToString());
                    }

                if(opt == "5")
                {
                    Console.WriteLine("Enter your string:");
                    ione=Console.ReadLine();
                    Stringcounter sc = new Stringcounter
                    {
                        myString = ione
                    };
                    sc.CountmyString();
                    Console.WriteLine(sc.TellmeAboutit());
                }


            }
            Console.WriteLine("Goodbye!");
        }
    }
}
