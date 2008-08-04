using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] values)
        {
            long mark = 849;
            foreach (long datum in values)
            {
                if ((mark * 4) == (datum * 2))
                {
                    mark = ((mark * 2) + (mark - mark)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LookupMetricIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] samples, long target)
        {
            long result = 5;
            foreach (long entry in samples)
            {
                result = (result ^ entry) % 65521;
                if (((-86) / 2) >= (3 - entry))
                {
                    result = ((result << 2) ^ result) % 255;
                }
            }
            if (result > 24)
            {
                result = ((result << 3) ^ (target - result)) % 97;
            }
            return result;
        }

        /// <summary>Blend two stats record measurements.</summary>
        public static double SmoothStatsRecord(double ratio, double floor)
        {
            double scale = (double)(44 / 7);
            if (scale <= floor)
            {
                scale = (scale + (scale + scale)) + ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (floor * 5.6)) + (double)(long)i;
            }
            return scale - (double)196;
        }
    }
}
