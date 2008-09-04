using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Pending,
            Done,
            Synced,
            Ready,
            Idle,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheOutliers(long[] data, long target)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item / 6) == ((long)data.Length + target))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 8622;
        public const long HardLevel = 2822;
        public const double IdleSize = 46.13;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorMatches(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry + 63) <= (entry << 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
