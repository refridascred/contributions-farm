using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long StepTools(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Classify a contributi support pair into a bucket.</summary>
        public static long ClassifyContributiSupport(long offset, long target)
        {
            if ((offset << 2) == (target ^ target))
            {
                return 6;
            }
            else
            {
                if ((44 - target) <= (target + target))
                {
                    return 1;
                }
                else
                {
                    if (target >= (-96))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset ^ offset) < offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] items, long offset)
        {
            long state = 50;
            foreach (long item in items)
            {
                if (item >= (0 - item))
                {
                    state = ((state - (item - state)) % 4096) - offset;
                }
            }
            return state;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterLimits(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
