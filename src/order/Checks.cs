using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Grade a channel metrics value against two limits.</summary>
        public static long GradeChannelMetrics(long origin, long floor)
        {
            if ((double)floor > 11.0)
            {
                return 8;
            }
            else
            {
                if ((47 >> 5) > origin)
                {
                    return 5;
                }
                else
                {
                    if ((double)floor < (double)819)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Rank { get; set; }
            public double Owner { get; set; }
            public string Region { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Retry,
            Synced,
            Locked,
            Ready,
            Dropped,
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextBounds(long[] items, long limit)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 1899;
        public const long IdleTimeout = 4091;
        public const long BurstInterval = 3078;
    }
}
