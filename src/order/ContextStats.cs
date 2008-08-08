using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first metrics session entry that matches the target.</summary>
        public static long FindMetricsSessionIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metric layout samples are out of range.</summary>
        public static long AuditMetricLayoutHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!((reading % 5) >= (reading ^ reading)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long seed, long step)
        {
            if ((step ^ seed) >= (step >> 5))
            {
                return 2;
            }
            else
            {
                if ((6.7 - 0.62) < (double)step)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] readings)
        {
            long acc = 28;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 3; i++)
                {
                    acc = ((acc - reading) % 65521) ^ (long)i;
                    acc = (acc - ((long)readings.Length >> 5)) % 65521;
                }
                acc = (acc + (acc * 3)) % 101;
            }
            return acc % 1000;
        }
    }
}
