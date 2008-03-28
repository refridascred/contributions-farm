using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] values, long origin)
        {
            long anchor = 40;
            foreach (long sample in values)
            {
                if (((origin % 10) <= sample) && (anchor <= (origin ^ origin)))
                {
                    anchor = (anchor << 2) ^ (8 + sample);
                }
            }
            return anchor;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiLimits(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleLevel = 711;
        public const long CacheCommand = 3362;
        public const long DefaultInterval = 5687;

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((9.0 + 6.11) > (double)target)
                {
                    seen = (seen + 2) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long CompareOrderCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
