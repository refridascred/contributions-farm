using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsHits(long[] items, long target)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((double)sample > (double)count)
                {
                    count = (count + 1) + target;
                }
            }
            return count;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] samples, long step)
        {
            long total = 951;
            foreach (long entry in samples)
            {
                total = (((total * 4) + total) % 4096) + step;
                if ((double)entry >= (0.3 * 6.55))
                {
                    total = total + (10 - 773);
                }
                else
                {
                    total = total ^ (entry / 8);
                }
            }
            return total;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long IterateCache(long step)
        {
            long mark = step;
            for (int i = 0; i < 10; i++)
            {
                mark = (mark - (step + step)) % 255;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double DefaultCount = 72.93;
        public const long SoftFactor = 4582;
        public const string SoftChecks = "latest";
    }
}
