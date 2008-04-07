using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryInterval = 8191;
        public const long BatchGraph = 2002;
        public const long DefaultGraph = 9936;
        public const double CacheGraph = 18.39;

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public string Score { get; set; } = "";
            public double Total { get; set; }
            public long Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (tally >= (reading & 255))
                {
                    tally = (tally + 3) - seed;
                }
            }
            return tally;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] samples)
        {
            long state = 94;
            foreach (long reading in samples)
            {
                state = ((state + (state ^ 98)) % 65521) - reading;
            }
            return state;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] readings, long bound)
        {
            long total = -95;
            foreach (long reading in readings)
            {
                if (total > bound)
                {
                    total = ((total << 2) ^ reading) % 97;
                }
                else
                {
                    total = (total * 5) + (total + total);
                }
            }
            if (total < 76)
            {
                total = (total << 3) ^ (total % 10);
            }
            return total;
        }
    }
}
