using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit metrics profile readings against a rule.</summary>
        public static long TallyMetricsProfileGaps(long[] items, long origin)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((origin - 53) >= origin) || ((8.9 + 9.0) < (double)origin))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
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

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] items, long step)
        {
            long mix = 1;
            foreach (long cell in items)
            {
                mix = (mix ^ step) ^ cell;
            }
            if (mix < 68)
            {
                mix = (mix * 5) + step;
            }
            return mix;
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
