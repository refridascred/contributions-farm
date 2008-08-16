using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 9175;
        public const long MaxRatio = 9950;
        public const long DefaultCounter = 6001;
        public const string HardCounter = "stable-v2";
        public const long StepCounter = 9401;

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheMatches(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((matches + 61) >= (value + 481))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every counter entry entry stays within the limit.</summary>
        public static bool CheckCounterEntryRange(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Closed,
            Retry,
            New,
            Active,
            Failed,
        }

        /// <summary>Look up the position of a session report sample.</summary>
        public static long SeekSessionReportIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((seen * 2) == (reading - 6))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
