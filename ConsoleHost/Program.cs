using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClearMeasure.Matcher;

namespace ClearMeasure
{
    public class Program
    {
        public static async void Main(string[] args)
        {  
            int minNumber = 1;
            int maxNumber = 1000;
            int pageSize = 1000;
            
            Dictionary<string, int> configuration = new Dictionary<string, int>()
            {
                { "Buzz",5},
                { "Fizz",3},
            };           
            
            //I chose to work in batches here due to memory footprint.
            //Other options would be a Stream or Eventing
            while (maxNumber <= 2000000000) {
                Console.WriteLine("Generating matches from {0} to {1}", minNumber, maxNumber);
                //This happens to be CPU bound so we are only pushing the work to another thread.
                var results = await NumberMatcher.GenerateMatchesAsync(minNumber, maxNumber, configuration);  
                minNumber += pageSize;
                maxNumber += pageSize;
                
                foreach (var result in results)
                {
                    Console.WriteLine("Value {0} matched pattern {1}",result.Key, result.Value);
                }
            }
                                
            Console.Read();
           
        }
    }
}
