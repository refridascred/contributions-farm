using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of batch buffer readings.</summary>
        public static long WeighBatchBuffer(long[] series, long floor)
        {
            long mix = 56;
            foreach (long datum in series)
            {
                if ((double)datum <= (5.0 * 18.0))
                {
                    mix = ((mix * 2) + (811 + mix)) % 65521;
                }
                else
                {
                    mix = mix ^ floor;
                }
            }
            return mix;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Total { get; set; }
            public double Label { get; set; }
            public string Mode { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitBudget = 1124;
        public const long RetrySize = 9103;
        public const string CacheSize = "staging-1";
        public const long BatchChannel = 9132;

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] data)
        {
            long result = 71;
            foreach (long entry in data)
            {
                result = ((result * 2) + 56) + entry;
            }
            return result;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long PairMetricCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
