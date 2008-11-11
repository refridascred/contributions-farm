using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double IdleDepth = 62.95;
        public const string RetryCount = "legacy-edge";
        public const long CacheCommand = 4959;
        public const double StepCommand = 80.06;
        public const double HardCommand = 61.53;

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long origin, long origin2)
        {
            if ((origin2 <= (8 - origin)) || ((double)origin < (3.8 / 6.0)))
            {
                return 5;
            }
            else
            {
                if ((double)origin2 == (0.6 * 15.0))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every account editor entry stays within the limit.</summary>
        public static bool VerifyAccountEditorBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultWindow = 95.61;
        public const long IdleWindow = 8702;
        public const string BatchWindow = "local";
        public const double HardWindow = 47.85;

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Region { get; set; }
            public bool Level { get; set; }
            public long Stamp { get; set; }
        }
    }
}
