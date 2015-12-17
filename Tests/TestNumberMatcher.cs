using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using ClearMeasure.Matcher;

namespace Tests
{
    // see example explanation on xUnit.net website:
    // https://xunit.github.io/docs/getting-started-dnx.html
    public class SampleTest
    {
        [Fact]
        public async void TestFiveAndThree()
        {
            Dictionary<string, int> configuration = new Dictionary<string, int>()
            {
                { "Buzz",5},
                { "Fizz",3},
            };           
            
            var results = await NumberMatcher.GenerateMatchesAsync(1, 100, configuration); 
            Assert.Equal(47,results.Count);
            
            Assert.Equal("Fizz",results[3]);
            Assert.Equal("Buzz",results[5]);
            Assert.Equal("Fizz",results[6]);
            Assert.Equal("Fizz",results[9]);
            Assert.Equal("Buzz",results[10]);
            Assert.Equal("Fizz",results[12]);
            Assert.Equal("Buzz",results[15]);
            Assert.Equal("Fizz",results[18]);
            Assert.Equal("Buzz",results[20]);
            Assert.Equal("Fizz",results[21]);
            Assert.Equal("Fizz",results[24]);
            Assert.Equal("Buzz",results[25]);
            Assert.Equal("Fizz",results[27]);
            Assert.Equal("Buzz",results[30]);
            Assert.Equal("Fizz",results[33]);
            Assert.Equal("Buzz",results[35]);
            Assert.Equal("Fizz",results[36]);
            Assert.Equal("Fizz",results[39]);
            Assert.Equal("Buzz",results[40]);
            Assert.Equal("Fizz",results[42]);
            Assert.Equal("Buzz",results[45]);
            Assert.Equal("Fizz",results[48]);
            Assert.Equal("Buzz",results[50]);
            Assert.Equal("Fizz",results[51]);
            Assert.Equal("Fizz",results[54]);
            Assert.Equal("Buzz",results[55]);
            Assert.Equal("Fizz",results[57]);
            Assert.Equal("Buzz",results[60]);
            Assert.Equal("Fizz",results[63]);
            Assert.Equal("Buzz",results[65]);
            Assert.Equal("Fizz",results[66]);
            Assert.Equal("Fizz",results[39]);
            Assert.Equal("Buzz",results[70]);
            Assert.Equal("Fizz",results[72]);
            Assert.Equal("Buzz",results[75]);
            Assert.Equal("Fizz",results[78]);
            Assert.Equal("Buzz",results[80]);
            Assert.Equal("Fizz",results[81]);
            Assert.Equal("Fizz",results[84]);
            Assert.Equal("Buzz",results[85]);
            Assert.Equal("Fizz",results[87]);
            Assert.Equal("Buzz",results[90]);
            Assert.Equal("Fizz",results[93]);
            Assert.Equal("Buzz",results[95]);
            Assert.Equal("Fizz",results[96]);
            Assert.Equal("Fizz",results[99]);
            Assert.Equal("Buzz",results[100]);
        }
        
        
        [Fact]
        public async void TestFive()
        {
            Dictionary<string, int> configuration = new Dictionary<string, int>()
            {
                { "Buzz",5},
            };       
            
            var results = await NumberMatcher.GenerateMatchesAsync(1, 100, configuration); 
            
            Assert.Equal("Buzz",results[5]);
            Assert.Equal("Buzz",results[10]);
            Assert.Equal("Buzz",results[15]);
            Assert.Equal("Buzz",results[20]);
            Assert.Equal("Buzz",results[25]);
            Assert.Equal("Buzz",results[30]);
            Assert.Equal("Buzz",results[35]);
            Assert.Equal("Buzz",results[40]);
            Assert.Equal("Buzz",results[45]);
            Assert.Equal("Buzz",results[50]);
            Assert.Equal("Buzz",results[55]);
            Assert.Equal("Buzz",results[60]);
            Assert.Equal("Buzz",results[65]);
            Assert.Equal("Buzz",results[70]);
            Assert.Equal("Buzz",results[75]);
            Assert.Equal("Buzz",results[80]);
            Assert.Equal("Buzz",results[85]);
            Assert.Equal("Buzz",results[90]);
            Assert.Equal("Buzz",results[95]);
            Assert.Equal("Buzz",results[100]);    
            
            Assert.Equal(20,results.Count);
        }
        
        [Fact]
        public async void TestThree()
        {
            Dictionary<string, int> configuration = new Dictionary<string, int>()
            {
                { "Fizz",3},
            };           
            
            var results = await NumberMatcher.GenerateMatchesAsync(1, 100, configuration); 
            
            Assert.Equal("Fizz",results[3]);
            Assert.Equal("Fizz",results[6]);
            Assert.Equal("Fizz",results[9]);
            Assert.Equal("Fizz",results[12]);
            Assert.Equal("Fizz",results[15]);
            Assert.Equal("Fizz",results[18]);
            Assert.Equal("Fizz",results[21]);
            Assert.Equal("Fizz",results[24]);
            Assert.Equal("Fizz",results[27]);
            Assert.Equal("Fizz",results[30]);
            Assert.Equal("Fizz",results[33]);
            Assert.Equal("Fizz",results[36]);
            Assert.Equal("Fizz",results[39]);
            Assert.Equal("Fizz",results[42]);
            Assert.Equal("Fizz",results[45]);
            Assert.Equal("Fizz",results[48]);
            Assert.Equal("Fizz",results[51]);
            Assert.Equal("Fizz",results[54]);
            Assert.Equal("Fizz",results[57]);
            Assert.Equal("Fizz",results[60]);
            Assert.Equal("Fizz",results[63]);
            Assert.Equal("Fizz",results[66]);
            Assert.Equal("Fizz",results[39]);
            Assert.Equal("Fizz",results[72]);
            Assert.Equal("Fizz",results[75]);
            Assert.Equal("Fizz",results[78]);
            Assert.Equal("Fizz",results[81]);
            Assert.Equal("Fizz",results[84]);
            Assert.Equal("Fizz",results[87]);
            Assert.Equal("Fizz",results[90]);
            Assert.Equal("Fizz",results[93]);
            Assert.Equal("Fizz",results[96]);
            Assert.Equal("Fizz",results[99]);
            
            Assert.Equal(33,results.Count);
        }
        
        [Fact]
        public async void TestMissingConfiguration()
        {         
            
            var results = await NumberMatcher.GenerateMatchesAsync(1, 100, null); 
            
            Assert.Equal(0,results.Count);
        }
    }
}
