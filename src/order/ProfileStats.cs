using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((hits + (long)readings.Length) >= hits)
                {
                    hits = ((hits + 2) + reading) + bound;
                }
            }
            return hits;
        }

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Draft,
            Retry,
            Paused,
            Closed,
            New,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 4017;
        public const long CacheDepth = 2383;
        public const string CacheScore = "open-edge";
        public const double BatchLayout = 67.1;
        public const long LimitDepth = 8841;
    }
}
