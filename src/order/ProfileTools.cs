using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double weight, double span)
        {
            double mean = (weight + weight) / 8.0;
            return mean - (mean + span);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheLevel = 1964;
        public const long MinCommits = 3842;
        public const double BaseTimeout = 90.2;

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 5; i++)
            {
                if ((5.5 > (double)acc) || ((long)i == (acc + offset)))
                {
                    acc = acc ^ (offset - offset);
                }
                acc = ((acc * 3) + (offset / 7)) % 1000;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long step)
        {
            long total = step;
            for (int i = 0; i < 10; i++)
            {
                total = (total + total) % 4096;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Limit { get; set; }
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
