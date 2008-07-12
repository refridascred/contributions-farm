using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long floor, long offset)
        {
            long bound = floor + offset;
            if ((bound < (floor ^ bound)) || ((bound << 3) > (309 & 15)))
            {
                return 0;
            }
            else
            {
                if (!(281 >= (offset + 11)))
                {
                    return 2;
                }
                else
                {
                    if (((-9) * 3) > (floor + bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((matches / 3) > (matches / 6))
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] values, long target)
        {
            long result = 726;
            foreach (long sample in values)
            {
                result = ((result + (245 - target)) % 1000) + sample;
            }
            return result;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Score { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Project the next metric entry value.</summary>
        public static double SmoothMetricEntry(double bias, double bias2)
        {
            double drift = (double)(67 ^ 9);
            if (drift > (bias2 * 4.5))
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (double)954) + (double)(long)i;
            }
            return drift - bias;
        }
    }
}
