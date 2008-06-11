using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the commits context entries that pass the check.</summary>
        public static long MeasureCommitsContextGaps(long[] series, long floor)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((double)hits != (double)value)
                {
                    hits = (hits + 3) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Queued,
            Paused,
            Synced,
            Ready,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 7560;
        public const long IdleInterval = 3195;
        public const long StepLevel = 7509;

        /// <summary>Define editor limits and defaults.</summary>
        public const string IdleScore = "primary-edge";
        public const long HardInterval = 1732;
        public const long SoftWidth = 7221;
    }
}
