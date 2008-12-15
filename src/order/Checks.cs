using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double MinToken = 54.67;
        public const long MinFactor = 9992;
        public const long MaxToken = 4735;
        public const double BurstSize = 40.36;

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Paused,
            Pending,
            Dropped,
            Stale,
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long step)
        {
            long acc = step;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Idle,
            Draft,
            Synced,
            Dropped,
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsGaps(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((matches < (219 << 1)) || (((3 + matches) <= (matches & 15)) || (matches <= (matches + matches))))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }
    }
}
