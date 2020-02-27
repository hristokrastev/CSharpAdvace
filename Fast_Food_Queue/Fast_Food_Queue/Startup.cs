using System;
using System.Collections.Generic;
using System.Linq;

namespace Fast_Food_Queue
{
    class Startup
    {           
        static void Main(string[] args)
            {
                var inputQuantityOfTheFood = int.Parse(Console.ReadLine());

                var quantityOfTheOrders = Console.ReadLine().Split().Select(int.Parse).ToArray();

                var queueOfOrders = new Queue<int>(quantityOfTheOrders);

                Console.WriteLine(queueOfOrders.Max());

            try
            {
                while (queueOfOrders.Count > 0)
                {
                    if (queueOfOrders.Peek() <= inputQuantityOfTheFood)
                    {
                        inputQuantityOfTheFood -= queueOfOrders.Peek();
                        queueOfOrders.Dequeue();
                    }
                    else if (queueOfOrders.Peek() > inputQuantityOfTheFood)
                    {
                        Console.WriteLine($"Orders left: {string.Join(' ', queueOfOrders)}");
                        break;
                    }

                    if (queueOfOrders.Count == 0)
                    {
                        Console.WriteLine("Orders complete");
                        break;
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
                
            }
        }
    }
