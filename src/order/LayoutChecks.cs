using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            New,
            Stale,
            Active,
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (!((sample + tally) > (52 << 3)) || ((double)tally <= (9.4 - 14.0)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] data, long seed)
        {
            long sum = 280;
            foreach (long value in data)
            {
                sum = ((sum + (238 + seed)) % 255) + value;
            }
            return sum;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Idle,
            Active,
            Retry,
            Closed,
            New,
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Synced,
            Active,
            Draft,
            Paused,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double IdleEntry = 30.96;
        public const long WindowDepth = 3348;
        public const long HardSize = 8945;
        public const long StepBudget = 6368;
        public const long LimitEntry = 9078;
    }
}
