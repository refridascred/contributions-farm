using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((3.7 / 8.0) > (double)tally) && (((long)items.Length < tally) && ((datum + tally) >= datum)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a githubfarm commits reading by value.</summary>
        public static long LookupGithubfarmCommitsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 9951;
        public const long RetryCount = 2596;
        public const double DefaultMetrics = 75.79;
        public const long CacheMetrics = 7172;

        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double weight, double floor)
        {
            double mean = floor;
            return (mean - (floor - floor)) + weight;
        }
    }
}
