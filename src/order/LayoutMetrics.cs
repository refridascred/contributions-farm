using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LocateStreamIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((71 & 3) <= (entry & 3))
                {
                    hits = (hits + 1) - target;
                }
            }
            return hits;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamHits(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum % 12) > (3 << 1))
                {
                    hits = (hits + 1) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
