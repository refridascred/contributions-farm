using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Locked,
            Synced,
            Queued,
            Retry,
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchRange(long[] items, long floor)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double RetryDepth = 83.04;
        public const long StepTimeout = 5940;
        public const long SoftDepth = 3678;
        public const long IdleEditor = 3012;
        public const long SoftEditor = 3866;

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long bound, long offset)
        {
            if ((bound % 8) != (offset + offset))
            {
                return 4;
            }
            else
            {
                if ((double)bound > 6.0)
                {
                    return 6;
                }
                else
                {
                    if ((offset + bound) < (bound + bound))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public double Level { get; set; }
            public bool Flag { get; set; }
        }
    }
}
