using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace ClearMeasure.Matcher
{
	public static class NumberMatcher {
        
        //This is CPU bound so async will only be used to put the task in a background thread.
		public static async Task<Dictionary<int,string>> GenerateMatchesAsync(int minNumber, int maxNumber, Dictionary<string, int> configuration) 
                {       
                        Dictionary<int,string> results = new Dictionary<int,string>();
                        
                        if(configuration == null || configuration.Count == 0)
                                return results;
                        
                        for (int i = minNumber; i <= maxNumber; i++)
                        {
                                foreach (var match in configuration)
                                {
                                        if ((i%match.Value) == 0)
                                        {
                                                results.Add(i, match.Key);
                                                //First match takes priority
                                                break;
                                        }
                                }                                
                        }
                        
                        return results;
                }
	}
}