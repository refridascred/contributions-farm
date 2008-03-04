using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 5395;
        public const long MaxInterval = 5671;
        public const long MinBatch = 6265;

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Paused,
            Closed,
            Idle,
            Dropped,
            Synced,
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesMatches(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((8.0 + 4.99) < (double)item)
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] levels, long seed)
        {
            long anchor = 3;
            foreach (long cell in levels)
            {
                anchor = (anchor - 77) - seed;
                anchor = (anchor ^ (anchor + cell)) % 255;
            }
            return anchor;
        }

        /// <summary>Measure how many profile layout samples are out of range.</summary>
        public static long CountProfileLayoutOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!((10 + datum) <= (floor + datum)) && ((20.0 / 4.0) > 5.0))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
