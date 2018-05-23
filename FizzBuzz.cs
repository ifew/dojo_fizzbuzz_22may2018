using System;

namespace dojo_fizzbuzz_22may2018
{
    internal class FizzBuzz
    {
        public FizzBuzz()
        {
        }

        internal string say(int ask)
        {
            if(หาร3ลงตัว(ask) && หาร5ลงตัว(ask)){
                return "FIZZBUZZ";
            }
            else if(หาร3ลงตัว(ask)){
                return "FIZZ";
            }else if(หาร5ลงตัว(ask)){
                return "BUZZ";
            }
            return ask.ToString();
        }

        private bool หาร3ลงตัว(int ask)
        {
            return (ask % 3) == 0;
        }
          private bool หาร5ลงตัว(int ask)
        {
            return (ask % 5) == 0;
        }
    }
}