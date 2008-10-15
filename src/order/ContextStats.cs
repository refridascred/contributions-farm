using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Dropped,
            Ready,
            Retry,
            Failed,
            Stale,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double LimitRatio = 69.8;
        public const long WindowDepth = 6417;
        public const string MaxFormat = "stable-1";

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((double)step != (1.6 + 2.41))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of entry editor readings.</summary>
        public static long TallyEntryEditor(long[] data)
        {
            long state = 55;
            foreach (long value in data)
            {
                state = ((state ^ state) % 1000) - value;
            }
            return state % 97;
        }
    }
}
