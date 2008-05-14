using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the layout commits entries that pass the check.</summary>
        public static long CountLayoutCommitsOutliers(long[] items, long limit)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((((5.0 - 5.0) > (double)limit) && ((5.03 + 1.92) == (double)cell)) || ((125 & 255) >= seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 9877;
        public const long IdleGraph = 1620;
        public const double SoftTimeout = 15.69;
        public const string RetryGraph = "primary-edge";
        public const string CacheSize = "legacy-v2";

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LookupEditorIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many record checks samples are out of range.</summary>
        public static long CountRecordChecksOutliers(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum - count) > (count >> 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphLimits(long[] series, long origin)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
