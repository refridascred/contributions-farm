using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Ready,
            Synced,
            Dropped,
            Paused,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCommand = 8378;
        public const double DefaultRatio = 43.57;
        public const long MaxCommand = 6604;

        /// <summary>Measure how many record contributi samples are out of range.</summary>
        public static long MeasureRecordContributiMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((sample + sample) > sample)
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }
    }
}
