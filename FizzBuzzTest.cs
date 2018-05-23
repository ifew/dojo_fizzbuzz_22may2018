using System;
using Xunit;

namespace dojo_fizzbuzz_22may2018
{
    public class FizzBuzzTest
    {
        FizzBuzz fizzBuzz = new FizzBuzz();
        
        [Fact]
        public void When_Ask1_Should_Be_Say1()
        {
            var expected = "1";
            var say = 1;

            var result = fizzBuzz.say(say);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void When_Ask2_Should_Be_Say2()
        {
            var expected = "2";
            var ask = 2;

            var result = fizzBuzz.say(ask);

            Assert.Equal(expected, result);
        }
        
        [Fact]
        public void When_Ask3_Should_Be_SayFIZZ()
        {
            var expected = "FIZZ";
            var ask = 3;

            var result = fizzBuzz.say(ask);

            Assert.Equal(expected, result);
        }        
        
        [Fact]
        public void When_Ask4_Should_Be_Say4()
        {
            var expected = "4";
            var ask = 4;

            var result = fizzBuzz.say(ask);

            Assert.Equal(expected, result);
        }
        
        [Fact]
        public void When_Ask5_Should_Be_SayBUZZ()
        {
            var expected = "BUZZ";
            var ask = 5;

            var result = fizzBuzz.say(ask);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void When_Ask6_Should_Be_SayFIZZ()
        {
            var expected = "FIZZ";
            var ask = 6;

            var result = fizzBuzz.say(ask);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void When_Ask9_Should_Be_SayFIZZ()
        {
            var expected = "FIZZ";
            var ask = 9;

            var result = fizzBuzz.say(ask);

            Assert.Equal(expected, result);
        }
         [Fact]
        public void When_Ask10_Should_Be_SayBUZZ()
        {
            var expected = "BUZZ";
            var ask = 10;

            var result = fizzBuzz.say(ask);

            Assert.Equal(expected, result);
        }
        
         [Fact]
        public void When_Ask15_Should_Be_SayFIZZBUZZ()
        {
            var expected = "FIZZBUZZ";
            var ask = 15;

            var result = fizzBuzz.say(ask);

            Assert.Equal(expected, result);
        }
    }
}
