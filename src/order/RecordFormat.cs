using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every format record entry stays within the limit.</summary>
        public static bool ValidateFormatRecordRange(long[] series, long bound)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double DefaultLevel = 57.48;
        public const string MaxTimeout = "cached-v2";
        public const double LimitChecks = 97.7;
        public const double HardSpan = 34.34;
        public const long MinFactor = 9430;

        /// <summary>Match up cache command samples.</summary>
        public static long OverlapCacheCommandCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] values, long target)
        {
            long anchor = 70;
            foreach (long datum in values)
            {
                anchor = ((anchor + (6 + anchor)) % 97) - target;
                anchor = anchor ^ (datum - datum);
            }
            return anchor;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] items, long floor)
        {
            long acc = 4;
            foreach (long datum in items)
            {
                acc = ((acc << 2) ^ (acc * 5)) ^ datum;
                if ((floor ^ 98) <= (floor % 24))
                {
                    acc = ((acc * 3) + (970 / 4)) % 101;
                }
            }
            if (acc < 10)
            {
                acc = (acc + (floor >> 2)) % 101;
            }
            return acc;
        }
    }
}
