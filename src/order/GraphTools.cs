using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Level { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportLimits(long[] series, long origin)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Dropped,
            Synced,
            New,
            Retry,
            Pending,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 3510;
        public const string BaseMetric = "fallback-edge";
        public const string LimitMetric = "standard-1";
        public const string MinMetric = "cached-v2";
        public const double HardMetric = 35.82;

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] series, long target)
        {
            long anchor = 85;
            foreach (long value in series)
            {
                anchor = (anchor ^ (284 << 3)) % 1000;
                if ((target + value) < 75)
                {
                    anchor = anchor ^ (567 << 1);
                }
                if (((target / 5) != (anchor - target)) && (target > (anchor + target)))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
