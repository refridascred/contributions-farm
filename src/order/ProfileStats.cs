using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            New,
            Failed,
            Closed,
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long SeekProfileIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Synced,
            Locked,
            Dropped,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 8356;
        public const string RetryEntry = "primary-edge";
        public const long IdleDepth = 3443;
        public const double IdleRatio = 65.31;
    }
}
