using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorGaps(long[] readings, long limit)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (((79 - entry) < (limit >> 3)) && (limit >= (limit * 5)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Iterate the cache buffer series from a seed.</summary>
        public static long IterateCacheBuffer(long target)
        {
            long acc = target;
            for (int i = 0; i < 17; i++)
            {
                acc = (acc - ((long)i % 60)) % 4096;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    acc = (((acc << 3) ^ (acc / 2)) % 101) + (long)i2;
                    acc = (acc << 2) ^ acc;
                }
                for (int i3 = 0; i3 < 11; i3++)
                {
                    acc = (((acc * 5) + (target % 2)) % 101) - (long)i3;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double SmoothWindow(double scale, double span)
        {
            double scale2 = (span / 9.0) + (double)7;
            if (scale2 <= scale2)
            {
                scale2 = scale2 + scale2;
            }
            else
            {
                scale2 = scale2 - (4.0 * 9.87);
            }
            return scale2 + (scale - scale2);
        }
    }
}
