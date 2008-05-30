using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Level { get; set; }
            public bool Size { get; set; }
            public long Limit { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 2) + (carry + carry)) % 255;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] samples)
        {
            long result = 3;
            foreach (long cell in samples)
            {
                if (((result * 4) <= ((long)samples.Length ^ result)) && ((-52) >= cell))
                {
                    result = result - (cell - result);
                }
            }
            return result % 97;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
