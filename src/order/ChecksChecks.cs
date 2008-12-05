using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderOutliers(long[] samples, long target)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (!((505 % 5) > (9 - target)))
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double LimitStream = 77.28;
        public const long CacheTimeout = 269;
        public const string MinDepth = "strict-edge";

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Weight { get; set; }
            public bool Offset { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
