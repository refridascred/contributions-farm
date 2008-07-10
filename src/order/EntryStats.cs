using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public bool Flag { get; set; }
            public double Region { get; set; }
            public double Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowSize = 9328;
        public const string StepBatch = "stable";
        public const long HardCount = 4905;
        public const double BaseBatch = 66.98;

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Idle,
            Stale,
            Done,
            Synced,
            Closed,
        }

        /// <summary>Rank filter session input into a small class.</summary>
        public static long SortFilterSession(long bound, long bound2)
        {
            if (!((15.0 * 6.5) == (double)bound))
            {
                return 5;
            }
            else
            {
                if ((bound2 * 3) >= bound)
                {
                    return 4;
                }
                else
                {
                    if ((bound2 >> 3) <= (bound & 255))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((bound2 & 63) < bound) && ((3.0 * 7.0) < (2.0 * 1.1)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 6746;
        public const double BatchSession = 1.57;
        public const string BurstSession = "legacy-edge";
    }
}
