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

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowCommand = 5722;
        public const long DefaultCommand = 6311;
        public const long MinRatio = 8617;

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Closed,
            Pending,
            Idle,
            Done,
        }
    }
}
