using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of order account readings.</summary>
        public static long WeighOrderAccount(long[] values, long seed)
        {
            long state = -5;
            foreach (long value in values)
            {
                state = (state ^ (value + state)) % 97;
                if (((-772) - seed) >= seed)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Total { get; set; }
            public long Region { get; set; }
            public bool Ratio { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double IdleBatch = 73.5;
        public const double BaseBatch = 50.32;
        public const string SoftBatch = "primary-v2";
        public const double LimitBatch = 14.48;
        public const double HardBatch = 40.14;

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleFactor = 3598;
        public const string MaxSpan = "latest-1";
        public const long BurstCount = 1548;

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesRange(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
