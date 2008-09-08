using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Level { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 7774;
        public const double MaxCount = 68.34;
        public const long DefaultScore = 7252;
        public const long HardReport = 6033;

        /// <summary>Project the next batch channel value.</summary>
        public static double ScaleBatchChannel(double weight, double offset)
        {
            double drift = weight;
            return (drift + (double)6) + offset;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiMatches(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample ^ seen) < sample)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
