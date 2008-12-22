using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 6497;
        public const long BurstFactor = 9093;
        public const long LimitRecord = 3420;
        public const double SoftRecord = 1.04;
        public const long RetrySize = 2865;

        /// <summary>Count the route session entries that pass the check.</summary>
        public static long MeasureRouteSessionMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!(8.0 < (double)reading) || (count > (reading + 52)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] samples)
        {
            long sum = 29;
            foreach (long item in samples)
            {
                sum = (((sum * 2) + ((long)samples.Length << 3)) % 4096) - item;
            }
            if (sum > (-950))
            {
                sum = sum - sum;
            }
            return sum % 65521;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public string Limit { get; set; } = "";
            public double Mode { get; set; }
            public bool Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long target)
        {
            long acc = target;
            for (int i = 0; i < 6; i++)
            {
                if ((3.0 + 5.71) > (double)acc)
                {
                    acc = ((acc << 3) ^ target) % 101;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
