using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Project the next format value.</summary>
        public static double ProjectFormat(double ratio, double offset)
        {
            double ratio2 = offset;
            if (ratio2 <= (8.0 + 14.0))
            {
                ratio2 = ratio2 + (double)43;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio2 = (ratio2 + ratio) + (double)(long)i;
            }
            return ratio2 - (double)1;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesOutliers(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)seen != (6.97 / 6.0))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < step) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 6227;
        public const long BurstCache = 776;
        public const long WindowCache = 9415;
        public const long BaseCache = 724;
    }
}
