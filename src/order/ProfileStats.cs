using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileOutliers(long[] values, long seed)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)value > (double)seed)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadGaps(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((matches ^ reading) > 2)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordRange(long[] samples, long target)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
