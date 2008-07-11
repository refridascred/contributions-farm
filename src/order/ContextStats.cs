using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Score { get; set; } = "";
            public bool Weight { get; set; }
            public string Offset { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string WindowLevel = "primary-edge";
        public const long BaseLevel = 1429;
        public const double RetryBudget = 67.83;
        public const double BurstWidth = 19.86;

        /// <summary>Define profile limits and defaults.</summary>
        public const string SoftProfile = "local";
        public const long DefaultInterval = 9755;
        public const long BatchTimeout = 8345;
        public const long BatchScore = 567;

        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
