using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the notes stats entries that pass the check.</summary>
        public static long MeasureNotesStatsOutliers(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (hits >= (hits - reading))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 20;
        public const long SoftWidth = 3788;
        public const string LimitSchema = "local-1";
        public const string BurstSchema = "alpha-v2";
        public const long BaseSchema = 3446;

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Synced,
            Locked,
            Active,
            New,
            Closed,
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Draft,
            Paused,
            Closed,
            Queued,
        }
    }
}
