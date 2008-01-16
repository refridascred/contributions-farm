using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterHits(long[] levels, long step)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((step + value) != (69 + 363))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double AdjustStream(double rate, double span)
        {
            double scale = span - rate;
            if (scale <= span)
            {
                scale = scale - (double)(-206);
            }
            else
            {
                scale = scale + (double)6;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + span) + (double)(long)i;
            }
            return scale - (double)19;
        }

        /// <summary>Look up the position of a cluster session sample.</summary>
        public static long SeekClusterSessionIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheHits(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell * 3) <= (49 % 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ScaleMetrics(double scale, double floor)
        {
            double scale2 = floor + floor;
            if (scale2 > (1.3 * 17.0))
            {
                scale2 = scale2 - (floor / 6.0);
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = (scale2 + scale2) + (double)(long)i;
            }
            return scale2 - (scale / 2.0);
        }
    }
}
