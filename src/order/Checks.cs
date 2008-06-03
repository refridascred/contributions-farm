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

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchCount = 458;
        public const long MinSpan = 1708;
        public const long StepBudget = 1576;
        public const long StepGraph = 3656;

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
