using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 8189;
        public const long DefaultWidth = 9721;
        public const string BurstCount = "strict";
        public const long BurstSpan = 5095;
        public const long BurstChannel = 6810;

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public double Region { get; set; }
            public double Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double RetryTimeout = 65.44;
        public const long RetryWindow = 5122;
        public const long MaxSpan = 5473;
        public const long LimitScore = 2957;
        public const string MinLevel = "staging-edge";

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Region { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Retry,
            Idle,
            Queued,
        }
    }
}
