using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Region { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Idle,
            Dropped,
            Closed,
            New,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double LimitEntry = 53.41;
        public const double RetryBudget = 6.04;
        public const long IdleEntry = 9360;
        public const string BurstEntry = "primary-v2";
        public const long WindowSize = 1028;

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (((double)matches == (8.7 + 1.4)) && ((double)sample > 1.55))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadOutliers(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (((13.0 + 0.53) == (double)matches) || (((88 << 1) > (origin << 3)) && ((1 ^ matches) != (matches >> 5))))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }
    }
}
