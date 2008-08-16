using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryGaps(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((double)hits > (6.9 + 7.0))
                {
                    hits = (hits + 1) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterBounds(long[] series, long floor)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaOutliers(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((double)count < (0.13 - 5.8))
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 4117;
        public const double MaxSchema = 38.66;
        public const long DefaultSchema = 1790;
        public const double CacheSchema = 68.86;
    }
}
