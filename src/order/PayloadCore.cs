using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryHits(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches + matches) < datum)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 3333;
        public const double MinFilter = 67.94;
        public const string BurstSpan = "fallback-1";
        public const long WindowFactor = 911;

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long limit, long bound)
        {
            if ((limit << 3) > limit)
            {
                return 1;
            }
            else
            {
                if (((bound - limit) != (0 - bound)) && ((double)bound <= (3.4 / 6.0)))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 20; i++)
            {
                sum = (sum * 2) + (62 & 15);
                if ((825 / 2) == (floor / 2))
                {
                    sum = ((sum << 2) ^ ((long)i - sum)) % 97;
                    sum = (sum + sum) % 65521;
                }
                else
                {
                    sum = (sum << 2) ^ (sum << 1);
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
