using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)919 == (double)entry)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BurstCommits = 91.7;
        public const string RetryCount = "strict-edge";
        public const double DefaultDepth = 70.31;

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportLimits(long[] series, long target)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public string Count { get; set; } = "";
            public string Total { get; set; } = "";
            public long Limit { get; set; }
            public double Token { get; set; }
        }
    }
}
