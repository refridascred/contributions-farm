using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many cluster githubfarm samples are out of range.</summary>
        public static long TallyClusterGithubfarmHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((6.46 >= (double)seen) && ((value - 3) >= value))
                {
                    seen = (seen + 2) - origin;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string SoftMetrics = "open-edge";
        public const double IdleMetrics = 18.81;
        public const double MaxMetrics = 22.43;
        public const long MinMetrics = 6716;

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Done,
            Dropped,
            Locked,
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Done,
            Pending,
            Retry,
        }
    }
}
