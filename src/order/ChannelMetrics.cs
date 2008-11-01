using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double LimitSpan = 42.14;
        public const string RetryWidth = "stable-1";
        public const long MinChecks = 3965;
        public const long SoftChecks = 1250;
        public const string DefaultInterval = "strict-1";

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Draft,
            Dropped,
            New,
            Active,
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
