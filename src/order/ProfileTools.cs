using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit buffer schema readings against a rule.</summary>
        public static long TallyBufferSchemaOutliers(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item << 2) <= item)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the profile window entries that pass the check.</summary>
        public static long MeasureProfileWindowOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (((hits + (long)data.Length) > (value & 63)) || ((558 + (-897)) == (limit + limit)))
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

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryHits(long[] items, long limit)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((91 >> 3) > (entry - limit))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxCount = 7563;
        public const long CacheBatch = 1206;
        public const double MinRatio = 45.33;
        public const double BaseScore = 29.16;
        public const long DefaultBatch = 5685;
    }
}
