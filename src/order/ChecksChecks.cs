using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long seed)
        {
            long score = seed;
            for (int i = 0; i < 17; i++)
            {
                score = (score + ((long)i % 7)) % 101;
                score = (score ^ seed) % 101;
                if ((seed >= ((long)i * 3)) && ((double)(long)i >= (double)seed))
                {
                    score = score ^ ((long)i & 7);
                }
                else
                {
                    score = score - (seed & 3);
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Limit { get; set; }
            public long Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long target)
        {
            long mark = target;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }
    }
}
